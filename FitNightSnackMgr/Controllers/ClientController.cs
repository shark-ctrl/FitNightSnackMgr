using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FitNightSnackMgr.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using FitNightSnackMgr.Models;
using FitNightSnackMgr.ViewModels;
using FitNightSnackMgr.ViewModels.ClientViewModel;
using Microsoft.Extensions.Logging;
using FitNightSnackMgr.ViewModels.ShoppingCartViewModel;
using FitNightSnackMgr.ViewModels.Other;

namespace FitNightSnackMgr.Controllers
{
    public class ClientController : Controller
    {
        private readonly FitNightSnackMgrContext _context;
        private readonly ILogger _logger;

        public ClientController(FitNightSnackMgrContext context, ILogger<ClientController> logger)
        {
            _context = context;
            _logger = logger;
        }





        // GET: ClientController
        public ActionResult Index()
        {
            var snackitems = _context.SnackInfo.Where(s => s.Status != -1).OrderByDescending(s => s.CreateTime).Take(3).ToList();
            return View(snackitems);
        }


        // GET: ClientController/Details/5
        public ActionResult Details(int id)
        {

            var item = _context.SnackInfo.FirstOrDefault(s => s.SnackNum == id);

            return View(item);
        }

        // GET: ClientController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ClientController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ClientController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ClientController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ClientController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ClientController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }




        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }




        public async Task<IActionResult> SnackShowAsync(int id, int? pageNumber)
        {

            int total = _context.SnackInfo.Count();
            int pagecount = total / 6 + 1;
            if (pagecount > 10) pagecount = 10;

            PaginatedList<SnackInfo> snackitems = await PaginatedList<SnackInfo>.CreateAsync(_context.SnackInfo.Where(s => s.Status != -1 && s.CategoryId == id).OrderByDescending(s => s.Price), pageNumber ?? 1, 6);

            SnackShowViewModel snackShowViewModel = new SnackShowViewModel()
            {

                SnackInfos = snackitems,
                PageIndex = pageNumber ?? 1,
                PageTotal = pagecount
            };





            return View(snackShowViewModel);
        }



        public IActionResult Login() => View();



        [HttpPost]
        public IActionResult Login(User user)
        {
            _logger.LogInformation("------\r\nindex：hello world\r\n------");

            string account = user.UserAccount;
            string password = PassWordHelper.Md532Salt(user.Password, user.UserAccount);


            var usr = _context.User.FirstOrDefault(u => u.UserAccount == user.UserAccount && u.Password == password);
            if (usr != null)
            {
                SaveSession("usr_name", usr.UserName);
                SaveSession("usr_id", usr.Id.ToString());
                SaveSession("usr_account", usr.UserAccount);
                return RedirectToAction("index");

            }

            return View();

        }



        public IActionResult Register() => View();

        [HttpPost]
        public IActionResult Register(User user)
        {
            user.Password = PassWordHelper.Md532Salt(user.Password, user.UserAccount);
            user.CreateTime = DateTime.Now;
            user.UserName = $"用户{PassWordHelper.GenerateCheckCode(4)}";
            _context.Add(user);
            _context.SaveChanges();

            return RedirectToAction("Login");
        }




        public void SaveSession(string key, string value)
        {
            if (value == null || value == "") return;

            string session_value = HttpContext.Session.GetString(key);

            HttpContext.Session.SetString(key, value);


        }


        [HttpPost]
        public string GetUserName()
        {
            string username = GetSession("usr_name");

            if (username == "null")
                return "匿名用户";

            return username;

        }




        public string GetSession(string key)
        {

            string session_value = HttpContext.Session.GetString(key);
            if (session_value == null)
                session_value = "null";
            return session_value;
        }


        public IActionResult Logout()
        {

            HttpContext.Session.Remove("usr_name");

            return RedirectToAction("Login");

        }




        public IActionResult ShopHistory() => View();


        public IActionResult UserInfo() => View();


        public IActionResult UpdatePwd() => View();





        public JsonResult AddToCart(int snackNum, int snackCount)
        {
            ShoppingCart cartShop;
            try
            {
                cartShop = _context.ShoppingCart.FirstOrDefault(s => s.SnackId == snackNum && s.UserId == Convert.ToInt32(GetSession("usr_id")));
            }
            catch (Exception e)
            {
                Result result = new Result()
                {

                    StatusCode = 110,
                    Message = $"{e.Message}"

                };
                return Json(result);
            }

            decimal onePrice = _context.SnackInfo.FirstOrDefault(s => s.SnackNum == snackNum).Price;

            if (cartShop != null)
            {
                cartShop.SnackCount += snackCount;
                _context.Update(cartShop);


            }
            else
            {

                ShoppingCart shoppingCart = new ShoppingCart()
                {
                    UserId = Convert.ToInt32(GetSession("usr_id")),
                    SnackId = snackNum,
                    SnackCount = snackCount,
                    TotalMoney = onePrice * snackCount


                };
                _context.Add(shoppingCart);

            }

            _context.SaveChangesAsync();


            Result result1 = new Result()
            {
                StatusCode = 20000,
                Message = "添加成功"

            };
            return Json(result1);
        }


        public IActionResult ShopCart()
        {
            var shoppintCartList = _context.ShoppingCart.Where(s => s.UserId == Convert.ToInt32(GetSession("usr_id"))).ToList();
            List<ShoppingCartViewModel> cartViewList = new List<ShoppingCartViewModel>();

            foreach (var item in shoppintCartList)
            {
                var snack = _context.SnackInfo.FirstOrDefault(s => s.SnackNum == item.SnackId);
                ShoppingCartViewModel viewmodel = new ShoppingCartViewModel()
                {
                    SnackId = item.SnackId,
                    SnackName = snack.Name,
                    SnackCount = item.SnackCount,
                    TotalPrice = item.TotalMoney,
                    UnitPrice = snack.Price
                };
                cartViewList.Add(viewmodel);
            }


            return View(cartViewList);
        }

        [HttpPost]
        public bool RemoveCartSnack(int snackNum)
        {
            var cartSnack = _context.ShoppingCart.FirstOrDefault(s => s.SnackId == snackNum);

            if (cartSnack != null)
            {
                _context.Remove(cartSnack);
                _context.SaveChanges();
                return true;

            }
            return false;
        }

        [HttpPost]
        public bool Confirm(double totalPrice, string secret)
        {

            try
            {

                var shopcart = _context.ShoppingCart.Where(s => s.UserId == Convert.ToInt32(GetSession("usr_id"))).ToList();
                string details = "";
                foreach (var item in shopcart)
                {
                    details += $"{_context.SnackInfo.FirstOrDefault(s => s.SnackNum == item.SnackId).Name}*{item.SnackCount} ";

                }
                Order order = new Order()
                {
                    OrderId = DateTime.Now.ToString("yyyyMMddhhmmss") + GetSession("usr_id"),
                    UserId = Convert.ToInt32(GetSession("usr_id")),
                    Discount = 1,
                    OrderDetail = details,
                    TotalPrice = totalPrice,
                    CreateTime = DateTime.Now,
                    Status = 0


                };
                _context.Add(order);

                _context.RemoveRange(shopcart);
                _context.SaveChanges();

                return true;


            }
            catch {


                return false;

            }





        }





        public IActionResult AddMoney() => View();



        [HttpPost]
        public int UpdatePwd(string old_pwd, string new_pwd)
        {
            string user_account = GetSession("usr_account");
            string md5_salt_pwd = PassWordHelper.Md532Salt(old_pwd, user_account);

            var user = _context.User.FirstOrDefault(u => u.UserAccount == user_account && u.Password == md5_salt_pwd);

            if (user != null)
            {
                user.Password = PassWordHelper.Md532Salt(new_pwd, user_account);
                _context.Update(user);
                _context.SaveChanges();
                return 20000;

            }

            return 20001;


        }



        [HttpPost]
        public JsonResult GetUserInfo()
        {
            int userId = Convert.ToInt32(GetSession("usr_id"));

            var user = _context.User.FirstOrDefault(u => u.Id == userId);

            //string username = user.UserName;
            //decimal money = user.Money;
            //string phone = user.Phone;
            //string address = user.Address;

            ClientUser clientUser = new ClientUser()
            {
                Username = user.UserName,
                Money = user.Money,
                Phone = user.Phone,
                Address = user.Address

            };

            return Json(clientUser);


        }


        public bool SaveClientUserInfo(string username, string phone, string address)
        {
            try
            {
                int userId = Convert.ToInt32(GetSession("usr_id"));

                var user = _context.User.FirstOrDefault(u => u.Id == userId);

                user.UserName = username;
                user.Phone = phone;
                user.Address = address;

                _context.Update(user);
                _context.SaveChanges();

                return true;
            }
            catch (Exception)
            {

                return false;
            }

        }



        [HttpPost]
        public JsonResult AddClientUserMoney(string cardNum,string cardSecret)
        {
            int userId = Convert.ToInt32(GetSession("usr_id"));

            var user = _context.User.FirstOrDefault(u => u.Id == userId);

            var card = _context.prepaidCard.FirstOrDefault(c => c.CardCode == cardNum && c.SecretKey == cardSecret);
            Result result = new Result();

            if (card != null&&card.CardStatus!=-1)
            {

                user.Money +=Convert.ToDecimal(card.Price);
                card.CardStatus = -1;
                _context.Update(user);
                _context.Update(card);
                _context.SaveChanges();
                result.Message = $"充值成功，本次充值金额为{card.Price}";
                result.StatusCode = 20000;
                return Json(result);
            }


            result.Message = $"充值失败，该卡号状态异常";
            result.StatusCode = 20001;
            return Json(result);





        }

    }
}

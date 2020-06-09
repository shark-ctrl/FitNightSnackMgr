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

namespace FitNightSnackMgr.Controllers
{
    public class ClientController : Controller
    {
        private readonly FitNightSnackMgrContext _context;

        public ClientController(FitNightSnackMgrContext context)
        {
            _context = context;
        }





        // GET: ClientController
        public ActionResult Index()
        {
            var snackitems = _context.SnackInfo.Where(s => s.SnackNum == 1000).ToList();
            return View(snackitems);
        }
      

        // GET: ClientController/Details/5
        public ActionResult Details(int id)
        {

            var item = _context.SnackInfo.FirstOrDefault(s => s.Id == id);

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




        public async Task<IActionResult> SnackShowAsync(int id,int? pageNumber)
        {

            int total = _context.SnackInfo.Count();
            int pagecount = total / 6 + 1;
            if (pagecount > 10) pagecount = 10;
           
            PaginatedList <SnackInfo> snackitems = await PaginatedList<SnackInfo>.CreateAsync(_context.SnackInfo.Where(s => s.Status != -1&&s.CategoryId==id).OrderByDescending(s => s.Price), pageNumber ?? 1, 6);

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
            string account = user.UserAccount;
            string password = PassWordHelper.Md532Salt(user.Password, user.UserAccount);

            var usr = _context.User.Where(u => u.UserAccount == user.UserAccount && u.Password == password);
            if(usr.Count()>0)
                return RedirectToAction("index");
            return View();

        }



        public IActionResult Register() => View();

        [HttpPost]
        public IActionResult Register(User user)
        {
            user.Password = PassWordHelper.Md532Salt(user.Password, user.UserAccount);
            user.CreateTime = DateTime.Now;
            _context.Add(user);
            _context.SaveChanges();

            return RedirectToAction("Login");
        }



    }
}

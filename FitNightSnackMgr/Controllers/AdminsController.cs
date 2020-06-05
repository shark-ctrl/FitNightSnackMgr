using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FitNightSnackMgr.Data;
using FitNightSnackMgr.Models;
using FitNightSnackMgr.ViewModels;
using FitNightSnackMgr.Tools;
using Microsoft.AspNetCore.Http;
using FitNightSnackMgr.ViewModels.AdminViewModels;
using System.Reflection.Metadata;

namespace FitNightSnackMgr.Controllers
{



    enum Permissions { BOSS = 0, WORKER = 1 }
    public class AdminsController : Controller
    {
        private readonly FitNightSnackMgrContext _context;

        public AdminsController(FitNightSnackMgrContext context)
        {
            _context = context;
        }


        //public IActionResult Index(AdminIndexViewModel admin)
        //{
        //    SaveSession("username", admin.AdminName);
        //    SaveSession("permission", admin.Admin_permission.ToString());
        //    SaveSession("admin_id", admin.AdminId.ToString());


        //    AdminViewModel adminViewModel = new AdminViewModel();

        //    int admin_permission = GetSessionAndConvertToInt("permission");

        //    if (IsBoss(admin_permission))
        //        adminViewModel.Admins = _context.Admin.Where(a=>a.Permissions!=-1).ToList();
        //    else
        //        adminViewModel.Admins = null;

        //    adminViewModel.AdminName = GetSession("username");
        //    adminViewModel.Admin_permission = GetSession("permission");
        //    adminViewModel.AdminId = Convert.ToInt32(GetSession("admin_id"));

        //    return View(adminViewModel);
        //}


        public IActionResult Index(string username, int? userid, int? permission, string token, string account)
        {
            //if (username == null || !userid.HasValue || !permission.HasValue || token == null || PassWordHelper.Md532Salt(userid + username + permission, account) != token)


            if ( (username == null || !userid.HasValue || !permission.HasValue || token == null || PassWordHelper.Md532Salt(userid + username + permission, account) != token) && (GetSession("admin_id") == null || GetSession("username") == null || GetSession("permission") == null || GetSession("account") == null || GetSession("token") == null || PassWordHelper.Md532Salt(GetSession("admin_id") + GetSession("username") + GetSession("permission"), GetSession("account")) != GetSession("token")))
                return RedirectToAction("Login", "Admins");



            userid = userid ?? Convert.ToInt32(GetSession("admin_id"));
           
            SaveSession("permission", permission.ToString());
          
            SaveSession("token", token);
            SaveSession("account", account);



            AdminViewModel adminViewModel = new AdminViewModel();

            int admin_permission = GetSessionAndConvertToInt("permission");

            if (IsBoss(admin_permission))
                adminViewModel.Admins = _context.Admin.Where(a => a.Permissions != -1&&a.Id!= userid ).ToList();
            else
                adminViewModel.Admins = null;

            adminViewModel.AdminName = GetSession("username");
            adminViewModel.Admin_permission = GetSession("permission");
            adminViewModel.AdminId = Convert.ToInt32(GetSession("admin_id"));

            return View(adminViewModel);
        }




        public void SaveSession(string key, string value)
        {
            if (value == null || value == "") return;

            string session_value = HttpContext.Session.GetString(key);

            HttpContext.Session.SetString(key, value);


        }

        public int GetSessionAndConvertToInt(string key)
        {
            string session_value = HttpContext.Session.GetString(key);
            return Convert.ToInt32(session_value);
        }


        public string GetSession(string key)
        {

            string session_value = HttpContext.Session.GetString(key);
            if (session_value == null)
                session_value = "null";
            return session_value;
        }

        // GET: Admins/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (!IsSafe())
            {

                return RedirectToAction("Login", "Admins");
            }
            if (id == null)
            {
                return NotFound();
            }

            var admin = await _context.Admin
                .FirstOrDefaultAsync(m => m.Id == id);
            if (admin == null)
            {
                return NotFound();
            }

            AdminViewModel adminViewModel = new AdminViewModel()
            {
                WorkMan = admin,
                AdminName = GetSession("username"),
                AdminId = Convert.ToInt32(GetSession("admin_id"))
            };

            return View(adminViewModel);
        }

        // GET: Admins/Create
        public IActionResult Create()
        {
            if (PassWordHelper.Md532Salt(GetSession("admin_id") + GetSession("username") + GetSession("permission"), GetSession("account")) != GetSession("token"))
                return RedirectToAction("Login", "Admins");
            AdminViewModel adminViewModel = new AdminViewModel()
            {
                AdminName = GetSession("username"),
                AdminId = Convert.ToInt32(GetSession("admin_id")),
                Password = PassWordHelper.GenerateCheckCode(8)

            };
            return View(adminViewModel);
        }

        // POST: Admins/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create(AdminViewModel admin_view_model)
        //{



        //    if (ModelState.IsValid)
        //    {
        //        admin_view_model.WorkMan.PassWord = PassWordHelper.Md532Salt(admin_view_model.WorkMan.PassWord,admin_view_model.WorkMan.AdminName) ;
        //        admin_view_model.WorkMan.CreateTime = DateTime.Now;

        //        _context.Add(admin_view_model.WorkMan);
        //        await _context.SaveChangesAsync();              

        //        return RedirectToAction("Index","Admins",admin_view_model.WorkMan);
        //    }

        //    admin_view_model.AdminName = GetSession("username");
        //    return View(admin_view_model);
        //}

        public bool IsSafe()
        {

            if ((GetSession("admin_id") == null || GetSession("username") == null || GetSession("permission") == null || GetSession("account") == null || GetSession("token") == null || PassWordHelper.Md532Salt(GetSession("admin_id") + GetSession("username") + GetSession("permission"), GetSession("account")) != GetSession("token")))
                return false;
            return true;
        }


        [HttpPost]
        public async Task<bool> Create(string account, string password, string name, int permission)
        {

            Admin admin = new Admin()
            {
                LoginAccount = account,
                PassWord = PassWordHelper.Md532Salt(password, account),
                AdminName = name,
                Permissions = permission,
                CreateTime = DateTime.Now

            };

            if (ModelState.IsValid)
            {
                _context.Add(admin);
                await _context.SaveChangesAsync();
                return true;
            }

            return false;
        }



        // GET: Admins/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (!IsSafe())
                return RedirectToAction("Login", "Admins");
            if (id == null)
            {
                return NotFound();
            }

            var admin = await _context.Admin.FindAsync(id);
            if (admin == null)
            {
                return NotFound();
            }

            var admin_view_model = new AdminViewModel
            {
                WorkMan = admin,
                AdminName = HttpContext.Session.GetString("username"),
                AdminId = Convert.ToInt32(GetSession("admin_id"))
            };

            return View(admin_view_model);
        }

        // POST: Admins/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, AdminViewModel adminEditView)
        {
            if (!IsSafe())
                return RedirectToAction("Login", "Admins");
            if (id != adminEditView.WorkMan.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    string not_encrypted = adminEditView.WorkMan.PassWord;
                    //adminEditView.WorkMan.PassWord = PassWordHelper.Md532Salt(not_encrypted, adminEditView.WorkMan.LoginAccount);
                    adminEditView.WorkMan.CreateTime = DateTime.Now;
                    _context.Update(adminEditView.WorkMan);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AdminExists(adminEditView.WorkMan.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }


                return RedirectToAction("Index", "Admins", adminEditView);

                // return RedirectToAction(nameof(Index));
            }
            return View(adminEditView);
        }

        // GET: Admins/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (!IsSafe())
                return RedirectToAction("Login", "Admins");
            if (id == null)
            {
                return NotFound();
            }

            var admin = await _context.Admin
                .FirstOrDefaultAsync(m => m.Id == id);
            if (admin == null)
            {
                return NotFound();
            }

            AdminViewModel adminViewModel = new AdminViewModel()
            {
                WorkMan = admin,
                AdminName = GetSession("username"),
                AdminId = Convert.ToInt32(GetSession("admin_id"))

            };
            return View(adminViewModel);
        }

        // POST: Admins/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (!IsSafe())
                return RedirectToAction("Login", "Admins");
            var admin = await _context.Admin.FindAsync(id);
            admin.Permissions = -1;
            _context.Admin.Update(admin);
            await _context.SaveChangesAsync();
            //SaveSession("username", username);
            //SaveSession("permission", permission.ToString());
            //SaveSession("admin_id", userid.ToString());
            //SaveSession("token", token);
            //SaveSession("account", account);

            return RedirectToAction(nameof(Index), new { username = GetSession("username"), permission = GetSession("permission"), userid = GetSession("admin_id"), token = GetSession("token"), account = GetSession("account") });

        }

        private bool AdminExists(int id)
        {
            return _context.Admin.Any(e => e.Id == id);
        }


        public ActionResult Login() => View();
       


        //[HttpPost]
        //public ActionResult Login(Admin admin_only_account_password)
        //{
        //    bool res = CongdingTools.CheckObj(admin_only_account_password);

        //    if (!res) return View();



        //    string ori_password = admin_only_account_password.PassWord;
        //    string md5_password = PassWordHelper.Md532Salt(ori_password, admin_only_account_password.LoginAccount);



        //    if (IsAdminExists(admin_only_account_password.LoginAccount, md5_password))
        //    {
        //        var admin = _context.Admin.First(a => a.LoginAccount == admin_only_account_password.LoginAccount);

        //        AdminIndexViewModel adminIndexViewModel = new AdminIndexViewModel()
        //        {
        //            AdminName=admin.AdminName,
        //            AdminId=admin.Id,
        //            Admin_permission=admin.Permissions
        //        };


        //        return RedirectToAction("Index", adminIndexViewModel);
        //    }


        //    return View();


        //}

        [HttpPost]
        public JsonResult Login(string account, string password)
        {


            string md5_salt_password = PassWordHelper.Md532Salt(password, account);
            AdminLoginViewModel adminLoginViewModel = null;
            if (IsAdminExists(account, md5_salt_password))
            {
                var admin = _context.Admin.First(a => a.LoginAccount == account && a.PassWord == md5_salt_password);


                SaveSession("username", admin.AdminName);
                SaveSession("admin_id", admin.Id.ToString());

                adminLoginViewModel = new AdminLoginViewModel()
                {
                    UserName = admin.AdminName,
                    UserId = admin.Id,
                    status = 200,
                    Permission = admin.Permissions,
                    Account = admin.LoginAccount,
                    Token = PassWordHelper.Md532Salt(admin.Id + admin.AdminName + admin.Permissions, account)

                };
                return Json(adminLoginViewModel);
            }
            adminLoginViewModel = new AdminLoginViewModel()
            {
                status = 400

            };

            return Json(adminLoginViewModel);

        }

        public IActionResult Logout()
        {
            //SaveSession("username", username);
            //SaveSession("permission", permission.ToString());
            //SaveSession("admin_id", userid.ToString());
            //SaveSession("token", token);
            //SaveSession("account", account);


            HttpContext.Session.Remove("username");
            HttpContext.Session.Remove("permission");
            HttpContext.Session.Remove("admin_id");
            HttpContext.Session.Remove("token");
            HttpContext.Session.Remove("account");
            return View(nameof(Login));
        }




        public void RemoveSession()
        {
            HttpContext.Session.Remove("username");
            HttpContext.Session.Remove("permission");
            HttpContext.Session.Remove("admin_id");
            HttpContext.Session.Remove("token");
            HttpContext.Session.Remove("account");

        }

        public bool IsAdminExists(string login_account, string password)
        {
            return _context.Admin.Any(a => a.LoginAccount == login_account && a.PassWord == password);
        }




        public bool IsBoss(int permission)
        {
            if (permission == (int)Permissions.BOSS)
                return true;
            return false;
        }



        // GET: Admins/Edit/5
        public async Task<IActionResult> UpdatePassWord(int? id)
        {
            if (!IsSafe())
                return RedirectToAction("Login", "Admins");
            if (id == null)
            {
                return NotFound();
            }

            var admin = await _context.Admin.FindAsync(id);
            if (admin == null)
            {
                return NotFound();
            }

            AdminViewModel adminViewModel = new AdminViewModel()
            {
            AdminId=admin.Id,
            AdminName=admin.AdminName,
            Password=admin.PassWord
            };

            return View(adminViewModel);
        }



        [HttpPost]
        public async Task<int> UpdatePassWord(int? id,string oldpassword,string newpassword)
        {
            if (!IsSafe())
                return 301;//恶意修改
            if (id == null)
            {
                return 302;//查无此人
            }

            var admin = await _context.Admin.FindAsync(id);
            if (admin == null)
            {
                return 302;//查无此人
            }

            string database_old_password = admin.PassWord;
            string para_old_password = PassWordHelper.Md532Salt(oldpassword, admin.LoginAccount);
            if (database_old_password != para_old_password)
                return 303;//旧密码错误

            string md5_salt_new_password = PassWordHelper.Md532Salt(newpassword, admin.LoginAccount);

            admin.PassWord = md5_salt_new_password;
            _context.Update(admin);
            await _context.SaveChangesAsync();
            RemoveSession();
            return 310;//修改成功
        }

        [HttpPost]
        public JsonResult GetAdminInfo()
        {
            int admin_id =Convert.ToInt32(GetSession("admin_id"));
            string name = GetSession("username");


            AdminViewLayoutModel layout_data = new AdminViewLayoutModel()
            {
                AdminId = admin_id,
                Name = name

            };

            return Json(layout_data);
        }


     
        // GET: Admins/Edit/5
        public async Task<IActionResult> AdminInfo(int? id)
        {
            if (!IsSafe())
                return RedirectToAction("Login", "Admins");
            if (id == null)
            {
                return NotFound();
            }

            var admin = await _context.Admin.FindAsync(id);
            if (admin == null)
            {
                return NotFound();
            }

           

            return View(admin);
        }




        [HttpPost]
        public JsonResult ResetPwd(int? id)
        {
            ResetPwdModel resetPwdModel = null;
            if (!IsSafe())
            {
                resetPwdModel = new ResetPwdModel()
                {
                    Code = 519,
                    Message = "管理员账号状态存在异常，请联系运维人员"
                };
                return Json(resetPwdModel);
         
            }

            var admin = _context.Admin.FirstOrDefault(a => a.Id == id);

            if (admin == null)
            {
                resetPwdModel = new ResetPwdModel()
                {
                    Code = 518,
                    Message = "该用户状态异常，请联系运维人员"
                };
                return Json(resetPwdModel);

            }

            string password = PassWordHelper.GenerateCheckCode(8);
            string database_pwd = PassWordHelper.Md532Salt(password, admin.LoginAccount);
            admin.PassWord = database_pwd;
            _context.Update(admin);
            _context.SaveChanges();

            resetPwdModel = new ResetPwdModel()
            {
                Code = 520,
                Message = $"密码重置成功,该管理员密码为{password}，请妥善保管",
                NewPwd=database_pwd
            };
            return Json(resetPwdModel);



        }



        [HttpPost]
        public bool CheckAccount(string account)
        {
            var admin = _context.Admin.FirstOrDefault(a => a.LoginAccount == account);
            if (admin == null) return true;

            return false;
        
        
        }






    }
}

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

namespace FitNightSnackMgr.Controllers
{



    enum Permissions { BOSS=0, WORKER=1}
    public class AdminsController : Controller
    {
        private readonly FitNightSnackMgrContext _context;

        public AdminsController(FitNightSnackMgrContext context)
        {
            _context = context;
        }

        // GET: Admins
        public IActionResult Index(Admin admin)
        {
            SaveSession("username", admin.AdminName);
            SaveSession("permission", admin.Permissions.ToString());


            AdminViewModel adminViewModel = new AdminViewModel();

            int admin_permission = GetSessionAndConvertToInt("permission");

            if (IsBoss(admin_permission))
                adminViewModel.Admins = _context.Admin.Where(a=>a.Permissions!=-1).ToList();
            else
                adminViewModel.Admins = null;

            adminViewModel.AdminName = GetSession("username");
            adminViewModel.Admin_permission = GetSession("permission");

            return View(adminViewModel);
        }


        public void SaveSession(string key,string value)
        {
            string session_value = HttpContext.Session.GetString(key);
            if (session_value == null)
            {
                HttpContext.Session.SetString(key, value);
                session_value = HttpContext.Session.GetString(key);
            }
        }

        public int GetSessionAndConvertToInt(string key)
        {
            string session_value = HttpContext.Session.GetString(key);
            return Convert.ToInt32(session_value);
        }


        public string GetSession(string key)
        {
            string session_value = HttpContext.Session.GetString(key);
            return session_value;
        }

        // GET: Admins/Details/5
        public async Task<IActionResult> Details(int? id)
        {
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

            AdminViewModel adminViewModel = new AdminViewModel() { 
            WorkMan=admin,
            AdminName=GetSession("username")
            };
           
            return View(adminViewModel);
        }

        // GET: Admins/Create
        public IActionResult Create()
        {
            AdminViewModel adminViewModel = new AdminViewModel()
            {
                AdminName = GetSession("username")
            };
            return View(adminViewModel);
        }

        // POST: Admins/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(AdminViewModel admin_view_model)
        {

           

            if (ModelState.IsValid)
            {
                string not_encrypted = admin_view_model.WorkMan.PassWord;
                admin_view_model.WorkMan.PassWord = PassWordHelper.Md532Salt(not_encrypted, admin_view_model.WorkMan.LoginAccount);
                admin_view_model.WorkMan.CreateTime = DateTime.Now;

                _context.Add(admin_view_model.WorkMan);
                await _context.SaveChangesAsync();              

                return RedirectToAction("Index","Admins",admin_view_model.WorkMan);
            }

            admin_view_model.AdminName = GetSession("username");
            return View(admin_view_model);
        }

        // GET: Admins/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
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
                Permission = null,
                AdminName= HttpContext.Session.GetString("username")
        };
           
            return View(admin_view_model);
        }

        // POST: Admins/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id,  AdminViewModel adminEditView)
        {
            if (id != adminEditView.WorkMan.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    string not_encrypted = adminEditView.WorkMan.PassWord;
                    adminEditView.WorkMan.PassWord = PassWordHelper.Md532Salt(not_encrypted, adminEditView.WorkMan.LoginAccount);
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
                

                return RedirectToAction("Index", "Admins", adminEditView.WorkMan);

               // return RedirectToAction(nameof(Index));
            }
            return View(adminEditView.WorkMan);
        }

        // GET: Admins/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
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
                AdminName=GetSession("username")

            };
            return View(adminViewModel);
        }

        // POST: Admins/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var admin = await _context.Admin.FindAsync(id);
            admin.Permissions = -1;
            _context.Admin.Update(admin);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AdminExists(int id)
        {
            return _context.Admin.Any(e => e.Id == id);
        }


        public ActionResult Login()
        {

            return View();
        }


        [HttpPost]
        public ActionResult Login(Admin admin_only_account_password)
        {
            bool res = CongdingTools.CheckObj(admin_only_account_password);

            if (!res) return View();



            string ori_password = admin_only_account_password.PassWord;
            string md5_password = PassWordHelper.Md532Salt(ori_password, admin_only_account_password.LoginAccount);



            if (IsAdminExists(admin_only_account_password.LoginAccount, md5_password))
            {
                var admin = _context.Admin.First(a => a.LoginAccount == admin_only_account_password.LoginAccount);
              
                return RedirectToAction("Index", admin);
            }
                

            return View();


        }

        public IActionResult Logout()
        {
            return View(nameof(Login));
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
     

        


    }
}

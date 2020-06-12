using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FitNightSnackMgr.Data;
using FitNightSnackMgr.Models;
using Microsoft.AspNetCore.Http;
using FitNightSnackMgr.ViewModels.UserViewModels;
using FitNightSnackMgr.ViewModels;

namespace FitNightSnackMgr.Controllers
{
    public enum USER_ACCOUNT_STATUS { PROHIBIT=0,RELIEVE=1}
    public class UsersController : Controller
    {
        private readonly FitNightSnackMgrContext _context;

        public UsersController(FitNightSnackMgrContext context)
        {
            _context = context;
        }

        // GET: SnackInfoes
        public async Task<IActionResult> IndexAsync(int? pageNumber, string searchString)
        {
            int total = _context.User.Count();
            int pagecount = total / 10 + 1;
            if (pagecount > 10) pagecount = 10;
            PaginatedList<User> snackInfos = null;
            if (searchString != null)
                snackInfos = await PaginatedList<User>.CreateAsync(_context.User.Where(u => u.UserName.Contains(searchString)).OrderBy(u => u.Id), pageNumber ?? 1, 10);
            else
                snackInfos = await PaginatedList<User>.CreateAsync(_context.User.OrderBy(u => u.Id), pageNumber ?? 1, 10);


            UserViewModels userViewModels = new UserViewModels()
            {
                Users = snackInfos,
                AdminName = GetSession("username"),
                PageIndex = pageNumber ?? 1,
                PageTotal = pagecount
            };

            // int pageSize = 3;
            return View(userViewModels);
            // return View(snackInfoViewModels);
        }
        public string GetSession(string key)
        {
            string session_value = HttpContext.Session.GetString(key);
            return session_value;
        }

        // GET: Users/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.User
                .FirstOrDefaultAsync(m => m.Id == id);
            if (user == null)
            {
                return NotFound();
            }

            UserViewModels userViewModels = new UserViewModels()
            {
                User = user,
                AdminName = GetSession("username")
            };

            return View(userViewModels);
        }

        // GET: Users/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Users/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,UserAccount,Password,Money,Phone,Address")] User user)
        {
            if (ModelState.IsValid)
            {
                user.PaySecret = "123456";
                _context.Add(user);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(user);
        }

        // GET: Users/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.User.FindAsync(id);
            if (user == null)
            {
                return NotFound();
            }
            return View(user);
        }

        // POST: Users/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,UserAccount,Password,Money,Phone,Address")] User user)
        {
            if (id != user.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(user);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserExists(user.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(user);
        }

        // GET: Users/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.User
                .FirstOrDefaultAsync(m => m.Id == id);
            if (user == null)
            {
                return NotFound();
            }


            UserViewModels userViewModels = new UserViewModels()
            {
                AdminName = GetSession("username"),
                User = user
            };

            return View(userViewModels);
        }

        // POST: Users/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var user = await _context.User.FindAsync(id);

            if (user.Status == (int)USER_ACCOUNT_STATUS.PROHIBIT)
                user.Status = (int)USER_ACCOUNT_STATUS.RELIEVE;
            else
                user.Status = (int)USER_ACCOUNT_STATUS.PROHIBIT;


            //_context.User.Remove(user);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UserExists(int id)
        {
            return _context.User.Any(e => e.Id == id);
        }



       
    }
}

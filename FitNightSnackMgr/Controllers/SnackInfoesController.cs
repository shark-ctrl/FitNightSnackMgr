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
using FitNightSnackMgr.ViewModels.SnackInfoViewModels;
using Microsoft.AspNetCore.Http;
using FitNightSnackMgr.Tools;
using System.IO;

namespace FitNightSnackMgr.Controllers
{
    public class SnackInfoesController : Controller
    {
        private readonly FitNightSnackMgrContext _context;
        public string _dir = @"F:\FitNightSnackMgr\FitNightSnackMgr\wwwroot\images\";
        public string relative_path = "/images/";

        public SnackInfoesController(FitNightSnackMgrContext context)
        {
            _context = context;
        }

        // GET: SnackInfoes
        public async Task<IActionResult> IndexAsync(int? pageNumber, string searchString)
        {
            int total=_context.SnackInfo.Count();
            int pagecount = total / 10+1;
            if (pagecount > 10) pagecount = 10;
            PaginatedList<SnackInfo> snackInfos = null;
            if (searchString != null)
                snackInfos = await PaginatedList<SnackInfo>.CreateAsync(_context.SnackInfo.Where(s => s.Name.Contains(searchString)).OrderBy(s => s.Price), pageNumber ?? 1, 10);
            else
                snackInfos = await PaginatedList<SnackInfo>.CreateAsync(_context.SnackInfo.OrderBy(s => s.Price), pageNumber ?? 1, 10);


            SnackInfoViewModels snackInfoViewModels = new SnackInfoViewModels()
            {
                SnackInfos =snackInfos,
                AdminName = GetSession("username"),
                PageIndex = pageNumber ?? 1,
                PageTotal = pagecount
            };

           // int pageSize = 3;
            return View(snackInfoViewModels);
            // return View(snackInfoViewModels);
        }

        public string GetSession(string key)
        {
            string session_value = HttpContext.Session.GetString(key);
            return session_value;
        }


        // GET: SnackInfoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var snackInfo = await _context.SnackInfo
                .FirstOrDefaultAsync(m => m.Id == id);
            if (snackInfo == null)
            {
                return NotFound();
            }

            return View(snackInfo);
        }

        // GET: SnackInfoes/Create
        public IActionResult Create()
        {
            // Use LINQ to get list of category.
            IQueryable<string> categoryQuery = from m in _context.SnackCategory
                                            orderby m.CategoryNum
                                            select m.CategoryName;
            int SnackNum = _context.SnackInfo.Max(s => s.SnackNum)+1;
            

            SnackInfoViewModels snackInfoViewModels = new SnackInfoViewModels()
            {
                AdminName=GetSession("username"),
                CategoriesName = new SelectList( categoryQuery.ToList()),
                SnackNum=SnackNum,
                CheckPicture=true
            };
            return View(snackInfoViewModels);
        }

        // POST: SnackInfoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(SnackInfoViewModels snackInfoViewModels)
        {
            int num = snackInfoViewModels.SnackInfo.SnackNum;
            
            if (!IsPicture(snackInfoViewModels.FormFile.FileName))
            {
                snackInfoViewModels.SnackNum = num;
                snackInfoViewModels.AdminName = GetSession("username");
                snackInfoViewModels.CheckPicture = false;
                snackInfoViewModels.CategoriesName = GetCategories();
                return View(snackInfoViewModels);
            }

            if (ModelState.IsValid)
            {
                string file_name= $"{snackInfoViewModels.SnackInfo.SnackNum}_{DateTime.Now.ToString("yyyymmddHHmmss")}.jpg";
                using (var fileStream = new FileStream(Path.Combine(_dir,file_name ), FileMode.Create, FileAccess.Write))
                {
                   snackInfoViewModels.FormFile.CopyTo(fileStream);
                }
                snackInfoViewModels.SnackInfo.ImgUrl =relative_path + file_name;
                long category_id = _context.SnackCategory.FirstOrDefault(c => c.CategoryName == snackInfoViewModels.CategoryName).CategoryNum;
                snackInfoViewModels.SnackInfo.CategoryId = category_id;
                _context.Add(snackInfoViewModels.SnackInfo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
          
            return View(snackInfoViewModels);
        }


        public bool IsPicture(string file_name)
        {
            int last_dot_index = file_name.LastIndexOf(".");
            string file_type = file_name.Substring(last_dot_index);
            if (file_type == ".jpg" || file_type == ".png")
                return true;
            return false;
        }

        public SelectList GetCategories()
        {
            IQueryable<string> categoryQuery = from m in _context.SnackCategory
                                               orderby m.CategoryNum
                                               select m.CategoryName;
            SelectList CateGoriesList = new SelectList(categoryQuery.ToList());
            return CateGoriesList;
        }

        // GET: SnackInfoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var snackInfo = await _context.SnackInfo.FindAsync(id);
            if (snackInfo == null)
            {
                return NotFound();
            }
            return View(snackInfo);
        }

        // POST: SnackInfoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,SnackNum,CategoryId,Name,Price,ImgUrl,DetailInfo")] SnackInfo snackInfo)
        {
            if (id != snackInfo.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(snackInfo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SnackInfoExists(snackInfo.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(IndexAsync));
            }
            return View(snackInfo);
        }

        // GET: SnackInfoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var snackInfo = await _context.SnackInfo
                .FirstOrDefaultAsync(m => m.Id == id);
            if (snackInfo == null)
            {
                return NotFound();
            }

            return View(snackInfo);
        }

        // POST: SnackInfoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var snackInfo = await _context.SnackInfo.FindAsync(id);
            _context.SnackInfo.Remove(snackInfo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(IndexAsync));
        }

        private bool SnackInfoExists(int id)
        {
            return _context.SnackInfo.Any(e => e.Id == id);
        }
    }
}

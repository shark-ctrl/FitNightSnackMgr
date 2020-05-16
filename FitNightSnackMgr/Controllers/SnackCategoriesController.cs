using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FitNightSnackMgr.Data;
using FitNightSnackMgr.Models;

namespace FitNightSnackMgr.Controllers
{
    public class SnackCategoriesController : Controller
    {
        private readonly FitNightSnackMgrContext _context;

        public SnackCategoriesController(FitNightSnackMgrContext context)
        {
            _context = context;
        }

        // GET: SnackCategories
        public async Task<IActionResult> Index()
        {
            return View(await _context.SnackCategory.ToListAsync());
        }

        // GET: SnackCategories/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var snackCategory = await _context.SnackCategory
                .FirstOrDefaultAsync(m => m.Id == id);
            if (snackCategory == null)
            {
                return NotFound();
            }

            return View(snackCategory);
        }

        // GET: SnackCategories/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: SnackCategories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,CategoryNum,CategoryName")] SnackCategory snackCategory)
        {
            if (ModelState.IsValid)
            {
                _context.Add(snackCategory);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(snackCategory);
        }

        // GET: SnackCategories/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var snackCategory = await _context.SnackCategory.FindAsync(id);
            if (snackCategory == null)
            {
                return NotFound();
            }
            return View(snackCategory);
        }

        // POST: SnackCategories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,CategoryNum,CategoryName")] SnackCategory snackCategory)
        {
            if (id != snackCategory.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(snackCategory);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SnackCategoryExists(snackCategory.Id))
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
            return View(snackCategory);
        }

        // GET: SnackCategories/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var snackCategory = await _context.SnackCategory
                .FirstOrDefaultAsync(m => m.Id == id);
            if (snackCategory == null)
            {
                return NotFound();
            }

            return View(snackCategory);
        }

        // POST: SnackCategories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var snackCategory = await _context.SnackCategory.FindAsync(id);
            _context.SnackCategory.Remove(snackCategory);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SnackCategoryExists(int id)
        {
            return _context.SnackCategory.Any(e => e.Id == id);
        }
    }
}

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
    public class SnackInfoesController : Controller
    {
        private readonly FitNightSnackMgrContext _context;

        public SnackInfoesController(FitNightSnackMgrContext context)
        {
            _context = context;
        }

        // GET: SnackInfoes
        public async Task<IActionResult> Index()
        {
            return View(await _context.SnackInfo.ToListAsync());
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
            return View();
        }

        // POST: SnackInfoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,SnackNum,CategoryId,Name,Price,ImgUrl,DetailInfo")] SnackInfo snackInfo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(snackInfo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(snackInfo);
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
                return RedirectToAction(nameof(Index));
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
            return RedirectToAction(nameof(Index));
        }

        private bool SnackInfoExists(int id)
        {
            return _context.SnackInfo.Any(e => e.Id == id);
        }
    }
}

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
using FitNightSnackMgr.ViewModels.CardViewModel;

namespace FitNightSnackMgr.Controllers
{
    public class prepaidCardsController : Controller
    {
        private readonly FitNightSnackMgrContext _context;

        public prepaidCardsController(FitNightSnackMgrContext context)
        {
            _context = context;
        }

        // GET: prepaidCards
        public async Task<IActionResult> Index(int? pageNumber, string searchString)
        {

            int total = _context.prepaidCard.Count();
            int pagecount = total / 10 + 1;
            if (pagecount > 10) pagecount = 10;
            PaginatedList<prepaidCard> cards = null;
            if (searchString != null)
                cards = await PaginatedList<prepaidCard>.CreateAsync(_context.prepaidCard.Where(c=>c.CardCode==searchString), pageNumber ?? 1, 10);
            else
                cards = await PaginatedList<prepaidCard>.CreateAsync(_context.prepaidCard, pageNumber ?? 1, 10);


            CardIndexViewModel ViewModels = new CardIndexViewModel()
            {
               Cards=cards,
               PageIndex=pageNumber??1,
               PageTotal=pagecount
            };

            // int pageSize = 3;
            return View(ViewModels);
            // return View(snackInfoViewModels);
        }

        // GET: prepaidCards/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var prepaidCard = await _context.prepaidCard
                .FirstOrDefaultAsync(m => m.Id == id);
            if (prepaidCard == null)
            {
                return NotFound();
            }

            return View(prepaidCard);
        }

        // GET: prepaidCards/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: prepaidCards/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,CardCode,SecretKey,UserAccount,CardStatus,Price")] prepaidCard prepaidCard)
        {
            if (ModelState.IsValid)
            {
                _context.Add(prepaidCard);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(prepaidCard);
        }

        // GET: prepaidCards/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var prepaidCard = await _context.prepaidCard.FindAsync(id);
            if (prepaidCard == null)
            {
                return NotFound();
            }
            return View(prepaidCard);
        }

        // POST: prepaidCards/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,CardCode,SecretKey,UserAccount,CardStatus,Price")] prepaidCard prepaidCard)
        {
            if (id != prepaidCard.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(prepaidCard);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!prepaidCardExists(prepaidCard.Id))
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
            return View(prepaidCard);
        }

        // GET: prepaidCards/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var prepaidCard = await _context.prepaidCard
                .FirstOrDefaultAsync(m => m.Id == id);
            if (prepaidCard == null)
            {
                return NotFound();
            }

            return View(prepaidCard);
        }

        // POST: prepaidCards/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var prepaidCard = await _context.prepaidCard.FindAsync(id);
            _context.prepaidCard.Remove(prepaidCard);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool prepaidCardExists(int id)
        {
            return _context.prepaidCard.Any(e => e.Id == id);
        }
    }
}

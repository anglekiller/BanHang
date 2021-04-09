using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BanHang.Data;
using BanHang.Models;

namespace BanHang.Controllers
{
    public class BilldetailsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public BilldetailsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Billdetails
        public async Task<IActionResult> Index()
        {
            return View(await _context.Billdetail.ToListAsync());
        }

        // GET: Billdetails/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var billdetail = await _context.Billdetail
                .FirstOrDefaultAsync(m => m.Id == id);
            if (billdetail == null)
            {
                return NotFound();
            }

            return View(billdetail);
        }

        // GET: Billdetails/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Billdetails/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Amount,Price,Id")] Billdetail billdetail)
        {
            if (ModelState.IsValid)
            {
                _context.Add(billdetail);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(billdetail);
        }

        // GET: Billdetails/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var billdetail = await _context.Billdetail.FindAsync(id);
            if (billdetail == null)
            {
                return NotFound();
            }
            return View(billdetail);
        }

        // POST: Billdetails/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id, [Bind("Amount,Price,Id")] Billdetail billdetail)
        {
            if (id != billdetail.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(billdetail);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BilldetailExists(billdetail.Id))
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
            return View(billdetail);
        }

        // GET: Billdetails/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var billdetail = await _context.Billdetail
                .FirstOrDefaultAsync(m => m.Id == id);
            if (billdetail == null)
            {
                return NotFound();
            }

            return View(billdetail);
        }

        // POST: Billdetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int? id)
        {
            var billdetail = await _context.Billdetail.FindAsync(id);
            _context.Billdetail.Remove(billdetail);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BilldetailExists(int? id)
        {
            return _context.Billdetail.Any(e => e.Id == id);
        }
    }
}

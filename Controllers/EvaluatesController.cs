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
    public class EvaluatesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EvaluatesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Evaluates
        public async Task<IActionResult> Index()
        {
            return View(await _context.Evaluate.ToListAsync());
        }

        // GET: Evaluates/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var evaluate = await _context.Evaluate
                .FirstOrDefaultAsync(m => m.Id == id);
            if (evaluate == null)
            {
                return NotFound();
            }

            return View(evaluate);
        }

        // GET: Evaluates/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Evaluates/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdProduct,IdUser,Star,CreateDate,Comment,Id")] Evaluate evaluate)
        {
            if (ModelState.IsValid)
            {
                _context.Add(evaluate);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(evaluate);
        }

        // GET: Evaluates/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var evaluate = await _context.Evaluate.FindAsync(id);
            if (evaluate == null)
            {
                return NotFound();
            }
            return View(evaluate);
        }

        // POST: Evaluates/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id, [Bind("IdProduct,IdUser,Star,CreateDate,Comment,Id")] Evaluate evaluate)
        {
            if (id != evaluate.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(evaluate);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EvaluateExists(evaluate.Id))
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
            return View(evaluate);
        }

        // GET: Evaluates/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var evaluate = await _context.Evaluate
                .FirstOrDefaultAsync(m => m.Id == id);
            if (evaluate == null)
            {
                return NotFound();
            }

            return View(evaluate);
        }

        // POST: Evaluates/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int? id)
        {
            var evaluate = await _context.Evaluate.FindAsync(id);
            _context.Evaluate.Remove(evaluate);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EvaluateExists(int? id)
        {
            return _context.Evaluate.Any(e => e.Id == id);
        }
    }
}

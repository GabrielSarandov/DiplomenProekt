using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ElectronicEquipmentService.Data;

namespace ElectronicEquipmentService.Controllers
{
    public class ExecutesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ExecutesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Executes
        public async Task<IActionResult> Index()
        {
            return View(await _context.Execute.ToListAsync());
        }

        // GET: Executes/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var execute = await _context.Execute
                .FirstOrDefaultAsync(m => m.Id == id);
            if (execute == null)
            {
                return NotFound();
            }

            return View(execute);
        }

        // GET: Executes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Executes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,OrderId,EmployeeId,Discription,Warrantly,StatusOfOrder,Price")] Execute execute)
        {
            if (ModelState.IsValid)
            {
                _context.Add(execute);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(execute);
        }

        // GET: Executes/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var execute = await _context.Execute.FindAsync(id);
            if (execute == null)
            {
                return NotFound();
            }
            return View(execute);
        }

        // POST: Executes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Id,OrderId,EmployeeId,Discription,Warrantly,StatusOfOrder,Price")] Execute execute)
        {
            if (id != execute.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(execute);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ExecuteExists(execute.Id))
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
            return View(execute);
        }

        // GET: Executes/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var execute = await _context.Execute
                .FirstOrDefaultAsync(m => m.Id == id);
            if (execute == null)
            {
                return NotFound();
            }

            return View(execute);
        }

        // POST: Executes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var execute = await _context.Execute.FindAsync(id);
            _context.Execute.Remove(execute);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ExecuteExists(string id)
        {
            return _context.Execute.Any(e => e.Id == id);
        }
    }
}

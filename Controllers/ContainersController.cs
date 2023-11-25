using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Курсач.Data;
using Курсач.Models;

namespace Курсач.Controllers
{
    public class ContainersController : Controller
    {
        private readonly HumContext _context;

        public ContainersController(HumContext context)
        {
            _context = context;
        }

        // GET: Containers
        public async Task<IActionResult> Index()
        {
            return View(await _context.Container.ToListAsync());
        }

        // GET: Containers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var containers = await _context.Container
                .FirstOrDefaultAsync(m => m.ID == id);
            if (containers == null)
            {
                return NotFound();
            }

            return View(containers);
        }

        // GET: Containers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Containers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,container,PersonId,DataStart,DataEnd,currentProgres,endProgres")] Containers containers)
        {
            if (ModelState.IsValid)
            {
                _context.Add(containers);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(containers);
        }

        // GET: Containers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var containers = await _context.Container.FindAsync(id);
            if (containers == null)
            {
                return NotFound();
            }
            return View(containers);
        }

        // POST: Containers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,container,PersonId,DataStart,DataEnd,currentProgres,endProgres")] Containers containers)
        {
            if (id != containers.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(containers);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ContainersExists(containers.ID))
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
            return View(containers);
        }

        // GET: Containers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var containers = await _context.Container
                .FirstOrDefaultAsync(m => m.ID == id);
            if (containers == null)
            {
                return NotFound();
            }

            return View(containers);
        }

        // POST: Containers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var containers = await _context.Container.FindAsync(id);
            _context.Container.Remove(containers);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ContainersExists(int id)
        {
            return _context.Container.Any(e => e.ID == id);
        }
    }
}

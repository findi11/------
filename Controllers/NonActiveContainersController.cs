using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Курсач.Data;
using Курсач.Models;

namespace Курсач.Controllers
{
    public class NonActiveContainersController : Controller
    {
        private readonly HumContext _context;

        public NonActiveContainersController(HumContext context)
        {
            _context = context;
        }

        // GET: NonActiveContainers
        public async Task<IActionResult> Index()
        {
            return View(await _context.NonActiveContainers.ToListAsync());
        }

        // GET: NonActiveContainers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nonActiveContainers = await _context.NonActiveContainers
                .FirstOrDefaultAsync(m => m.ID == id);
            if (nonActiveContainers == null)
            {
                return NotFound();
            }

            return View(nonActiveContainers);
        }

        // GET: NonActiveContainers/Create
        // GET: NonActiveContainers/Create
        public IActionResult Create()
        {
            var isAuthenticatedCookie = HttpContext.Request.Cookies["IsAuthenticated"];

            if (User.Identity.IsAuthenticated || (isAuthenticatedCookie != null && isAuthenticatedCookie.ToLower() == "true"))
            {
                // Логіка для аутентифікованого користувача
                var categories = _context.Categories.ToList();

                // Передати список категорій у представлення
                ViewBag.Categories = new SelectList(categories, "ID", "Title");

                return View();
            }
            else
            {
                // Логіка для неаутентифікованого користувача
                return RedirectToAction("Login", "Users");
            }
        }


        // POST: NonActiveContainers/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,PersonId,DataStart,DataEnd,currentProgres,endProgres,CategoryID,DataAdd")] NonActiveContainers nonActiveContainers)
        {
            if (ModelState.IsValid)
            {
                nonActiveContainers.DataAdd = DateTime.Now;
                _context.Add(nonActiveContainers);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            var categories = _context.Categories.ToList();
            ViewBag.Categories = new SelectList(categories, "ID", "Title");
            return RedirectToAction("Index", "Home");

        }

        // GET: NonActiveContainers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nonActiveContainers = await _context.NonActiveContainers.FindAsync(id);
            if (nonActiveContainers == null)
            {
                return NotFound();
            }
            return View(nonActiveContainers);
        }

        // POST: NonActiveContainers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,container,PersonId,DataStart,DataEnd,currentProgres,endProgres,DataAdd")] NonActiveContainers nonActiveContainers)
        {
            if (id != nonActiveContainers.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(nonActiveContainers);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NonActiveContainersExists(nonActiveContainers.ID))
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
            return View(nonActiveContainers);
        }

        // GET: NonActiveContainers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nonActiveContainers = await _context.NonActiveContainers
                .FirstOrDefaultAsync(m => m.ID == id);
            if (nonActiveContainers == null)
            {
                return NotFound();
            }

            return View(nonActiveContainers);
        }

        // POST: NonActiveContainers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var nonActiveContainers = await _context.NonActiveContainers.FindAsync(id);
            _context.NonActiveContainers.Remove(nonActiveContainers);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NonActiveContainersExists(int id)
        {
            return _context.NonActiveContainers.Any(e => e.ID == id);
        }
    }
}

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
    public class UsersController : Controller
    {
        private readonly HumContext _context;

        public UsersController(HumContext context)
        {
            _context = context;
        }

        // GET: Userss
        public async Task<IActionResult> Index()
        {
            return View(await _context.Users.ToListAsync());
        }

        // GET: Userss/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Users = await _context.Users
                .FirstOrDefaultAsync(m => m.ID == id);
            if (Users == null)
            {
                return NotFound();
            }

            return View(Users);
        }

        // GET: Userss/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Userss/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,name,surname,email,age,password")] User Users)
        {
            if (ModelState.IsValid)
            {
                Users.role = 0;

                _context.Add(Users);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return RedirectToAction("Index", "Home");
        }

        // GET: Userss/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Users = await _context.Users.FindAsync(id);
            if (Users == null)
            {
                return NotFound();
            }
            return View(Users);
        }

        // POST: Userss/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,name,surname,email,age,role,password")] User Users)
        {
            if (id != Users.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(Users);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UsersExists(Users.ID))
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
            return View(Users);
        }

        // GET: Userss/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Users = await _context.Users
                .FirstOrDefaultAsync(m => m.ID == id);
            if (Users == null)
            {
                return NotFound();
            }

            return View(Users);
        }

        // POST: Userss/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var Users = await _context.Users.FindAsync(id);
            _context.Users.Remove(Users);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UsersExists(int id)
        {
            return _context.Users.Any(e => e.ID == id);
        }

        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(string email, string password)
        {
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                // Перевірка, чи введено email та пароль
                return BadRequest("Email and password are required.");
            }

            // Перевірка, чи існує користувач з введеним email у базі даних
            var user = await _context.Users.FirstOrDefaultAsync(u => string.Equals(u.email, email));
            if (user == null || !string.Equals(user.password, password))
            {
                // Неправильний email або пароль




                return Unauthorized("Invalid email or password.");
            }

            if (!User.Identity.IsAuthenticated)
            {
                // Успішна аутентифікація - записуємо email у куки та встановлюємо прапорець у true
                Response.Cookies.Append("UserEmail", email);
                Response.Cookies.Append("IsAuthenticated", "true");
                if (user.role == 1)
                {
                    // Якщо роль = 1, то записуємо IsAdmin = true у локальне сховище (local storage)
                    Response.Cookies.Append("IsAdmin", "true");
                }
            }

            return RedirectToAction("Index", "Home");
        }



        // GET: /Auth/Logout
        public IActionResult Logout()
        {
            // Видалення кукі при виході
            Response.Cookies.Delete("UserEmail");
            Response.Cookies.Delete("IsAuthenticated");
            Response.Cookies.Delete("IsAdmin");

            return RedirectToAction("Index", "Home");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EducationProject.Data;
using EducationProject.Models;

namespace EducationProject.Views.Admin.Credits
{
   [Authorize]
    public class UserCreditsController : Controller
    {
        private readonly ApplicationDbContext _context;

        private readonly UserManager<IdentityUser> _userManager;

        public UserCreditsController(ApplicationDbContext context, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        [Authorize(Roles = "Admin")]
        // GET: UserCredits
        public async Task<IActionResult> Index()
        {
            return View(await _context.UserCredit.ToListAsync());
        }
        [Authorize(Roles = "Admin")]
        // GET: UserCredits/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userCredit = await _context.UserCredit
                .FirstOrDefaultAsync(m => m.Id == id);
            if (userCredit == null)
            {
                return NotFound();
            }

            return View(userCredit);
        }
        [Authorize]
        // GET: UserCredits/Create
        public IActionResult Create()
        {
            return View();
        }

      
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]

        public async Task<IActionResult> Create([Bind("Id,UserId,Credit,Date,Action")] UserCredit userCredit, int Credit)
        {
            if (ModelState.IsValid)
            {
                var userN = _userManager.GetUserId(HttpContext.User);
                Guid userGuid = Guid.Parse(userN);
                string abc = _userManager.GetUserId(User);
                string name = _userManager.GetUserName(User);
                userCredit.UserId = userGuid;
                userCredit.Credit = Credit;
                userCredit.Date = DateTime.Now;
                string info = name+" "+Credit.ToString()+ " Kredi Yükleme Yaptı.";
                userCredit.Action = info;
                _context.Add(userCredit);
                await _context.SaveChangesAsync();
                return RedirectToAction("Courses","Home");
            }
            return View(userCredit);
        }

        [Authorize(Roles = "Admin")]
        // GET: UserCredits/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userCredit = await _context.UserCredit.FindAsync(id);
            if (userCredit == null)
            {
                return NotFound();
            }
            return View(userCredit);
        }

        // POST: UserCredits/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Edit(int id, [Bind("Id,UserId,Credit,Action")] UserCredit userCredit)
        {
            if (id != userCredit.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(userCredit);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserCreditExists(userCredit.Id))
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
            return View(userCredit);
        }

        // GET: UserCredits/Delete/5
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userCredit = await _context.UserCredit
                .FirstOrDefaultAsync(m => m.Id == id);
            if (userCredit == null)
            {
                return NotFound();
            }

            return View(userCredit);
        }
   // POST: UserCredits/Delete/5
        [Authorize(Roles = "Admin")]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var userCredit = await _context.UserCredit.FindAsync(id);
            _context.UserCredit.Remove(userCredit);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        [AllowAnonymous]
        private bool UserCreditExists(int id)
        {
            return _context.UserCredit.Any(e => e.Id == id);
        }
    }
}

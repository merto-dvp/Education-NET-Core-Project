using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EducationProject.Data;
using EducationProject.Models;
using Microsoft.IdentityModel;
using System.Security.Claims;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;

namespace EducationProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;



        public HomeController(ApplicationDbContext context, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _userManager = userManager;

        }

        public IActionResult Index(int id)
        {
            var abc = id;
            return View();
            
        }

        public IActionResult Courses()
        {
            UsersAndCourses model = new UsersAndCourses();
            
            model.Kurslar = _context.Course.ToList();

            foreach (var course in model.Kurslar)
            {           
                course.IsDele = course.IsDeleted;
            }
            if (_userManager.GetUserId(HttpContext.User) != null)
            {
                var userN = _userManager.GetUserId(HttpContext.User);
                Guid userGuid = Guid.Parse(userN);
                string abc = _userManager.GetUserId(User);
                


                var purchaseIdList = _context.UserCourse.Where(q => q.UserId == userGuid).Select(q => q.CourseId).ToList();

                var deleteControl = _context.Course.Where(q => q.IsDeleted).ToList();
              
                foreach (var course in model.Kurslar)
                {

                    course.IsPurchased = purchaseIdList.Contains(course.Id);
                    //course.IsPurchased = course.IsDeleted;
                    course.IsDele = course.IsDeleted;
                }
                if (User.IsInRole("Admin"))
                {
                    return View("~/Views/Home/CoursesAdmin.cshtml", model);
                }
                else
                {
                    return View("~/Views/Home/CoursesUser.cshtml", model);
                }
            }
            else
            {
                return View("~/Views/Home/CoursesUser.cshtml", model);
            }

        }

        public async Task<IActionResult> Search(string search)
        {
            var courseS = from sel in _context.Course
                          select sel;
            if (!String.IsNullOrEmpty(search))
            {
                courseS = courseS.Where(s => s.Name.Contains(search.ToUpper())
                          || s.Description.Contains(search.ToUpper())
                          || s.Trainer.Contains(search.ToUpper())
                );



            }
            return View("~/Views/Home/CoursesVisitor.cshtml", await courseS.ToListAsync());
        }
        [Authorize(Roles = "Admin")]
        public IActionResult Welcome()
        {
            return View(_context.Course.ToList());
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult Items()
        {
            return View();
        }
        public async Task<IActionResult> Download(string id)
        {
            UploadedFile download= await _context.UploadedFile.FirstOrDefaultAsync(m => m.id == id);
            return View();
        }



    }
}

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

namespace EducationProject.Views.Courses
{
    public class CoursesController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;
        private List<Course> Course;
        


        public CoursesController(ApplicationDbContext context, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

      


        // GET: Courses/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            
            var course = await _context.Course.FirstOrDefaultAsync(m => m.Id == id);
            if (_userManager.GetUserId(HttpContext.User) != null)
            {
                var userN = _userManager.GetUserId(HttpContext.User);
                Guid userGuid = Guid.Parse(userN);
                string abc = _userManager.GetUserId(User);
                var purchaseIdList = _context.UserCourse.Where(q => q.UserId == userGuid).Select(q => q.CourseId).ToList();
                foreach (var item in purchaseIdList)
                {
                    course.IsPurchased = purchaseIdList.Contains(course.Id);
                }
            }
            else
            {

            }

                if (id == null)
            {
                return NotFound();
            }

            
            
                
            var ab = course.IsPurchased;
            
           
            
            if (course == null)
            {
                return NotFound();
            }

            return View(course);
        }
        [Authorize(Roles ="Admin")]
        // GET: Courses/Lists
        public async Task<IActionResult> Lists()
        {
            return View(await _context.Course.ToListAsync());
        }
        // GET: Courses/Create
        
       
   


        public async Task OnGetAsync(string searchString)
        {
            var crs = from m in _context.Course
                         select m;

            if (!String.IsNullOrEmpty(searchString))
            {
                crs =crs.Where(s => s.Name.Contains(searchString));
            }

         Course = await crs.ToListAsync();
        }

        // GET: Courses/Edit/5
       
     

        private bool CourseExists(int id)
        {
            return _context.Course.Any(e => e.Id == id);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EducationProject.Data;
using EducationProject.Models;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;

namespace EducationProject.Controllers
{
    public class UserCoursesController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;
        
        public UserCoursesController(ApplicationDbContext context, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _userManager = userManager;
            
        }

        // GET: UserCourses
        public async Task<IActionResult> Index()
        {
            return View(await _context.UserCourse.ToListAsync());
        }

        // GET: UserCourses/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userCourse = await _context.UserCourse
                .FirstOrDefaultAsync(m => m.Id == id);
            if (userCourse == null)
            {
                return NotFound();
            }

            return View(userCourse);
        }
        //[Authorize(Roles ="Admin")]
        public IActionResult Buy(int courseId)
        {
            

            Course course = _context.Course.FirstOrDefault(q => q.Id == courseId);
          
            UsersAndCourses model = new UsersAndCourses();
            
            if (_userManager.GetUserId(HttpContext.User) != null)
            {
                var userN = _userManager.GetUserId(HttpContext.User);
                Guid userGuid = Guid.Parse(userN);
                string abc = _userManager.GetUserId(User);
                
                model.Kurslar = _context.Course.ToList();
                model.Kullanicilar = _context.UserCourse.ToList();
                
                var purchaseIdList = _context.UserCourse.Where(q => q.UserId == userGuid).Select(q => q.CourseId).ToList();

                var credit = _context.UserCredit.Where(q => q.UserId == userGuid).Sum(p => p.Credit);
                

                //var userCreditList = _context.UserCourse.Where(c => c.UserId == userGuid).Select(c => c.Credit).ToList();
                foreach (var crs in model.Kurslar)
                {
                    course.IsPurchased = purchaseIdList.Contains(course.Id);
                  
                }
               
                CourseBuyModel courseBuyModel = new CourseBuyModel();
                
                courseBuyModel.CourseDetail = course;
                courseBuyModel.CourseId = course.Id;
                courseBuyModel.UserId = _userManager.GetUserId(HttpContext.User);
                courseBuyModel.Credit = credit;


                //courseBuyModel.UserCourseDetail.Credit

                
                return View(courseBuyModel);
            }
            else
            {
                return RedirectToAction("Login","Account");
            }
                
        }
        //[Authorize(Roles = "Default,Admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> BuyCourse([Bind("UserId,CourseId")] UserCourse userCourse, Course Abc,[Bind("UserId","Credit")]UserCredit userC,int Kredi)
        {
            if (ModelState.IsValid)
            {
                var userN = _userManager.GetUserId(HttpContext.User);
                Guid userGuid = Guid.Parse(userN);
                string abc = _userManager.GetUserName(User);
                UserCredit userCredit = new UserCredit();
                var Price= _context.Course.Where(q => q.Id == userCourse.CourseId).Sum(p => p.Price);
                var Course = _context.Course.Where(q => q.Id == userCourse.CourseId).FirstOrDefault();
                
                userCredit.UserId = userGuid;

                userCredit.Credit = -Price;
                
                userCredit.Action = abc + " Satın Aldı: " + Course.Name;
                userCredit.Date= DateTime.Now;
                _context.Add(userCredit);
                _context.Add(userCourse);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(PurchaseCompleted));
            }
            return View(userCourse);
        }
        //[Authorize(Roles = "User,Admin")]
        public IActionResult PurchaseCompleted()
        {
            return View();
        }
       // [Authorize(Roles = "User,Admin")]
        public IActionResult MyCourses()
        {
            UsersAndCourses model = new UsersAndCourses();

            if (_userManager.GetUserId(HttpContext.User) != null)
            {
                var userN = _userManager.GetUserId(HttpContext.User);
                Guid userGuid = Guid.Parse(userN);
                string abc = _userManager.GetUserId(User);

                model.Kurslar = _context.Course.ToList();

                var purchaseIdList = _context.UserCourse.Where(q => q.UserId == userGuid).Select(q => q.CourseId).ToList();

                foreach (var course in model.Kurslar)
                {
                    course.IsPurchased = purchaseIdList.Contains(course.Id);
                }
                return View(model);
            }
            else
                return RedirectToAction("Login", "Account");
        }

        public async Task<IActionResult> ShowCourse(int? id)
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
          
           
                return View(course);
            
                



        }

        

       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> NegativeCredit([Bind("Id,UserId,Credit,Action")] UserCredit userCredit, int Credit)
        {
            if (ModelState.IsValid)
            {
                var userN = _userManager.GetUserId(HttpContext.User);
                Guid userGuid = Guid.Parse(userN);
                string abc = _userManager.GetUserId(User);
                userCredit.UserId = userGuid;
                userCredit.Credit = -Credit;
                _context.Add(userCredit);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(userCredit);
        }

        private bool UserCourseExists(int id)
        {
            return _context.UserCourse.Any(e => e.Id == id);
        }
    }
}

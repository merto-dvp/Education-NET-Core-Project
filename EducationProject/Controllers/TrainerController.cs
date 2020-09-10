using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EducationProject.Data;
using EducationProject.Models;

namespace EducationProject.Controllers
{
    [Authorize(Roles = "Trainer")]
    public class TrainerController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;
        //private readonly SignInManager<IdentityUser> _signInManager;


        public TrainerController(ApplicationDbContext context, UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {

            _context = context;
            _userManager = userManager;

        }
        public IActionResult Index()
        {
            UsersAndCourses model = new UsersAndCourses();
            string trainer = _userManager.GetUserName(User);
            model.Kurslar = _context.Course.Where(q => q.Trainer == trainer).ToList();
            
            foreach (var course in model.Kurslar)
            {
                course.IsDele = course.IsDeleted;
            }

            if (_userManager.GetUserId(HttpContext.User) != null)
            {
                var userN = _userManager.GetUserId(HttpContext.User);
                Guid userGuid = Guid.Parse(userN);
                string abc = _userManager.GetUserId(User);


               if (User.IsInRole("Trainer"))
            {
                
               
                return View("~/Views/Trainer/Index.cshtml", model);
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
        public async Task<IActionResult> CourseEdit(int? id)
        {

          
            if (id == null)
            {
                return NotFound();
            }

            var course = await _context.Course.FindAsync(id);
            string userLogged = _userManager.GetUserName(User);
            if (course.Trainer != userLogged)
            {
                RedirectToAction("Index");
            }
            else
            {
                return View("~/Views/Trainer/CourseEdit.cshtml", course);
            }
            if (course == null)
            {
                return NotFound();
            }
            return View("AccessDenied","Account");

        }

        // POST: Admin/Courses/CourseEdit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CourseEdit(int id, [Bind("Id,Name,Price,Duration,ThumbnailUrl,VideoUrl,Description,Trainer,DetailDescription,VidCategory")] Course course, List<IFormFile> Image)
        {
            string userLogged = _userManager.GetUserName(User);
            if(course.Trainer!=userLogged)
            {
                RedirectToAction("Index");
            }

            if (id != course.Id)
            {
                return NotFound();
            }
            foreach (var formFile in Image)
            {
                course.ThumbnailUrl = formFile.FileName;
            }
            course.Trainer = userLogged;
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(course);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CourseExists(course.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index");
            }
            return View(course);
        }

        public IActionResult CreateCourse()
        { 
            return View();
        }

        

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateCourse([Bind("Id,Name,Price,Duration,ThumbnailUrl,VideoUrl,Description,Trainer,DetailDescription,VidCategory")] Course course, List<IFormFile> Image)
        {

            foreach (var formFile in Image)
            {
                course.ThumbnailUrl = formFile.FileName;
            }


            UserCourse addCourse = new UserCourse();
            var userN = _userManager.GetUserId(HttpContext.User);
            Guid userGuid = Guid.Parse(userN);

            course.Trainer = _userManager.GetUserName(User);
            if (ModelState.IsValid)
            {
                _context.Add(course);
                
                await _context.SaveChangesAsync();

                var item = _context.Course.Where(q => q.Trainer == course.Trainer).LastOrDefault();
                addCourse.CourseId = item.Id;
                addCourse.UserId = userGuid;
                _context.Add(addCourse);
                await _context.SaveChangesAsync();

            }

            else return View("Courses/CreateCourse.cshtml", course);

            
            return RedirectToAction("Index");
        }



       
        public async Task<IActionResult> ActiveCourse(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var course = await _context.Course
                .FirstOrDefaultAsync(m => m.Id == id);
            string userLogged = _userManager.GetUserName(User);
            if (course.Trainer != userLogged)
            {
                RedirectToAction("Index");
            }
            if (course == null)
            {
                return NotFound();
            }



            // _context.Course.Remove(course);
            course.IsDeleted = false;
            await _context.SaveChangesAsync();

            return RedirectToAction("Courses", "Home");
        }
        public async Task<IActionResult> CourseDelete(int? id)
        {

            if (id == null)
            {
                return NotFound();
            }

            var course = await _context.Course
                .FirstOrDefaultAsync(m => m.Id == id);
            string userLogged = _userManager.GetUserName(User);
            if (course.Trainer != userLogged)
            {
                RedirectToAction("Index");
            }
            if (course == null)
            {
                return NotFound();
            }



            // _context.Course.Remove(course);
            course.IsDeleted = true;
            await _context.SaveChangesAsync();

            TempData["message"] = $"{course.Name} has been deleted";
            return RedirectToAction("Courses", "Home");

            //return RedirectToAction("CoursesIndex");

            //return View("~/Views/Admin/Courses/Delete.cshtml", course);

            // return RedirectToAction("Index", "Home");
        }
        public IActionResult UploadFilesTr()
        {
            return View("Upload");
        }

        [HttpPost("UploadFilesTr")]
        public async Task<IActionResult> PostFile(List<IFormFile> files)
        {

            long size = files.Sum(f => f.Length);
            // full path to file in temp location
            string filePath = "C:\\Users\\merto\\Desktop\\EducationProject\\EducationProject\\wwwroot\\img\\";



            //string fileType = Path.GetExtension(filePath);
            //var filePath = Path.GetTempFileName();

            foreach (var formFile in files)
            {
                if (formFile.Length > 0)
                {
                    using (var stream = new FileStream(filePath + formFile.FileName, FileMode.Create))
                    {
                        await formFile.CopyToAsync(stream);
                    }
                }
            }

            // process uploaded files
            // Don't rely on or trust the FileName property without validation.

            return RedirectToAction("Index");
        }
        private bool UserCourseExists(int id)
        {
            return _context.UserCourse.Any(e => e.Id == id);
        }
        private bool CourseExists(int id)
        {
            return _context.Course.Any(e => e.Id == id);
        }
        private bool UserCreditExists(int id)
        {
            return _context.UserCredit.Any(e => e.Id == id);
        }
        public IActionResult AccessDenied()
        {
            return View();
        }
        public IActionResult Test()
        {
            Console.WriteLine("Test");
            Console.WriteLine("Test");
            Console.WriteLine("Test");
            Console.WriteLine("Test");
            Console.WriteLine("Test");
            Console.WriteLine("Test");
            Console.WriteLine("Test");
            Console.WriteLine("Test");
            Console.WriteLine("Test");
            Console.WriteLine("Test");
            Console.WriteLine("Test");
            Console.WriteLine("Test");
            Console.WriteLine("Test");
            Console.WriteLine("Test");
            Console.WriteLine("Test");
            Console.WriteLine("Test");
            Console.WriteLine("Test");
            Console.WriteLine("Test");
            Console.WriteLine("Test");
            return View();
        }
    }
}
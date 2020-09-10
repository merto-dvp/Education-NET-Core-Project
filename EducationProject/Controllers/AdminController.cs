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
using Microsoft.AspNetCore.Http;
using System.IO;
using Microsoft.AspNetCore.Authorization;

namespace EducationProject.Controllers
{
    [Authorize(Roles = "Admin")]
    //[Authorize]
    public class AdminController : Controller
    {

        private readonly ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;
        //private readonly SignInManager<IdentityUser> _signInManager;


        public AdminController(ApplicationDbContext context, UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {

            _context = context;
            _userManager = userManager;

        }
      

        public IActionResult Index()
        {


          
                return View();
            
           
               // return RedirectToAction("Index", "Home");
           

        }

        public async Task<IActionResult> CoursesIndex()
        {
           
                return View("~/Views/Admin/Courses/Index.cshtml", await _context.Course.ToListAsync());
           
         
                //return RedirectToAction("Index", "Home");
           

        }
        public async Task<IActionResult> UsersIndex()
        {
           
                return View("~/Views/Admin/Users/Index.cshtml",await _context.UserCourse.ToListAsync());
          
                //return RedirectToAction("Index", "Home");
            

        }
        // GET: Admin/Courses/CourseEdit/5
        public async Task<IActionResult> CourseEdit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var course = await _context.Course.FindAsync(id);
            if (course == null)
            {
                return NotFound();
            }
            return View("~/Views/Admin/Courses/Edit.cshtml",course);
        }

        // POST: Admin/Courses/CourseEdit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CourseEdit(int id, [Bind("Id,Name,Price,Duration,ThumbnailUrl,VideoUrl,Description,Trainer,DetailDescription,VidCategory")] Course course, List<IFormFile> Image)
        {
            if (id != course.Id)
            {
                return NotFound();
            }
            foreach (var formFile in Image)
            {
                course.ThumbnailUrl = formFile.FileName;
            }
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
                return RedirectToAction("CoursesIndex");
            }
            return View("~/Views/Admin/Courses/Edit.cshtml",course);
        }


       
        // GET: Admin/Courses/CreateCourse
        public IActionResult CreateCourse()
        {

                return View("~/Views/Admin/Courses/CreateCourse.cshtml");
               
           
              //  return RedirectToAction("Index", "Home");
          

        }

        // POST: Admin/CreateCourse

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateCourse([Bind("Id,Name,Price,Duration,ThumbnailUrl,VideoUrl,Description,Trainer,DetailDescription,VidCategory")] Course course , List<IFormFile> Image)
        {
                         
                foreach (var formFile in Image)
                {
                    course.ThumbnailUrl = formFile.FileName;
                }

            course.Trainer = _userManager.GetUserName(User);
                if (ModelState.IsValid)
                {
                    _context.Add(course);
                    await _context.SaveChangesAsync();
                    return RedirectToAction("CoursesIndex");
                }

                else return View("Courses/CreateCourse.cshtml",course);
           
           
                //return RedirectToAction("Index", "Home");
        }
        // GET: Courses/Delete/5
        public async Task<IActionResult> CourseDelete(int? id)
        {
         
                if (id == null)
            {
                return NotFound();
            }

            var course = await _context.Course
                .FirstOrDefaultAsync(m => m.Id == id);
            if (course == null)
            {
                return NotFound();
            }



            // _context.Course.Remove(course);
            course.IsDeleted = true;
            await _context.SaveChangesAsync();
           
                TempData["message"] = $"{course.Name} mağazadan kaldırıldı.";
            //return RedirectToAction("Courses", "Home");
            
            return RedirectToAction("CoursesIndex");

            //return View("~/Views/Admin/Courses/Delete.cshtml", course);

       // return RedirectToAction("Index", "Home");
        }
        public async Task<IActionResult> DeletePermCourse(int? id)
        {

            if (id == null)
            {
                return NotFound();
            }

            var course = await _context.Course
                .FirstOrDefaultAsync(m => m.Id == id);
            if (course == null)
            {
                return NotFound();
            }



             _context.Course.Remove(course);
            //course.IsDeleted = true;
            await _context.SaveChangesAsync();
            ModelState.AddModelError("delete", "Silindi");
           
          
            
            return RedirectToAction("Courses", "Home");

            //return RedirectToAction("CoursesIndex");

            //return View("~/Views/Admin/Courses/Delete.cshtml", course);

            // return RedirectToAction("Index", "Home");
        }
        public async Task<IActionResult> ActiveCourse(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var course = await _context.Course
                .FirstOrDefaultAsync(m => m.Id == id);
            if (course == null)
            {
                return NotFound();
            }



            // _context.Course.Remove(course);
            course.IsDeleted = false;
            await _context.SaveChangesAsync();
            TempData["message"] = $"{course.Name} mağazaya eklendi.";

            return RedirectToAction("CoursesIndex");
        }

        // POST: Courses/Delete/5
        //[HttpPost, ActionName("CourseDelete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
            
        //        var course = await _context.Course.FindAsync(id);
        //        _context.Course.Remove(course);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction("CoursesIndex");
           
        //       // return RedirectToAction("Index", "Home");
        //}


        // GET: Admin/UserEdit/5
        public async Task<IActionResult> UserEdit(int? id)
        {
           
                if (id == null)
                {
                    return NotFound();
                }

                var userCourse = await _context.UserCourse.FindAsync(id);
                if (userCourse == null)
                {
                    return NotFound();
                }
                return View("~/Views/Admin/Users/Edit.cshtml", userCourse);
        // return RedirectToAction("Index", "Home");
        }

        // POST: Admin/UserEdit/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UserEdit(int id, [Bind("Id,UserId,CourseId")] UserCourse userCourse , List<IFormFile> Image)
        {
            
                if (id != userCourse.Id)
                {
                    return NotFound();
                }

               
                
                if (ModelState.IsValid)
                {
                    try
                    {
                        _context.Update(userCourse);
                        await _context.SaveChangesAsync();
                    }
                    catch (DbUpdateConcurrencyException)
                    {
                        if (!UserCourseExists(userCourse.Id))
                        {
                            return NotFound();
                        }
                        else
                        {
                            throw;
                        }
                    }
                    return RedirectToAction("UsersIndex", "Admin");
                }
                return View("~/Views/Admin/Users/Edit.cshtml", userCourse);
            
                //return RedirectToAction("Index", "Home");

        }
        public async Task<IActionResult> UserDelete(int? id)
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
            _context.UserCourse.Remove(userCourse);
            await _context.SaveChangesAsync();

            return RedirectToAction("UsersIndex", "Admin");
           // return View("~/Views/Admin/Users/Delete.cshtml",userCourse);
        }

        //// POST: UserCourses/Delete/5
        //[HttpPost, ActionName("UserDelete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> UserDeleteConfirmed(int id)
        //{
        //    var userCourse = await _context.UserCourse.FindAsync(id);
        //    _context.UserCourse.Remove(userCourse);
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction("UsersIndex", "Admin");
        //}
        public IActionResult Upload()
        {
            return View();
        }

        [HttpPost("UploadFiles")]
        public async Task<IActionResult> Post(List<IFormFile> files)
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

            return RedirectToAction("CoursesIndex");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> PositiveCredit([Bind("Id,UserId,Credit,Action")] UserCredit userCredit, int Credit)
        {
            if (ModelState.IsValid)
            {
                var userN = _userManager.GetUserId(HttpContext.User);
                Guid userGuid = Guid.Parse(userN);
                string abc = _userManager.GetUserId(User);
                userCredit.UserId = userGuid;
                userCredit.Credit = Credit;
                _context.Add(userCredit);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View("~/Views/Admin/UserCredits/Edit.cshtml", userCredit);
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
    }
}
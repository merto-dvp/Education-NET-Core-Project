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
using Microsoft.AspNetCore.Hosting;
using System.Runtime.InteropServices;

namespace EducationProject.Controllers
{
    public class UploadController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> userManager;
        private readonly SignInManager<IdentityUser> signInManager;
        private IHostingEnvironment Environment;

        public UploadController(UserManager<IdentityUser> _userManager, IHostingEnvironment _environment, ApplicationDbContext context, SignInManager<IdentityUser> _signInManager)
        {
            _context = context;
            userManager = _userManager;
            Environment = _environment;
            signInManager = _signInManager;

        }

        public async Task<IActionResult> AllFiles()
        {
            return View(await _context.UploadedFile.ToListAsync());
        }

        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var uploadedFile = await _context.UploadedFile
                .FirstOrDefaultAsync(m => m.id == id);
            if (uploadedFile == null)
            {
                return NotFound();
            }

            return View(uploadedFile);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,fileName,userGuid,extension")] UploadedFile uploadedFile)
        {
            if (ModelState.IsValid)
            {
                _context.Add(uploadedFile);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(uploadedFile);
        }

        // GET: Upload/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var uploadedFile = await _context.UploadedFile.FindAsync(id);
            if (uploadedFile == null)
            {
                return NotFound();
            }
            return View(uploadedFile);
        }

        // POST: Upload/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("id,fileName,userGuid,extension")] UploadedFile uploadedFile)
        {
            if (id != uploadedFile.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(uploadedFile);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UploadedFileExists(uploadedFile.id))
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
            return View(uploadedFile);
        }

        // GET: Upload/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var uploadedFile = await _context.UploadedFile
                .FirstOrDefaultAsync(m => m.id == id);
            if (uploadedFile == null)
            {
                return NotFound();
            }

            return View(uploadedFile);
        }

        // POST: Upload/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var uploadedFile = await _context.UploadedFile.FindAsync(id);
            _context.UploadedFile.Remove(uploadedFile);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UploadedFileExists(string id)
        {
            return _context.UploadedFile.Any(e => e.id == id);
        }




        private string RandomFilenameCreator()
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var random = new Random();
            var list = Enumerable.Repeat(0, 8).Select(x => chars[random.Next(chars.Length)]);
            return string.Join("", list);
        }

        public IActionResult UploadSuccessful(string id)
        {
            ViewBag.Message += id;

            return View();
        }
        public IActionResult Index()
        {

            return View();
        }


        [HttpPost]
        [RequestSizeLimit(6800000000)]
        public async Task<IActionResult> Upload(List<IFormFile> postedFiles)
        {
            string userName = "NotRegistered";
            string userId = "NotRegistered";
            string path = Path.Combine(this.Environment.WebRootPath, "img");

            //if (userManager.GetUserId(HttpContext.User) == null)
            //    path = Path.Combine(this.Environment.WebRootPath, "Uploads\\NotRegistered");
            //else
            //{
            //    var user = await userManager.GetUserAsync(HttpContext.User);
            //    userId = user.Id;
            //    userName = user.UserName;
            //    path = Path.Combine(this.Environment.WebRootPath, "Uploads\\" + user.UserName);
            //}

            string realFileName = null;
            string fileExt = "";
            string randomFileN = RandomFilenameCreator();

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            foreach (IFormFile postedFile in postedFiles)
            {
                fileExt = Path.GetExtension(postedFile.FileName);
                realFileName = Path.GetFileNameWithoutExtension(postedFile.FileName);

                using (FileStream stream = new FileStream(Path.Combine(path, randomFileN + fileExt), FileMode.Create))
                {
                    postedFile.CopyTo(stream);
                }

                UploadedFile newUpload = new UploadedFile();
                newUpload.id = randomFileN;
                newUpload.extension = fileExt;
                newUpload.userGuid = userId;
                newUpload.fileName = realFileName;
                newUpload.userName = userName;
                newUpload.fileSize = postedFile.Length;
                newUpload.imgExt = fileExt.TrimStart('.') + ".png";
                newUpload.date = DateTime.Now;
                _context.Add(newUpload);
                await _context.SaveChangesAsync();
            }
            if (realFileName != null)
                return RedirectToAction("UploadSuccessful", new { id = randomFileN });
            else
            {
                return RedirectToAction("Index", "Upload");
            }
        }
    }
}


using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using EducationProject.Models;

namespace EducationProject.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<EducationProject.Models.Course> Course { get; set; }
        public DbSet<EducationProject.Models.UserCourse> UserCourse { get; set; }
        public DbSet<EducationProject.Models.UserCredit> UserCredit { get; set; }
        public DbSet<EducationProject.Models.UploadedFile> UploadedFile { get; set; }


    }


}

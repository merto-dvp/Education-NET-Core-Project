using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EducationProject.Models
{
    public class UserCourse
    {
        public int Id { get; set; }
        public Guid UserId { get; set; }
        public int CourseId { get; set; }
      
    }
}

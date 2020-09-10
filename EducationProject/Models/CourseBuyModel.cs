using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EducationProject.Models
{
    public class CourseBuyModel
    {
        public string UserId { get; set; }
        public int CourseId { get; set; }
        public Course CourseDetail { get; set; }
        public int Credit { get; set; }
        
    }
}

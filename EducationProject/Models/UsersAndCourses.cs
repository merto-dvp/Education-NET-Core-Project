using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EducationProject.Models
{
    public class UsersAndCourses
    {
        public List<Course> Kurslar { get; set; }

        public List<UserCourse> Kullanicilar { get; set; }
        public UserCredit Kredi { get; set; }
       
        
    }
}

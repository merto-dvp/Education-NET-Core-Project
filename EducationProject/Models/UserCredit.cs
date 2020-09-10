using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EducationProject.Models
{
    public class UserCredit
    {
        public int Id { get; set; }
        public Guid UserId { get; set; }
        public int Credit { get; set; }
        public string Action { get; set; }
        public DateTime Date { get; set; }
        
        
    }
    
}

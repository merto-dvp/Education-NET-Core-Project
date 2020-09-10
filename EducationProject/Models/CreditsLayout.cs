using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EducationProject.Data;

namespace EducationProject.Models
{
    public class CreditsLayout:ViewComponent
    {
        private readonly ApplicationDbContext context;
        
        private readonly UserManager<IdentityUser> userManager;

        public CreditsLayout(ApplicationDbContext _context,UserManager<IdentityUser> _userManager)
        {
            
            userManager = _userManager;
            context = _context;

        }
        public string Invoke()
        {
            LayoutCreditsModel layoutCredit=new LayoutCreditsModel();
            if (userManager.GetUserId(HttpContext.User) != null)
            {
                var userN = userManager.GetUserId(HttpContext.User);
                Guid userGuid = Guid.Parse(userN);

                var credit = context.UserCredit.Where(q => q.UserId == userGuid).Sum(p => p.Credit);
                string kredi = credit.ToString();
                return kredi;
            }
            else
            {
                return "";
            }
        }
    }
}

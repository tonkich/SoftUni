using SimpleHttpServer.Models;
using SimpleMVC.App.Data;
using SimpleMVC.App.Models;
using SimpleMVC.App.MVC.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMVC.App.MVC.Security
{
    public class SignInManager
    {
        private IDbIdentityContext dbContext;

        public SignInManager(IDbIdentityContext context)
        {
            this.dbContext = context;
        }

        public bool IsAuthenticated(HttpSession session)
        {
            if (session == null)
            {
                return false;
            }
            Login login = dbContext.Logins.Where(u => u.SessionNum == session.Id).FirstOrDefault();
            if (login != null && login.IsActive == true)
            {
                return true;
            }
            return false;
        }

        public void Logout(HttpSession session)
        {
            var login = dbContext.Logins.FirstOrDefault(s => s.Id.ToString() == session.Id && s.IsActive == true);
            login.IsActive = false;
            dbContext.SaveChanges();
        }
    }
}

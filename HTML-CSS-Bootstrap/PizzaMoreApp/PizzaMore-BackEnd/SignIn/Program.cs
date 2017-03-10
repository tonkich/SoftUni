using PizzaMore.Data;
using PizzaMore.Utility;
using PizzaMore.Utility.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignIn
{
    class Program
    {
        public static IDictionary<string, string> RequestParameters;
        public static Header Header = new Header();
        static void Main(string[] args)
        {
            if (WebUtil.IsGet())
            {
                Header.Print();
                WebUtil.PrintFileContent(@"C:\xampp\htdocs\signin.html");

            }
            else
            {
                SignIn();
            }
        }

        private static void SignIn()
        {
            RequestParameters = WebUtil.RetrievePostParameters();
            var email = RequestParameters["email"];
            var password = RequestParameters["password"];
            string hashedPassword = PasswordHasher.Hash(RequestParameters["password"]);
            PizzaMoreContext ctx = new PizzaMoreContext();
            var user = ctx.Users.SingleOrDefault(u => u.Email == email);
            if (hashedPassword==user.Password)
            {
                var session = new Session()
                {
                    Id = new Random().Next().ToString(),
                    User = user
                };
                if (user!=null)
                {
                    Header.AddCookie(new Cookie("sid", session.Id));
                }
                ctx.Sessions.Add(session);
                ctx.SaveChanges();
            }
        }
    }
}


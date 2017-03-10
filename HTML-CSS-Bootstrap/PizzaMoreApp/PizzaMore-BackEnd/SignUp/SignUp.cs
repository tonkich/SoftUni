using PizzaMore.Data;
using PizzaMore.Utility;
using PizzaMore.Utility.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignUp
{
    class SignUp
    {
        public static IDictionary<string, string> RequestParameters;
        public static Header Header = new Header();
        static void Main(string[] args)
        {
            if (WebUtil.IsGet())
            {
                Header.Print();
                WebUtil.PrintFileContent(@"C:\xampp\htdocs\signup.html");
            }
            else
            {
                RegisterUser();
            }
        }

        private static void RegisterUser()
        {
            RequestParameters = WebUtil.RetrievePostParameters();
            var email = RequestParameters["email"];
            var password = RequestParameters["password"];
            var user = new User()
            {
                Email = email,
                Password = PasswordHasher.Hash(password)
            };
            PizzaMoreContext ctx = new PizzaMoreContext();
            ctx.Users.Add(user);
            ctx.SaveChanges();
        }
    }
}

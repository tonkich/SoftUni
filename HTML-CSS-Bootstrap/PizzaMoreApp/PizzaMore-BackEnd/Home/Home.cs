using PizzaMore.Data;
using PizzaMore.Utility;
using PizzaMore.Utility.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home
{
    class Home
    {

        public static IDictionary<string, string> requestParameters;
        public static Header header=new Header();
        public static string language;
        private static Session Session;

        static void AddDefaultLanguageCookie()
        {
            if (!WebUtil.GetCookies().ContainsKey("lang"))
            {
                header.AddCookie(new Cookie("lang", "EN"));
                language = "EN";
            }
        }
        private static void TryLogOut()
        {
            if (requestParameters.ContainsKey("logout"))
            {
                if (requestParameters["logout"] == "true")
                {
                    Session = WebUtil.GetSession();
                    using (var context = new PizzaMoreContext())
                    {
                        var s = context.Sessions.Find(Session.Id);
                        context.Sessions.Remove(s);
                        context.SaveChanges();
                    }
                }
            }
        }
        private static void ShowPage()
        {
            header.Print();
            if (language.Equals("DE"))
            {
                ServeHtmlBg();
            }
            else
            {
                ServeHtmlEn();
            }
        }

        private static void ServeHtmlBg()
        {
            WebUtil.PrintFileContent(@"C:\xampp\htdocs\home-de.html");
        }

        private static void ServeHtmlEn()
        {
            WebUtil.PrintFileContent(@"C:\xampp\htdocs\home.html");
        }

        static void Main(string[] args)
        {
            AddDefaultLanguageCookie();
            if (WebUtil.IsGet())
            {
                requestParameters = WebUtil.RetrieveGetParameters();
                //TryLogOut();
                language = WebUtil.GetCookies()["lang"].Value;
            }
            else if (WebUtil.IsPost())
            {
                requestParameters = WebUtil.RetrievePostParameters();
                header.AddCookie(new Cookie("lang", requestParameters["language"]));
                language = requestParameters["language"];
            }

            ShowPage();
        }
    }
}

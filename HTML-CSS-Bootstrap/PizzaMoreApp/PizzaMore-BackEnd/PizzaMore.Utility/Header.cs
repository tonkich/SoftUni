using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaMore.Utility
{
    public class Header
    {
        public Header()
        {
            this.Type = "Content-type: text/html";
            this.Cookies = new CookieCollection();
        }

        public string Type { get; set; }
        public string Location { get; private set; }
        public ICookieCollection Cookies { get; private set; }
        public void AddLocation(string location)
        {
            location = $"Location: {location}";
        }
        public void AddCookie(Cookie cookie)
        {
            Cookies.AddCookie(cookie);
        }
        public void Print()
        {
            Console.WriteLine(this.ToString());
        }
        public override string ToString()
        {
            StringBuilder header = new StringBuilder();
            header.AppendLine(this.Type);
            if (this.Cookies.Count>0)
            {
                foreach (Cookie cookie in Cookies)
                {
                    header.AppendLine($"Set-Cookie: {cookie.ToString()}");
                }
            }
            if (this.Location != null)
            {
                header.AppendLine(this.Location);
            }
            header.AppendLine();
            header.AppendLine();
            return header.ToString();
        }
    }
}

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
            this.Type = "Content type: text/html";
            this.Cookies = new CookieCollection();
        }

        public string Type { get; set; }
        public string Location { get; set; }
        public virtual ICookieCollection Cookies { get; set; }
        public void AddLocation(string location)
        {
            location = $"Location: {location}";
        }
        public void AddCookie(Cookie cookie)
        {
            Cookies.AddCookie(cookie);
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.Type}");
            if (this.Cookies.Count!=0)
            {
                foreach (Cookie cookie in Cookies)
                {
                    sb.AppendLine($"Set-Cookie: {cookie.ToString()}");
                }
            }
            sb.AppendLine();
            sb.AppendLine();
            return sb.ToString();
        }
    }
}

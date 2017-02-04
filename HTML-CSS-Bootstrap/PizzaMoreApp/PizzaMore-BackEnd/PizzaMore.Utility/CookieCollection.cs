using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaMore.Utility
{
    public class CookieCollection : ICookieCollection
    {
        private Dictionary<string, Cookie> cookies;

        public CookieCollection()
        {
            this.cookies = new Dictionary<string, Cookie>();
        }

        
        public Cookie this[string key]
        {
            get
            {
                return cookies[key];
            }

            set
            {
                if (key !=null)
                {
                    cookies[key] = value;
                }
            }
        }

        public int Count
        {
            get
            {
                return this.cookies.Count();
            }
        }

        public void AddCookie(Cookie cookie)
        {
            this.cookies.Add(cookie.Name, cookie);
        }

        public bool ContainsKey(string key)
        {
            if (this.cookies.ContainsKey(key))
            {
                return true;
            }
            return false;
        }
        public Cookie GetCookie(string id)
        {
            Cookie cookie = this.cookies.Where(c => c.Key == id).FirstOrDefault();
            return cookie;
        }

        public IEnumerator GetEnumerator()
        {
            return (cookies as IEnumerable).GetEnumerator();

        }

        public void RemoveCookie(string cookieName)
        {
            this.cookies.Remove(cookieName);
        }
    }
}

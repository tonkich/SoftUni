using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaMore.Utility
{
    public interface ICookieCollection:IEnumerable
    {
        void AddCookie(Cookie cookie);

        void RemoveCookie(string cookieName);
        new IEnumerator GetEnumerator();

        bool ContainsKey(string key);

        Cookie GetCookie(string id);

        int Count { get; }

        Cookie this[string key] { get; set; }


    }
}

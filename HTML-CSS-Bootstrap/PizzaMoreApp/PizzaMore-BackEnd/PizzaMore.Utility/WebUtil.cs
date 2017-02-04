using PizzaMore.Data;
using PizzaMore.Utility.Models;
using System;
using System.Collections.Generic;
using System.IO;

namespace PizzaMore.Utility
{
    public class WebUtil
    {
        private static PizzaMoreContext context;
        private static ICookieCollection cookies;

        private static bool IsPost()
        {
            if (Environment.GetEnvironmentVariable("REQUEST_METHOD").ToLower()=="post")
            {
                return true;
            }
            return false;
        }

        private static bool IsGet()
        {
            if (Environment.GetEnvironmentVariable("REQUEST_METHOD").ToLower() == "get")
            {
                return true;
            }
            return false;
        }
    
        //public IDictionary<string,string> RetrieveRequestParameters()
      //{
      //    if(IsPost())
      //    {
      //        string postRequest = Environment.GetEnvironmentVariable("")
      //        string content = sr.ReadToEnd();
      //    }
      //    else if (IsGet())
      //    {
      //
      //    }
      //}

        public static ICookieCollection GetCookies()
        {
            string cookieHeader = Environment.GetEnvironmentVariable("HTTP_COOKIE");
            if (cookieHeader != null)
            {
                string[] cookiesParameters = cookieHeader.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (string cookieInfo in cookiesParameters)
                {
                    string cookieName = cookieInfo.Split('=')[0];
                    string cookieValue = cookieInfo.Split('=')[1];
                    Cookie cookie = new Cookie(cookieName, cookieValue);
                    cookies.AddCookie(cookie);
                }
            }
            return cookies;
        }

        public static Session GetSession(int id)
        {
            cookies = GetCookies();
            if (cookies.ContainsKey(id.ToString()))
            {
                Cookie corespondingCookie = cookies.GetCookie(id.ToString());
                Session session = context.Sessions.Find(corespondingCookie.Value);
                return session;
            }
            return null;
        }

        public void PrintFileContent(string path)
        {
            string[] content = File.ReadAllLines(path);
            foreach (string line in content)
            {
                Console.WriteLine(line);
            }
        }
        public void PageNotAllowed()
        {
            PrintFileContent(@"C:\Users\Tonko\Desktop\htmlExcersice\PizzaMore\PizzaMore-FrontEnd");
        }
    }
}

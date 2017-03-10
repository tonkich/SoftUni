using SimpleHttpServer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleHttpServer.Utilities
{
    public class SessionCreator
    {
        public static HttpSession Create()
        {
            var sessionId = new Random().Next().ToString();
            var session = new HttpSession(sessionId);
            return session;
        }
    }
}

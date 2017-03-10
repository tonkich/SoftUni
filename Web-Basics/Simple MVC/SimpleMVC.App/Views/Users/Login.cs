using SimpleMVC.App.MVC.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMVC.App.Views.Users
{
    public class Login:IRenderable
    {
        public string Render()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("<a href=\"/home/index\">Home<a/>");
            sb.AppendLine("<h1>Login</h1><br/>");
            sb.AppendLine("<form action=\"login\" method=\"post\"><br/>");
            sb.AppendLine("Username: <input type=\"text\" name=\"Username\"><br/>");
            sb.AppendLine("Password: <input type=\"password\" name=\"Password\"><br/>");
            sb.AppendLine("<input type=\"submit\" value=\"Log In\">");
            sb.AppendLine("</form><br/>");
            return sb.ToString();
        }
    }
}

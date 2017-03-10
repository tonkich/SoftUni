using SimpleMVC.App.Models;
using SimpleMVC.App.MVC.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMVC.App.Views.Users
{
    class All : IRenderable<AllUsernamesViewModel>
    {
        public AllUsernamesViewModel Model { get; set; }
        public string Render()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("<h3> All users</h3>");
            sb.AppendLine("<ul>");
            foreach (var username in Model.Usernames)
            {
                sb.AppendLine($"<li>{username}</li>");
            }

            sb.AppendLine("</ul>");
            return sb.ToString();
        }

    }
}

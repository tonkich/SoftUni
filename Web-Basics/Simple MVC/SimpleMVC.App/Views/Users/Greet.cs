using SimpleMVC.App.MVC.Interfaces;
using SimpleMVC.App.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMVC.App.Views.Users
{
    public class Greet : IRenderable<GreetViewModel>
    {
        public GreetViewModel Model { get; set; }

        public string Render()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"<h2>Hello user with session id: {Model.SessionId}</h2>");
            return sb.ToString();
        }
    }
}

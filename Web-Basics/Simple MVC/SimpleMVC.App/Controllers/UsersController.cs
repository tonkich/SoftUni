using SimpleMVC.App.BindingModels;
using SimpleMVC.App.Data;
using SimpleMVC.App.Models;
using SimpleMVC.App.MVC.Attributes.Methods;
using SimpleMVC.App.MVC.Interfaces;
using SimpleMVC.App.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleMVC.App.MVC.Controllers;
using SimpleHttpServer.Models;
using SimpleMVC.App.MVC.Security;

namespace SimpleMVC.App.Controllers
{
    public class UsersController:Controller
    {
        private SignInManager signInManager;
        
        public UsersController()
        {
            signInManager = new SignInManager(new NotesAppContext());
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(LoginUserBindingModel model,HttpSession session, HttpResponse response)
        {
            using (var context = new NotesAppContext())
            {
                var user = context.Users.FirstOrDefault(u => u.Username == model.Username && u.Password == model.Password);
                if (user != null)
                {
                    context.Logins.Add(new Login()
                    {
                        SessionNum = session.Id,
                        IsActive = true,
                        UserId = user.Id
                    });
                    context.SaveChanges();
                    Redirect(response, "/home/index");
                    return null;
                }
            }
            return View();
        }
        [HttpPost]
        public IActionResult Logout(HttpSession session)
        {
            signInManager.Logout(session);
            return View("Home", "Index");
        }
        [HttpGet]
        public IActionResult<GreetViewModel> Greet(HttpSession session)
        {
            var viewModel = new GreetViewModel()
            {
                SessionId = session.Id
            };

            return this.View(viewModel);
        }
        [HttpPost]
        public IActionResult Register(RegisterUserBindingModel model)
        {
            var user = new User()
            {
                Username = model.Username,
                Password = model.Password
            };
            using (var context = new NotesAppContext())
            {
                context.Users.Add(user);
                context.SaveChanges();
            }
            var viewModel = new UserProfileViewModel()
            {
                Username = model.Username
            };
            
            return View();
        }

        [HttpGet]
        public IActionResult<AllUsernamesViewModel> All(HttpSession session,HttpResponse response)
        {
            if (!signInManager.IsAuthenticated(session))
            {
                Redirect(response, "/users/login");
                return null;
            }

            List<string> usernames = null;

            using (var contex = new NotesAppContext())
            {
                usernames = contex.Users.Select(u => u.Username).ToList();
            }

            var viewModel = new AllUsernamesViewModel()
            {
                Usernames = usernames
            };

            return this.View(viewModel);
        }

        [HttpGet]
        public IActionResult<UserProfileViewModel> Profile(int id)
        {
            using (var context = new NotesAppContext())
            {
                var user = context.Users.Find(id);
                var viewModel = new UserProfileViewModel
                {
                    UserId = user.Id,
                    Username = user.Username,
                    Notes = user.UserNotes.Select(x => new NoteViewModel()
                    {
                        Title = x.Title,
                        Content = x.Content
                    }
                    )
                };
                return this.View(viewModel);
            }
        }

        [HttpPost]
        public IActionResult<UserProfileViewModel> Profile(AddNoteBindingModel model)
        {
            using (var context = new NotesAppContext())
            {
                var user = context.Users.Find(model.UserId);

                var note = new Note
                {
                    Title = model.Title,
                    Content = model.Content
                };
                user.UserNotes.Add(note);
                context.SaveChanges();
            }
            return this.Profile(model.UserId);
        }
    }
}




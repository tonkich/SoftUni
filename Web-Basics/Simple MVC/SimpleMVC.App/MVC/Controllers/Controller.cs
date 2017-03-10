using SimpleHttpServer.Models;
using SimpleMVC.App.MVC.Interfaces;
using SimpleMVC.App.MVC.ViewEngine;
using SimpleMVC.App.MVC.ViewEngine.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;


namespace SimpleMVC.App.MVC.Controllers
{
    public class Controller
    {
        public void Redirect(HttpResponse response,string location)
        {
            response.Header.Location = location;
            response.StatusCode = SimpleHttpServer.Enums.ResponseStatusCode.Found;
        }
        protected IActionResult View([CallerMemberName]string callee = "")
        {
            string controllerName = this.GetType().Name.Replace(MvcContext.current.ControllersSuffix, string.Empty);
            string fullQualifiedName = string.Format("{0}.{1}.{2}.{3}", MvcContext.current.AssemblyName, MvcContext.current.ViewsFolder, controllerName, callee);
            return new ActionResult(fullQualifiedName);
        }
        protected IActionResult View(string controller, string action)
        {
            string fullQualifiedName = string.Format("{0}.{1}.{2}.{3}", MvcContext.current.AssemblyName, MvcContext.current.ViewsFolder, controller, action);
            return new ActionResult(fullQualifiedName);
        }
        protected IActionResult<T> View<T>(T model, [CallerMemberName]string callee = "")
        {
            string controllerName = this.GetType().Name.Replace(MvcContext.current.ControllersSuffix, string.Empty);
            string fullQualifedName = MvcContext.current.AssemblyName
              + "."
              + MvcContext.current.ViewsFolder
              + "."
              + controllerName
              + "."
              + callee;

            return new ActionResult<T>(fullQualifedName, model);
        }

        protected IActionResult<T> View<T>(T model, string controller, string action)
        {
            string fullQualifedName
                = MvcContext.current.AssemblyName
                  + "."
                  + MvcContext.current.ViewsFolder
                  + "."
                  + controller
                  + "."
                  + action;

            return new ActionResult<T>(fullQualifedName, model);
        }
    }
}

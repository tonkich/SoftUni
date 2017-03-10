using SimpleHttpServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMVC.App.MVC
{
    public class MvcEngine
    {
        public static void Run(HttpServer server)
        {
            RegisterAssemblyName();
            RegisterControllers();
            RegisterViews();
            RegisterModels();

            try
            {
                server.Listen();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private static void RegisterModels()
        {
            MvcContext.current.ModelsFolder = "Models";
        }

        private static void RegisterControllers()
        {
            MvcContext.current.ControllersFolder = "Controllers";
            MvcContext.current.ControllersSuffix = "Controller";

        }

        private static void RegisterViews()
        {
            MvcContext.current.ViewsFolder = "Views";

        }

        private static void RegisterAssemblyName()
        {
            MvcContext.current.AssemblyName =
                Assembly.GetExecutingAssembly().GetName().Name;
        }

    }
}

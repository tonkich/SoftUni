using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMVC.App.MVC
{
    public class MvcContext
    {
        public static readonly MvcContext current = new MvcContext();
        
        public string AssemblyName { get; set; }
        public Assembly ApplicationAssembly { get; set; }

        public string ControllersFolder { get; set; }

        public string ControllersSuffix { get; set; }

        public string ViewsFolder { get; set; }

        public string ModelsFolder { get; set; }
    }
}

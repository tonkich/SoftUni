using SimpleHttpServer.Models;
using SimpleMVC.App.MVC.Routers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMVC.App
{
    public static class RouteTable
    {
        public static IEnumerable<Route> Routes
        {
            get
            {
                return new Route[]
                {
                    new Route()
                    {
                        Name="Controller/Action/GET",
                        Method=SimpleHttpServer.Enums.RequestMethod.GET,
                        UrlRegex=@"^/(.+)/(.+)",
                        Callable= new ControllerRouter().Handle
                    },
                     new Route()
                    {
                        Name="Controller/Action/POST",
                        Method=SimpleHttpServer.Enums.RequestMethod.POST,
                        UrlRegex=@"^/(.+)/(.+)",
                        Callable= new ControllerRouter().Handle
                    },

                };
            }
        }
    }
}

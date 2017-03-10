using PizzaMore.Data;
using PizzaMore.Utility;
using PizzaMore.Utility.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddPizza
{
    class Program
    {
        public static Header Header = new Header();
        private static IDictionary<string, string> PostParams;
        static void Main(string[] args)
        {
            var session = WebUtil.GetSession();
            if (session==null)
            {
                Header.Print();
                WebUtil.PageNotAllowed();
                return;
            }
            if (WebUtil.IsGet())
            {
                Header.Print();
                WebUtil.PrintFileContent(@"C:\Users\Tonko\Desktop\htmlExcersice\PizzaMoreApp\PizzaMore-FrontEnd\addpizza.html");
            }
            else if (WebUtil.IsPost())
            {
                PostParams = WebUtil.RetrievePostParameters();
                var ctx = new PizzaMoreContext();
                var user = ctx.Users.Find(session.UserId);
                user.PizzaSuggestions.Add(new Pizza()
                {
                    Title = PostParams["title"],
                    Recipe = PostParams["recipe"],
                    ImageUrl = PostParams["url"],
                    UpVotes = 0,
                    DownVotes = 0,
                    OwnerId = user.UserId
                });
                ctx.SaveChanges();
                Header.Print();
                WebUtil.PrintFileContent(@"C:\Users\Tonko\Desktop\htmlExcersice\PizzaMoreApp\PizzaMore-FrontEnd\addpizza.html");
            }
        }
    }
}

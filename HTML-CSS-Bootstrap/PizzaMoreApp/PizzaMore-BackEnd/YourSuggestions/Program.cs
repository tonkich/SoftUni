﻿using PizzaMore.Data;
using PizzaMore.Utility;
using PizzaMore.Utility.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourSuggestions
{
    class Program
    {
        private static IDictionary<string, string> PostParams;
        private static Session Session;
        private static Header Header = new Header();

        static void Main(string[] args)
        {
            Session = WebUtil.GetSession();
            if (Session==null)
            {
                Header.Print();
                WebUtil.PageNotAllowed();
                return;
            }
            if (WebUtil.IsGet())
            {
                ShowPage();
            }
            else if (WebUtil.IsPost())
            {
                DeletePizza();
                ShowPage();
            }
        }

        private static void DeletePizza()
        {
            PostParams = WebUtil.RetrievePostParameters();
            using (var context=new PizzaMoreContext())
            {
                var pizza = context.Pizzas.Find(int.Parse(PostParams["pizzaId"]));
                context.Pizzas.Remove(pizza);
                context.SaveChanges();
            }
        }

        private static void ShowPage()
        {
            Header.Print();
            WebUtil.PrintFileContent(@"C:\xampp\htdocs\yoursuggestions-top.html");
            PrintListOfSuggestedItems();
            WebUtil.PrintFileContent(@"C:\xampp\htdocs\yoursuggestions-bottom.html");
        }
        private static void PrintListOfSuggestedItems()
        {
            var context = new PizzaMoreContext();
            var suggestions = context.Pizzas.Where(p => p.OwnerId == Session.UserId);
            Console.WriteLine("<ul>");
            foreach (var suggestion in suggestions)
            {
                Console.WriteLine("<form method=\"POST\">");
                Console.WriteLine($"<li><a href=\"DetailsPizza.exe?pizzaid={suggestion.Id}\">{suggestion.Title}</a> <input type=\"hidden\" name=\"pizzaId\" value=\"{suggestion.Id}\"/> <input type=\"submit\" class=\"btn btn-sm btn-danger\" value=\"X\"/></li>");
                Console.WriteLine("</form>");
            }

            Console.WriteLine("</ul>");
        }
    }
}

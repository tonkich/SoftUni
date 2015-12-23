using System;
using System.Globalization;
using System.Linq;
using System.Threading;

namespace Orders
{
    class ProductsInfo
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            var data = new DataMapper();
            var categories = data.CategoriesCollection();
            var products = data.ProductsCollection();
            var orders = data.OrdersCollection();
            
            // Names of the 5 most expensive products
            var mostExpensiveProducts = products
                .OrderByDescending(p => p.unitPrice)
                .Take(5)
                .Select(p => p.name);
            Console.WriteLine(string.Join(Environment.NewLine, mostExpensiveProducts));

            Console.WriteLine(new string('-', 10));
            
            // Number of products in each category
            var numberOfProducts = products
                .GroupBy(p => p.categoryId)
                .Select(grp => new { Category = categories.First(c => c.categoryId == grp.Key).categoryName, Count = grp.Count() })
                .ToList();
            foreach (var item in numberOfProducts)
            {
                Console.WriteLine("{0}: {1}", item.Category, item.Count);
            }

            Console.WriteLine(new string('-', 10));

            // The 5 top products (by order quantity)
            var mostOrderedProducts = orders
                .GroupBy(o => o.productId)
                .Select(grp => new { Product = products.First(p => p.id == grp.Key).name, Quantities = grp.Sum(grpgrp => grpgrp.quantity) })
                .OrderByDescending(q => q.Quantities)
                .Take(5);
            foreach (var item in mostOrderedProducts)
            {
                Console.WriteLine("{0}: {1}", item.Product, item.Quantities);
            }
            
            Console.WriteLine(new string('-', 10));

            // The most profitable category
            var mostProfitableCategory = orders
                .GroupBy(o => o.productId)
                .Select(g => new { catId = products.First(p => p.id == g.Key).categoryId, price = products.First(p => p.id == g.Key).unitPrice, quantity = g.Sum(p => p.quantity) })
                .GroupBy(gg => gg.catId)
                .Select(grp => new { category_name = categories.First(c => c.categoryId == grp.Key).categoryName, total_quantity = grp.Sum(g => g.quantity * g.price) })
                .OrderByDescending(g => g.total_quantity)
                .First();
            Console.WriteLine("{0}: {1}", mostProfitableCategory.category_name, mostProfitableCategory.total_quantity);
        }
    }
}

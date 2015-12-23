using System.Collections.Generic;
using System.Linq;
using o;
using System.IO;

namespace Orders
{
    public class DataMapper
    {
        private string categories;
        private string products;
        private string orders;

        public DataMapper(string categories, string products, string orders)
        {
            this.categories = categories;
            this.products = products;
            this.orders = orders;
        }

        public DataMapper()
            : this("../../Data/categories.txt", "../../Data/products.txt", "../../Data/orders.txt")
        {
        }

        public IEnumerable<category> CategoriesCollection()
        {
            var category = readFileLines(this.categories, true);
            return category
                .Select(c => c.Split(','))
                .Select(c => new category
                {
                    categoryId = int.Parse(c[0]),
                    categoryName = c[1],
                    description = c[2]
                });
        }

        public IEnumerable<product> ProductsCollection()
        {
            var product = readFileLines(this.products, true);
            return product
                .Select(p => p.Split(','))
                .Select(p => new product
                {
                    id = int.Parse(p[0]),
                    name = p[1],
                    categoryId = int.Parse(p[2]),
                    unitPrice = decimal.Parse(p[3]),
                    unitsInStock = int.Parse(p[4]),
                });
        }

        public IEnumerable<order> OrdersCollection()
        {
            var order = readFileLines(this.orders, true);
            return order
                .Select(p => p.Split(','))
                .Select(p => new order
                {
                    id = int.Parse(p[0]),
                    productId = int.Parse(p[1]),
                    quantity = int.Parse(p[2]),
                    discount = decimal.Parse(p[3]),
                });
        }

        private List<string> readFileLines(string filename, bool hasHeader)
        {
            var allLines = new List<string>();
            using (var reader = new StreamReader(filename))
            {
                string currentLine;
                if (hasHeader)
                {
                    reader.ReadLine();
                }

                while ((currentLine = reader.ReadLine()) != null)
                {
                    allLines.Add(currentLine);
                }
            }

            return allLines;
        }
    }
}

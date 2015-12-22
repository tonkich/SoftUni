using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    public static class LinqExtension
    {
        public static IEnumerable<T> WhereNot<T>(this IEnumerable<T> collection, Func<T, bool> predicate)
        {
            List<T> result = new List<T>();
            foreach (var element in collection)
            {
                if (!predicate(element))
                {
                    result.Add(element);
                }
            }
            return result;
        }

        public static TSelector CustomMax<TSource, TSelector>(this IEnumerable<TSource> collection, Func<TSource, TSelector> selector) 
            where TSelector : IComparable
        {
            if (collection == null)
            {
                throw new InvalidOperationException("Collection is empty!");
            }

            TSelector result = selector(collection.First());

            foreach (var element in collection)
            {
                if (result.CompareTo(selector(element)) < 0)
                {
                    result = selector(element);
                }
            }

            return result;
        }
        public static void Main()
        {
            List<int> list = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            var oddNumbers = list.WhereNot(x => x % 2 == 0).ToList();

            Console.WriteLine(string.Join(", ", oddNumbers));

            List<Person> people = new List<Person>
                                      {
                                          new Person("Ivan", 21),
                                          new Person("Pesho", 32),
                                          new Person("Todor", 18),
                                          new Person("Minka", 16),
                                          new Person("Penka", 54)
                                      };

            Console.WriteLine(people.CustomMax(p => p.Age));
        }

    }
}

namespace Sortable_Collection
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Contracts;

    public class SortableCollection<T> where T : IComparable<T>
    {
        public SortableCollection()
        {
        }

        public SortableCollection(IEnumerable<T> items)
        {
            this.Items = new List<T>(items);
        }


        public SortableCollection(params T[] items)
            : this(items.AsEnumerable())
        {
        }

        public List<T> Items { get; } = new List<T>();

        public int Count => this.Items.Count;

        public void Sort(ISorter<T> sorter)
        {
            sorter.Sort(this.Items);
        }

        public int InterpolationSearch(SortableCollection<T> x, int searchValue)
        {
            
            List<int> x1 = new List<int>();
            foreach (var item in x.Items)
            {
                x1.Add(Convert.ToInt32(item));
            }
            x1.Sort();
            int[] x2 = x1.ToArray();
            int low = 0;
            int high = x.Items.Count - 1;
            int mid;

            while (x2[low] < searchValue && x1[high] >= searchValue)
            {
                mid = low + ((searchValue - x2[low]) * (high - low)) / (x2[high] - x2[low]);

                if (x2[mid] < searchValue)
                    low = mid + 1;
                else if (x2[mid] > searchValue)
                    high = mid - 1;
                else
                    return mid;
            }

            if (x2[low] == searchValue)
                return low;
            else
                return -1;
        }

        public void Shuffle(SortableCollection<T> x)
        {
            Random random = new Random();
            T[] array = x.ToArray();
            int n = array.Length;
            for (int i = 0; i < n; i++)
            {
                int r = i + (int)(random.NextDouble() * (n - i));
                T t = array[r];
                array[r] = array[i];
                array[i] = t;
            }
        }

        public T[] ToArray()
        {
            return this.Items.ToArray();
        }

        public override string ToString()
        {
            return $"[{string.Join(", ", this.Items)}]";
        }        
    }
}
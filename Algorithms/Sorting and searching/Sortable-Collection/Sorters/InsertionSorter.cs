namespace Sortable_Collection.Sorters
{
    using System;
    using System.Collections.Generic;

    using Sortable_Collection.Contracts;

    public class InsertionSorter<T> : ISorter<T> where T : IComparable<T>
    {
        public void Sort(List<T> collection)
        {
            int i, j;

            for (i = 1; i < collection.Count; i++)
            {
                T value = collection[i];
                j = i - 1;
                while ((j >= 0) && (collection[j].CompareTo(value) > 0))
                {
                    collection[j + 1] = collection[j];
                    j--;
                }
                collection[j + 1] = value;
            }
        }
    }
}

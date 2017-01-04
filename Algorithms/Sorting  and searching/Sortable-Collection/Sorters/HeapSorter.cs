namespace Sortable_Collection.Sorters
{
    using System;
    using System.Collections.Generic;

    using Sortable_Collection.Contracts;

    public class HeapSorter<T> : ISorter<T> where T : IComparable<T>
    {
        public void Sort(List<T> collection)
        {
            throw new NotImplementedException();
        }
        public static void HeapSort(int[] array, int arrayBound)
        {
            int i, j;
            int leftChild, rightChild, Parent, root, temp;
            root = (arrayBound - 1) / 2;
            for (j = root; j >= 0; j--)
            {
                for (i = root; i >= 0; i--)
                {
                    leftChild = (2 * i) + 1;
                    rightChild = (2 * i) + 2;
                    if ((leftChild <= arrayBound) && (rightChild <= arrayBound))
                    {
                        if (array[rightChild] >= array[leftChild])
                            Parent = rightChild;
                        else
                            Parent = leftChild;
                    }
                    else
                    {
                        if (rightChild > arrayBound)
                            Parent = leftChild;
                        else
                            Parent = rightChild;
                    }
                    if (array[i] < array[Parent])
                    {
                        temp = array[i];
                        array[i] = array[Parent];
                        array[Parent] = temp;
                    }
                }
            }
            temp = array[0];
            array[0] = array[arrayBound];
            array[arrayBound] = temp;
            return;
        }
    }
}

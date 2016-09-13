namespace Sortable_Collection.Sorters
{
    using System;
    using System.Collections.Generic;

    using Sortable_Collection.Contracts;

    public class MergeSorter<T> : ISorter<T> where T : IComparable<T>
    {
        public void Sort(List<T> collection)
        {
            throw new NotImplementedException();
        }
        private void MergeSort(int[] input, int start,int end)
        {
            if(start<end)
            {
                int middle = (end + start) / 2;

                MergeSort(input,  start, middle);
                MergeSort(input, middle + 1, end);

                int[] leftArray = new int[middle - start + 1];
                int[] rightArray = new int[end - middle];

                Array.Copy(input, start, leftArray, 0, middle - start + 1);
                Array.Copy(input, middle + 1, rightArray, 0, end - middle);

                int i = 0;
                int j = 0;
                for (int k = start; k < end + 1; k++)
                {
                    if (i == leftArray.Length)
                    {
                        input[k] = rightArray[j];
                        j++;
                    }
                    else if (j == rightArray.Length)
                    {
                        input[k] = leftArray[i];
                        i++;
                    }
                    else if (leftArray[i] <= rightArray[j])
                    {
                        input[k] = leftArray[i];
                        i++;
                    }
                    else
                    {
                        input[k] = rightArray[j];
                        j++;
                    }
                }
            }
        }
    }
}

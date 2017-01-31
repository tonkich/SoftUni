using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApplication15
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            List<WTuple<int[], int[]>> jaggedArrays = new List<WTuple<int[], int[]>>();
            int numberOfRows = int.Parse(Console.ReadLine());
            int k = 0;
            for (int i = 0; i < numberOfRows; i++)
            {

                string[] rowInfo = Console.ReadLine().Split(new char[] {' ' },StringSplitOptions.RemoveEmptyEntries);
                jaggedArrays.Add(new WTuple<int[], int[]>(new int[rowInfo.Length], null));
                foreach (string num in rowInfo)
                {
                    jaggedArrays[i].Item1[k] = int.Parse(num);
                    k++;
                }
                k = 0;
            }
            for (int i = 0; i < numberOfRows; i++)
            {
                string[] rowInfo = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                jaggedArrays[i].Item2=new int[rowInfo.Length];
                for (int j = rowInfo.Length-1; 0 <= j; j--,k++)
                {
                    jaggedArrays[i].Item2[k] = int.Parse(rowInfo[j]);
                    
                }
                k = 0;
            }
            List<int[]> combinedJaggedArrays = new List<int[]>();
            bool fits = false;
            foreach (WTuple<int[],int[]> tuple in jaggedArrays)
            {
                int[] combinedArray = tuple.Item1.Concat(tuple.Item2).ToArray();
                combinedJaggedArrays.Add(combinedArray);
            }
            for (int i = 1; i < combinedJaggedArrays.Count; i++)
            {
                if (combinedJaggedArrays[i-1].Length==combinedJaggedArrays[i].Length)
                {
                    fits = true;
                }
                else
                {
                    fits = false;
                }
            }
            if (fits==true)
            {
                foreach (int[] combinedArray in combinedJaggedArrays)
                {
                    Console.WriteLine($"[{string.Join(", ", combinedArray)}]");
                }
            }
            else
            {
                int cellsCount = 0;
                foreach (int[] combinedArray in combinedJaggedArrays)
                {
                    cellsCount += combinedArray.Sum();
                }
                Console.WriteLine($"The total number of cells is: {cellsCount}");
            }
        }
        internal interface IWTuple
        {
            string ToString(StringBuilder sb);
            int GetHashCode(IEqualityComparer comparer);
            int Size { get; }
        }

        /// <summary>
        /// Represents a writable 2-tuple, or pair.
        /// </summary>
        /// <typeparam name="T1">The type of the tuple's first component.</typeparam>
        /// <typeparam name="T2">The type of the tuple's second component.</typeparam>
        public class WTuple<T1, T2> : IStructuralEquatable, IStructuralComparable, IComparable, IWTuple
        {
            private T1 _item1;
            private T2 _item2;

            #region ImplementedInterfaces
            Int32 IStructuralEquatable.GetHashCode(IEqualityComparer comparer)
            {
                return comparer.GetHashCode(_item1);
            }
            Boolean IStructuralEquatable.Equals(Object other, IEqualityComparer comparer)
            {
                if (other == null) return false;
                WTuple<T1, T2> objTuple = other as WTuple<T1, T2>;//Tuple<t1, t2=""> objTuple = other as Tuple<t1, t2="">;
                if (objTuple == null)
                {
                    return false;
                }
                return comparer.Equals(_item1, objTuple._item1) && comparer.Equals(_item2, objTuple._item2);
            }
            Int32 IStructuralComparable.CompareTo(Object other, IComparer comparer)
            {
                if (other == null) return 1;
                WTuple<T1, T2> objTuple = other as WTuple<T1, T2>;//Tuple<t1, t2=""> objTuple = other as Tuple<t1, t2="">;
                if (objTuple == null)
                {
                    throw new ArgumentException("ArgumentException_TupleIncorrectType", "other");//ArgumentException(Environment.GetResourceString("ArgumentException_TupleIncorrectType", this.GetType().ToString()), "other");
                }
                int c = 0;
                c = comparer.Compare(_item1, objTuple._item1);
                if (c != 0) return c;
                return comparer.Compare(_item2, objTuple._item2);
            }
            Int32 IComparable.CompareTo(Object obj)
            {
                return ((IStructuralComparable)this).CompareTo(obj, Comparer<object>.Default);
            }
            Int32 IWTuple.GetHashCode(IEqualityComparer comparer)
            {
                return ((IStructuralEquatable)this).GetHashCode(comparer);
            }
            string IWTuple.ToString(StringBuilder sb)
            {
                sb.Append(_item1);
                sb.Append(", ");
                sb.Append(_item2);
                sb.Append(")");
                return sb.ToString();
            }
            int IWTuple.Size
            {
                get { return 2; }
            }
            #endregion

            #region WTuple
            /// <summary>
            /// Initializes a new instance of the System.WTuple&lt;T1,T2&gt; class.
            /// </summary>
            /// <param name="item1">The value of the tuple's first component.</param>
            /// <param name="item2">The value of the tuple's second component.</param>
            public WTuple(T1 item1, T2 item2)
            {
                _item1 = item1;
                _item2 = item2;
            }
            /// <summary>
            /// Gets or sets the value of the current System.WTuple&lt;T1,T2&gt; object's first component.
            /// </summary>
            public T1 Item1
            {
                get { return _item1; }
                set { _item1 = value; }
            }
            /// <summary>
            /// Gets or sets the value of the current System.WTuple&lt;T1,T2&gt; object's second component.
            /// </summary>
            public T2 Item2
            {
                get { return _item2; }
                set { _item2 = value; }
            }
            /// <summary>
            /// Returns a value that indicates whether the current System.WTuple&lt;T1,T2&gt; object
            /// is equal to a specified object.
            /// </summary>
            /// <param name="obj">The object to compare with this instance.</param>
            /// <returns>true if the current instance is equal to the specified object; otherwise,
            /// false.</returns>
            public override Boolean Equals(Object obj)
            {
                return ((IStructuralEquatable)this).Equals(obj, EqualityComparer<object>.Default);
            }
            /// <summary>
            /// Returns the hash code for the current System.WTuple&lt;T1,T2&gt; object.
            /// </summary>
            /// <returns>A 32-bit signed integer hash code.</returns>
            public override int GetHashCode()
            {
                return ((IStructuralEquatable)this).GetHashCode(EqualityComparer<object>.Default);
            }
            /// <summary>
            /// Returns a string that represents the value of this System.WTuple&lt;T1,T2&gt; instance.
            /// </summary>
            /// <returns>The string representation of this System.WTuple&lt;T1,T2&gt; object.</returns>
            public override string ToString()
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("(");
                return ((IWTuple)this).ToString(sb);
            }
            #endregion
        }
    }

}
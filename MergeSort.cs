using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    public class MergeSort<T> : SortingMetrics<T>
        where T : IComparable
    {
        private T[] SortTwoArrays(T[] sorted, T[] firstArray, T[] secondArray)
        {
            sorted = new T[firstArray.Length + secondArray.Length];

            var difFirst = firstArray.Length == secondArray.Length ? false : true;
            var length = firstArray.Length + secondArray.Length;
            var firsIndex = 0;
            var secondIndex = 0;
            for (int i = 0; i < length; i++)
            {
                if ( firstArray[firsIndex].CompareTo(firstArray[secondIndex]) < 0)
                {
                    sorted[i] = firstArray[firsIndex];
                    firsIndex++;
                }
                else
                {
                    sorted[i] = secondArray[secondIndex];
                    secondIndex++;
                }
                if (difFirst && firsIndex == firstArray.Length - 1)
                {
                    sorted[i+1] = secondArray[secondIndex];
                    return sorted;
                }
            }
            return sorted;
        }
        public override T[] MetricSort(T[] data)
        {
            if (data.Length < 2)
            {
                return data;
            }
            var firstSize = data.Length / 2;
            var lastSize = data.Length - firstSize;
            var first = new T[firstSize];
            var last = new T[lastSize];
            MetricSort(first);
            MetricSort(last);

            return SortTwoArrays(data, first, last);
        }
    }
}

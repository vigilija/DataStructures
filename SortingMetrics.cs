using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    public abstract class SortingMetrics<T> : ISorting<T> // generic class for sorting algorith helpers
        where T : IComparable
    {
        public int Swaps { get;  set; }
        public int Comparisons { get;  set; }

        public abstract T[] MetricSort(T[] data);

        public void Reset() //reset counting params
        {
            Swaps = 0;
            Comparisons = 0;
        }

        public T[] Sort(T[] data) // performs reset and individual sort algorithm
        {
            Reset();
            return MetricSort(data);
        }
        protected void Swap(T[] data, int left, int right) // swaps two elements
        {
            T temp = data[left];
            data[left] = data[right];
            data[right] = temp;
        }
        protected void Assign(T[] data, int index, T value) //assign value toelement
        {
            data[index] = value;
            Swaps++;
        }
    }
}

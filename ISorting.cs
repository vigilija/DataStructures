using System;

namespace DataStructures
{
    public interface ISorting<T>
    {
        int Comparisons { get; }
        int Swaps { get; }

        T[] Sort(T[] data);
        T[] MetricSort(T[] data);
        void Reset();
    }
}

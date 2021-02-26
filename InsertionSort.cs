using System;

namespace DataStructures
{
    public class InsertionSort<T>: SortingMetrics<T>
        where T : IComparable
    {
        public override T[] MetricSort(T[] data)
        {
            for (var i = 0; i < data.Length - 1; i++)
            {
                if (data[i + 1].CompareTo(data[i]) < 0)
                {
                    Swap(data, i, i + 1);
                    for (var j = 0; j < i; j++)
                    {
                        if (data[i].CompareTo(data[j]) < 0)
                        {
                            Swap(data, i, j);
                        }
                    }
                }
            }
            return data;
        }
    }
}

using System;
namespace DataStructures
{
    public class BubbleSort<T> : SortingMetrics<T>
        where T : IComparable
    {
        public override T[] MetricSort(T[] data)
        {
            var i = 0;
            // var swaps = 0;
            while (true)
            {
                if (data[i + 1].CompareTo(data[i]) <0)
                {
                    Swap(data, i + 1, i);
                    Swaps++;
                }
                i++;
                if (i == data.Length - 1)
                {             
                    if (Swaps == 0)
                    {
                        return data;
                    }
                    Swaps = 0;
                    i = 0;
                }
            }
        }
    }
}

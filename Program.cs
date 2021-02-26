using System;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            var arrayToSort = new int[] { 12, 5, 3, 4, 6, 10, 8, 6, 7 };
            Console.WriteLine("Bubble sort");
            var bubble = new BubbleSort<int>();
            var sorted = bubble.MetricSort(arrayToSort);
            Console.WriteLine("Bubble sort end");

            Console.WriteLine("Insertion sort");
            var insertion = new InsertionSort<int>();
            var sorted2 = insertion.MetricSort(arrayToSort);
            Console.WriteLine("Insertion sort end");

            Console.WriteLine("Merge sort begin");
            var buble = new BubbleSort<int>();
            var sort3 = bubble.MetricSort(arrayToSort);
            Console.WriteLine("Merge sort ended");
        }
    }
}

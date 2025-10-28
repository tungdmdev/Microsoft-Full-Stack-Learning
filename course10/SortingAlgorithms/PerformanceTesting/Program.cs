using System;
using System.Diagnostics;
class Program
{
    static void Main()
    {
        int[] numbers = { 5, 3, 8, 4, 2, 7, 1, 6 };
        
        Console.WriteLine("Original Array:");
        Console.WriteLine(string.Join(", ", numbers));
        Stopwatch stopwatch = Stopwatch.StartNew();
        int[] quicksortArray = (int[])numbers.Clone();
        QuickSort(quicksortArray, 0, quicksortArray.Length - 1);
        stopwatch.Stop();
        Console.WriteLine("Quicksort Time: " + stopwatch.ElapsedMilliseconds + " ms");
        stopwatch.Restart();
        int[] mergeSortArray = (int[])numbers.Clone();
        MergeSort(mergeSortArray, 0, mergeSortArray.Length - 1);
        stopwatch.Stop();
        Console.WriteLine("Merge Sort Time: " + stopwatch.ElapsedMilliseconds + " ms");
        stopwatch.Restart();
        int[] bubbleSortArray = (int[])numbers.Clone();
        BubbleSort(bubbleSortArray);
        stopwatch.Stop();
        Console.WriteLine("Bubble Sort Time: " + stopwatch.ElapsedMilliseconds + " ms");
    }
}
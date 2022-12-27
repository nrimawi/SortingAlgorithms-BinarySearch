using ConsoleApp1;
using System.Diagnostics;


namespace SortingAlgh
{
    class Program
    {
        static void Main(string[] args)
        {
            //#region Generate An Array 
            //int[] arr = new int[400000];
            //Random rnd = new Random();

            //for (int i = 0; i < 400000; i++)
            //{

            //    arr[i] = rnd.Next(1, 400000);
            //}
            //#endregion

            Stopwatch sw = Stopwatch.StartNew();
            //  Insertion.InsertionSort(arr);
            //  Merge.MergeSort(arr);,
            int[] arr2 = new int[] { 1, 8, 3, 9, 4, 5, 7 };
            Count.Count_Sort(arr2);
            #region print array
            for (int i = 0; i < arr2.Length; i++)
                Console.WriteLine(arr2[i]);
            #endregion

            Console.WriteLine(sw.Elapsed);


        }
    }



}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgh
{
    internal class Insertion
    {
        public static void InsertionSort(int[] arr)

        {
            for (int i = 0; i < arr.Length; i++)
                for (int j = i; j > 0 && arr[j - 1] > arr[j]; j--)
                {
                    swap(arr, j, j - 1);
                }
        }

        public static void swap(int[] arr, int x, int y)
        {
            int temp =arr[x];
            arr[x] = arr[y];
            arr[y] = temp;
        }
    }
}

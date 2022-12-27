using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgh
{
    internal class Quick
    {
        //We choose a pivot and let it the first index 
        //we use two pointer the first one is at the next index of the pivoit anb the other is at the end
        //the first pointer will move until there is an value in greater then pivot
        //the second pointer will move unitl there is an value is lower than the poivot 
        //if the pointers are not intersect swap them else swap the pivot with the second pointer

        public static void QuickSort(int[] arr)
        {

            Quick_sort(arr, 0, arr.Length - 1);

        }


        static void Quick_sort(int[] arr, int low, int high)
        {
            if (low >= high)
                return;

            int j = Sort(arr, low, high);
            Quick_sort(arr, low, j - 1);
            Quick_sort(arr, j + 1, high);

        }
        static int Sort(int[] arr, int low, int high)
        {
            int pivot = arr[low];
            int i = low + 1;
            int j = high;
            while (i <= j)
            {
                while (arr[i] < pivot)
                {
                    i++;
                    if (i > high) break;
                }

                while (arr[j] > pivot)
                {
                    j--;
                    if (j == low) break;
                }


                if (i >= j) break;

                swap(arr, i, j);
            }
            swap(arr, low, j);

            return j;
        }

        public static void swap(int[] arr, int x, int y)
        {
            int temp = arr[x];
            arr[x] = arr[y];
            arr[y] = temp;
        }


    }

}

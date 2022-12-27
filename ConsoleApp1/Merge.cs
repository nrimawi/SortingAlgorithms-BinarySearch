using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgh
{
    internal class Merge
    {
        public static void MergeSort(int[] arr)
        {
            divide(arr, 0, arr.Length - 1);
        }
        public static void divide(int[] arr, int start, int end)
        {
            if (end <= start) return;
            int mid = (start + end) / 2;
            divide(arr, start, mid);
            divide(arr, mid + 1, end);
            merge(arr, start, mid, end);

        }

        public static void merge(int[] arr, int start, int mid, int end)
        {
            int[] copy = new int[arr.Length];
            for (int w = start; w <= end; w++)
            {
                copy[w] = arr[w];
            }

            int i = start;
            int j = mid + 1;

            for (int k = start; k <= end; k++)
            {

                if (i > mid)
                {
                    arr[k] = copy[j];
                    j++;
                }

                else if (j > end)
                {
                    arr[k] = copy[i];
                    i++;
                }
                else if (copy[i] > copy[j])
                {
                    arr[k] = copy[j];
                    j++;
                }

                else
                {
                    arr[k] = copy[i];
                    i++;
                }


            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class BinarySearch
    {
        public static int _BinarySearch(int[] arr, int target)
        {
            int lo = 0;
            int hi = arr.Length - 1;
            int mid = (lo + hi) / 2;

            while (lo <= hi)
            {
                if (target < arr[mid])
                {
                    hi = mid - 1;
                    mid = (lo + hi) / 2;
                }
                else if (target > arr[mid])
                {
                    lo= mid+1;
                    mid = (lo + hi) / 2;

                }

                else
                return mid;
            }
            return -1;
        }
    }
}

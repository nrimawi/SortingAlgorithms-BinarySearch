using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    //We count occurance of each element and store at a count array 
    //do a prefix sum on the count array
    //but each element at output array based on the count array => output[count[input[i]-1]=input[i]
    internal class Count
    {
        public static void Count_Sort(int[] arr)
        {
            int[] count = new int[10000000];//We can get the max number to be the length  

            for (int i = 0; i < arr.Length; i++)
            {
                count[arr[i]]++;

            }

            for (int i = 1; i < count.Length; i++)
            {
                count[i] += count[i - 1];
            }

            int[] copy = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                copy[count[arr[i]]-1]=arr[i];
                if(count[arr[i]]>0)
                    count[arr[i]]--;
            }

            Array.Copy(copy,arr,arr.Length);
        }
    }
}

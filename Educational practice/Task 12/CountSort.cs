using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_12
{
    class CountSort
    {
        private int counter;
        public int Counter
        {
            get
            {
                return counter;
            }
        }
        public int[] Sort(int[] initialArray)
        {
            int[] countArray = new int[initialArray.Max() + 1];
            for (int i = 0; i < initialArray.Length; i++)
            {
                counter++;
                countArray[initialArray[i]]++;
            }

            int[] sortedArray = new int[initialArray.Length];
            int sortedArrayIndex = 0;
            for (int i = countArray.Length - 1; i >= 0; i--)
            {
                for (int j = 0; j < countArray[i]; j++)
                {
                    sortedArray[sortedArrayIndex++] = i;
                }
            }
            return sortedArray;
        }
    }
}

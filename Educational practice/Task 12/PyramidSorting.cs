using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_12
{
    class PyramidSorting
    {     
        private int counter;
        public int Counter
        {
            get
            {
                return counter;
            }
        }
        int AddToTree(int[] array, int i, int N)
        {
            int max;
            int temp;

            if ((2 * i + 2) < N)
            {
                counter++;
                if (array[2 * i + 1] < array[2 * i + 2])
                {
                    counter++;
                    max = 2 * i + 2;
                }
                else
                {
                    max = 2 * i + 1;
                }                 
            }
            else
            {
                max = 2 * i + 1;
            }
               
            if (max >= N)
            {
                counter++;
                return i;
            }
               

            if (array[i] < array[max])
            {
                counter++;

                temp = array[i];
                array[i] = array[max];
                array[max] = temp;

                if (max < N / 2)
                {
                    i = max;
                }
                    
            }
            return i;
        }
        public void Sort(int[] array, int size)
        {
            // Заполнить дерево
            for (int i = size / 2 - 1; i >= 0; i--)
            {
                long prev = i;
                i = AddToTree(array, i, size);

                if (prev != i)
                    i++;
            }

            // Сортировка
            int temp;
            for (int k = size - 1; k > 0; k--)
            {
                temp = array[0];
                array[0] = array[k];
                array[k] = temp;

                int i = 0;
                int prev = -1;

                while (i != prev)
                {
                    
                    prev = i;
                    i = AddToTree(array, i, k);
                }
            }
        }
    }
}

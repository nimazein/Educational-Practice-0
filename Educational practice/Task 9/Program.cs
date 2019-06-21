using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_9
{
    class Program
    {
        static LoopList list = new LoopList();
        static int size = 5;
        static void Main(string[] args)
        {
            FillList();
            list.NegativeSum();
            Console.WriteLine();
            list.PositiveSum();
            Console.ReadKey();
        }
        static void FillList()
        {
            Random rnd = new Random();

            for (int i = 0; i < size; i++) 
            {
                int value = rnd.Next(-100, 100);
                list.Add(value);
            }

            list.GoThrough();
        }
    }
}

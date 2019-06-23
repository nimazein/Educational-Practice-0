using System;
using System.Text;

namespace Task_9
{
    class Program
    {
        static LoopList list = new LoopList();
        static int size = 4;
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            InputElements();

            //FillList();
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
        static void InputElements()
        {
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Значение {i + 1}: ");
                list.Add(Convert.ToInt32(Console.ReadLine()));
            }
        }
    }
}

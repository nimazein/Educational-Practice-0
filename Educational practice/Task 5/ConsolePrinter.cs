using System;
using System.Text;

namespace Task_5
{
    class ConsolePrinter : IPrinter
    {
        public void Print(double maxNumber)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("Наибольший элемент в области: {0:#.##}",maxNumber);
            Console.ReadKey();
        }
        public void Print(double[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                Console.WriteLine();
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write("{0:#.##}" + " ", matrix[i, j]);
                }
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
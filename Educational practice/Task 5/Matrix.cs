using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    class Matrix
    {
        private static Random rnd = new Random();
        private static double[,] matrix;
        private static double max;

        public static void CreateMatrix()
        {
            Console.Write("n = ");
            try
            {
                int n = Convert.ToInt32(Console.ReadLine());

                matrix = new double[n, n];
                FillMatrixRandomly();
            }
            catch (Exception)
            {
                Console.WriteLine("Ошибка ввода");
            }
        }
        public static void FillMatrixRandomly()
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    double number = rnd.NextDouble() * rnd.Next(-100, 100);
                    matrix[i, j] = number;
                }
            }
        }

        //public static void OutputMatrix()
        //{
        //    for (int i = 0; i < matrix.GetLength(0); i++)
        //    {
        //        Console.WriteLine();
        //        for (int j = 0; j < matrix.GetLength(1); j++)
        //        {
        //            Console.Write("{0:#.##}" + " ", matrix[i, j]);
        //        }
        //    }
        //    Console.WriteLine();
        //    Console.WriteLine();
        //    Console.WriteLine();
        //}
        public static void FindMaxNumber()
        {
            max = matrix[0, 0];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = i; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] > max)
                    {
                        max = matrix[i, j];
                    }
                }
            }
        }
        public static void PrintMaxNumber()
        {
            ConsolePrinter printer = new ConsolePrinter();
            printer.Print(max);
        }
    }
}

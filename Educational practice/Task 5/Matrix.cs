using System;

namespace Task_5
{
    class Matrix
    {       
        private double[,] matrix;
        private double max;

        public void CreateMatrix()
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
        public void FillMatrixRandomly()
        {
            Random rnd = new Random();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    double number = rnd.NextDouble() * rnd.Next(-100, 100);
                    matrix[i, j] = number;
                }
            }
        }

        public void OutputMatrix()
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
            Console.WriteLine();
        }
        public void FindMaxNumber()
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
        public void PrintMaxNumber(IPrinter printer)
        {
            printer.Print(max);
        }
    }
}

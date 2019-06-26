using System;

namespace Task_5
{
    class Matrix
    {       
        private double[,] matrix;
        private double max;

        public void CreateMatrix(IReader reader)
        {
            int n = reader.ReadN();
            matrix = new double[n, n];
            FillMatrixRandomly();
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

        public void OutputMatrix(IPrinter printer)
        {
            printer.Print(matrix);
        }
        public void PrintMaxNumber(IPrinter printer)
        {
            printer.Print(max);
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
        
    }
}

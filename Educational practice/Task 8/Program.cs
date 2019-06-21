using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_8
{
    class Program
    {
        static byte[,] matrix;
        static void Main(string[] args)
        {
            FillMatrix();

            Console.ReadKey();
        }
        static void FillMatrix()
        {
            Random rnd = new Random();
            int size = 6;
            matrix = new byte[size,size];

            for (int j = 0; j < size; j++)
            {
                for (int i = 0; i < size; i++)
                {
                    matrix[i, j] = Convert.ToByte(rnd.Next(0, 2));
                }
            }
            OutputMatrix();

        }
        static void OutputMatrix()
        {
            for (int j = 0; j < matrix.GetLength(0); j++)
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    Console.Write(matrix[i, j] + " "); 
                }
                Console.WriteLine();

            }
        }
        static void FindKlika()
        {
            int size = 3;
            int xStart = 0;
            int yStart = 0;
            while (true)
            {
                for (int k = 0; k < 2; k++)
                {
                    for (int j = xStart; j < xStart + size; j++)
                    {
                        for (int i = yStart; i < yStart + size; i++)
                        {

                        }
                    }
                    xStart += 1;
                }
                xStart = 0;
                yStart += 1;
            }
            
            
        }
    }
}

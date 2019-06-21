using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_10
{
    class Program
    {
        static double[] x;
        static void Main(string[] args)
        {
            FillXes();
            Count();

            Console.ReadKey();
        }
        static void FillXes()
        {
            int size = 6;
            x = new double[size];

            Random rnd = new Random();

            for (int i = 0;i <size; i++)
            {
                x[i] = rnd.NextDouble() * rnd.Next(-100, 100);


            }

            foreach (double n in x)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine();


        }
        static void Count()
        {
            double answer = 0;
            for (int i =0; i < x.Length; i++)
            {
                answer += (x[i] + x[x.Length - 1 - i]);
            }
            Console.WriteLine(answer);
        }
    }
}

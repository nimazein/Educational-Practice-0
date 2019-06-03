using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Task_6
{
    class Program
    {
        static int M;
        static int N;
        static List<double> a = new List<double>();
        static double[] multiplesOf3;
        static bool foundAllThreeMultiples = false;

        static void Main(string[] args)
        {
            Input();
            Solve();
            Console.ReadKey();          
        }
        private static void Input()
        {
            InputA();
            InputM();
            try
            {
                multiplesOf3 = new double[M];
            }
            catch (Exception)
            {
                Console.WriteLine("Переполнение памяти");
                Thread.Sleep(3000);
                Environment.Exit(0);
            }   
            InputN();

            void InputA()
            {
                Console.Write("a1 = ");
                a.Add(Convert.ToDouble(Console.ReadLine()));

                Console.Write("a2 = ");
                a.Add(Convert.ToDouble(Console.ReadLine()));

                Console.Write("a3 = ");
                a.Add(Convert.ToDouble(Console.ReadLine()));
            }
            void InputM()
            {
                Console.Write("M = ");
                M = Convert.ToInt32(Console.ReadLine());
            }
            void InputN()
            {
                Console.Write("N = ");
                N = Convert.ToInt32(Console.ReadLine());
            }
        }
        private static void Solve()
        {
            int m = 0;
            for (int i = 3; i < N; i++)
            {
                try
                {
                    a.Add(2 * Math.Abs(a[i - 1] - a[i - 2]) + a[i - 3]);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    OutputSeries();
                }

                if (a[i] % 3 == 0 && a[i] != 0)
                {
                    multiplesOf3[m] = a[i];

                    if (m != M - 1)
                        m++;
                    else
                    {
                        foundAllThreeMultiples = true;
                        Console.Write("Первые M чисел, кратные 3: ");
                        foreach (double el in multiplesOf3)
                        {
                            Console.Write(el.ToString() + " ");
                        }
                        break;
                    }
                }
            }

            if (foundAllThreeMultiples)
            {
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Найдены первые N членов");
                OutputSeries();
            }
        }
        private static void OutputSeries()
        {
            foreach (double el in a)
            {
                Console.Write(el + " ");
            }


        }
    }
}

using System;
using System.Text;

namespace Task_10
{
    class Program
    {
        static double[] x;
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            FillXes();
            Count();

            Console.ReadKey();
        }
        static void FillXes()
        {
            uint size;
            bool ok = false;
            do
            {
                Console.Write("n = ");
                string buf = Console.ReadLine();
                ok = UInt32.TryParse(buf, out size);
                if (!ok)
                    Console.WriteLine("Неверный ввод n");

                if (size == 0)
                {
                    Console.WriteLine("Невозможно вычислить значение выражения");
                    ok = false;
                }                 
            } while (!ok);

            x = new double[size];
            for (int i = 0; i < size; i++)
            {                       
                do
                {
                    Console.Write($"x{i + 1} = ");
                    string buf = Console.ReadLine();
                    ok = Double.TryParse(buf, out x[i]);
                    if (!ok)
                        Console.WriteLine("Неверный ввод x");  
                    
                } while (!ok);
            }
            Console.WriteLine();
        }
        static void Count()
        {
            double answer = 1;
            for (int i = 0; i < x.Length; i++)
            {
                answer *= (x[i] + x[x.Length - 1 - i]);
            }
            Console.WriteLine($"Значение выражения: {answer}");
        }
    }
}

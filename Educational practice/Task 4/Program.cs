using System;
using System.Numerics;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger value = CountValue();
            OutputValue(value);
            OutputSeries(value);
            Console.ReadKey();
        }
        private static BigInteger CountValue()
        {
            BigInteger bigInteger = new BigInteger();
            bigInteger = 2;
            for (int i = 0; i < 200; i++)
            {
                bigInteger *= 2;
            }

            return bigInteger;
        }
        private static void OutputValue(BigInteger value)
        {
            string s = value.ToString();

            for (int i = 0; i < s.Length; i++)
            {
                Console.Write(s[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
        }
        private static void OutputSeries(BigInteger value)
        {
            string s = value.ToString();

            Console.Write(s[0] + $"*10^{s.Length - 1} ");
            for (int i = 0; i < s.Length; i++)
            {
                Console.Write("+ " + s[i] + $"*10^{s.Length - (i + 1)} ");
            }
            Console.WriteLine("= 2^200");
        }
    }
}

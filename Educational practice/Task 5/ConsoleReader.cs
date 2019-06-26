using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    class ConsoleReader : IReader
    {
        public int ReadN()
        {
            int n = -1;
            Console.Write("n = ");
            try
            {
                n = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Ошибка ввода");
            }
            return n;
        }
    }
}

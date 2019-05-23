using System;

namespace Task_5
{
    class ConsolePrinter : IPrinter
    {
        public void Print(double maxNumber)
        {
            Console.WriteLine("{0:#.##}",maxNumber);
        }    
    }
}
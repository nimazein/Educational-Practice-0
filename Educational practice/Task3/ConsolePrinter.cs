using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class ConsolePrinter : IPrinter
    {
        public void Print(bool inShadedArea)
        {
            Console.WriteLine(inShadedArea);
        }
        public void Print(Point p)
        {
            Console.WriteLine($"({p.X} ; {p.Y})");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            PointCreator pointCreator = new PointCreator();
            Checker checker = new Checker();
            ConsolePrinter printer = new ConsolePrinter();

            Point point = pointCreator.CreatePoint();
            printer.Print(point);
            printer.Print(checker.InShadedArea(point));

        }
    }
}

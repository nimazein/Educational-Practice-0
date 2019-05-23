using System;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            PointCreator pointCreator = new PointCreator();
            Solver solver = new Solver();
            ConsolePrinter printer = new ConsolePrinter();

            Point point = pointCreator.CreatePoint();
            point.OutputCoordinates(printer);

            solver.InShadedArea(point);
            solver.OutputAnswer(printer);         
        }
    }
}

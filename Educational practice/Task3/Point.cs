using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Point
    {
        private double x;
        private double y;

        public double X
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }         
        }
        public double Y
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }
        }
        public Point()
        {

        }
        public Point (double[] coordinates)
        {
            X = coordinates[0];
            Y = coordinates[1];
        }
        public void OutputCoordinates(IPrinter printer)
        {
            printer.Print(this);
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class PointCreator
    {
        private const int NUMBER_OF_DIMENSIONS = 2;
        private double[] coordinates = new double[NUMBER_OF_DIMENSIONS];
        public Point CreatePoint()
        {
            Console.OutputEncoding = Encoding.UTF8;
            for (int i = 0; i < NUMBER_OF_DIMENSIONS; i++)
            {
                Console.Write($"Координата {i+1}: ");
                double coordinate = Convert.ToDouble(Console.ReadLine());
                coordinates[i] = Math.Round(coordinate, 2);
            }
            return new Point(coordinates);
        }
        
    }
}

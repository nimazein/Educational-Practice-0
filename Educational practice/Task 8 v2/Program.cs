using System;
using System.Collections.Generic;

namespace Task_8_v2
{
    class Program
    {
        static byte[,] incidentMatrix;
        static int K = 3;

        static List<Point> points = new List<Point>();

        static void Main(string[] args)
        {
            FillMatrix();

            for (int row = 0; row < incidentMatrix.GetLength(0); row++)
            {
                for (int column = 0; column < incidentMatrix.GetLength(0); column++)
                {
                    if (incidentMatrix[column, row] == 1)
                    {
                        Point point = new Point(column, row);
                        points.Add(point);
                    }
                }
            }

        }



        static void GG()
        {
            for (int row = 0; row < K; row++)
            {
                for (int column = 0; column < K; column++)
                {
                    if (incidentMatrix[column, row] == 1)
                    {
                        Point point = new Point(column, row);
                        points.Add(point);
                    }
                }
            }
            if (points.Count % 2 == 0)
            {
                int numberOfpares = 0;
                for (int i = 0; i < points.Count; i++)
                {
                    Point point = points[i];
                    foreach (Point p in points)
                    {
                        if (point.X == p.Y && point.Y == p.X)
                        {
                            numberOfpares++;
                        }
                    }
                }

                if (numberOfpares == points.Count / 2)
                {
                    // klika was found
                }
            }
            else
            {
                // no klika
            }
        }




        //public void ViaClass()
        //{
        //    Point[,] matrixOfPoint = new Point[6, 6];

        //    // переписать из матрицы
        //    int size = 6;

        //    for (int yStart = 0; yStart < size - K - 1; yStart++)
        //    {
        //        for (int xStart = 0; xStart < size - K - 1; xStart++)
        //        {
        //            for (int row = yStart; row < size; row++)
        //            {
        //                for (int col = xStart; col < size; col++)
        //                {

        //                }
        //            }
        //        }
        //    }



        //}


        public void UsingClasses()
        {
            int size = 6;

            for (int row = 0; row < size; row++)
            {
                int unitsInLine = 0;
                Incidents incidents = new Incidents(row);
                for (int col = row; col < size; col++)
                {                  
                    if (incidentMatrix[row,col] == 1)
                    {                       
                        unitsInLine++;
                        Point point = new Point(col, row);

                        incidents.Add(col);
                    }
                }
            }
           
        }


















        static void FillMatrix()
        {
            Random rnd = new Random();
            int size = 6;
            incidentMatrix = new byte[size, size];

            for (int j = 0; j < size; j++)
            {
                for (int i = 0; i < size; i++)
                {
                    incidentMatrix[i, j] = Convert.ToByte(rnd.Next(0, 2));
                }
            }
            OutputMatrix();

        }
        static void OutputMatrix()
        {
            for (int j = 0; j < incidentMatrix.GetLength(0); j++)
            {
                for (int i = 0; i < incidentMatrix.GetLength(0); i++)
                {
                    Console.Write(incidentMatrix[i, j] + " ");
                }
                Console.WriteLine();

            }
        }
    }
}

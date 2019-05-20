﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Checker
    {
        public bool InShadedArea(Point point)
        {
            bool inShadedArea = false;
            if (InHalfCircle(point))
            {
                if (!InEmptyQuarter(point))
                {
                    inShadedArea = true;
                }
            }
            return inShadedArea;
        }
        private bool InHalfCircle(Point p)
        {
            bool inHalfCircle = false;
            if ((p.Y <= Math.Sqrt(1 - p.X * p.X)) && (p.Y >= 0))
            {
                inHalfCircle = true;
            }
            return inHalfCircle;
        }
        private bool InEmptyQuarter(Point p)
        {
            bool inEmptyQuarter = false;
            if ((p.Y <= Math.Sqrt(0.09 - p.X*p.X)) && (p.X >= 0))
            {
                inEmptyQuarter = true;
            }
            return inEmptyQuarter;
        }
    }
}

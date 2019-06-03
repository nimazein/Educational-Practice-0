using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_7
{
    class Node
    {
        public Node Left { get; set; }
        public Node Right { get; set; }

        public string Key { get; set; }
        public double Frequency { get; set; }
        public Node(double frequency)
        {
            Left = null;
            Right = null;
            Frequency = frequency;
        }

        public Node(Node left, Node right)
        {
            Left = left;
            Right = right;
            Frequency = left.Frequency + right.Frequency;
        }
    }
}

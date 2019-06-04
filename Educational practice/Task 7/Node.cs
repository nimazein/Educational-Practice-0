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
        public Node Parent { get; set; }

        public string Code { get; set; }
        public double Frequency { get; }
        public Node()
        {
            Parent = null;
            Left = null;
            Right = null;
            Frequency = 1;
            Code = null;
        }
        public Node(double frequency)
        {
            Parent = null;
            Left = null;
            Right = null;
            Frequency = frequency;
            Code = null;
        }

        public Node(Node left, Node right)
        {
            Left = left;
            Right = right;
            Code = null;
            Frequency = left.Frequency + right.Frequency;
        }
    }
}

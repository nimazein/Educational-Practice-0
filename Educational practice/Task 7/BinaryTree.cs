using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_7
{
    class BinaryTree
    {
        public Node Head { get; set; }
        public void Add(double frequency)
        {
            if (Head == null)
            {
                Head = new Node(frequency);
            }
        }
    }
}

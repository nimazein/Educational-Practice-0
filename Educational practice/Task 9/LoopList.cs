using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_9
{
    class LoopList
    {
        Node head;
        Node tail;

        int count;

        public int Count
        {
            get
            {
                return count;
            }
        }
        public bool IsEmpty
        {
            get
            {
                return count == 0;
            }
        }


        public void Add(int data)
        {
            Node node = new Node(data);

            if (head == null)
            {
                head = node;
                tail = node;
                tail.Next = head;
            }
            else
            {
                node.Next = head;
                tail.Next = node;
                tail = node;
            }
            count++;
        }
        public void GoThrough()
        {
            if (IsEmpty)
            {
                Console.WriteLine("Список пуст");
            }
            else if (count == 1)
            {
                Console.WriteLine(head.ToString());
            }
            else
            {               
                Node current = head;
                do
                {
                    Console.WriteLine(current.ToString());
                    if (current.Next != null)
                        current = current.Next;
                } while (current != head);
            }
            

        }
        public void PositiveSum()
        {
            if (count == 1)
            {
                if (head.Data >= 0)
                {
                    OutputSum("Positive", head.Data);
                }
                else
                {
                    Console.WriteLine("no positive");
                }
            }
            else
            {
                int positiveSum = 0;
                Node current = head;
                do
                {
                    if (current.Data > 0)
                    {
                        positiveSum += current.Data;
                    }
                    if (current.Next != null)
                        current = current.Next;
                } while (current != head);

                OutputSum("Positive", positiveSum);
            }
        }
        public void NegativeSum()
        {
            if (count == 1)
            {
                if (head.Data < 0)
                {
                    OutputSum("Negative", head.Data);
                }
                else
                {
                    Console.WriteLine("no negative");
                }
            }
            else
            {
                int negativeSum = 0;
                Node current = head;
                do
                {
                    if (current.Data < 0)
                    {
                        negativeSum += current.Data;
                    }
                    if (current.Next != null)
                        current = current.Next;
                } while (current != head);

                OutputSum("Negative", negativeSum);
            }
        }
        public void OutputSum(string type, int sum)
        {
            Console.WriteLine($"{type} sum: {sum}");
        }


        

        
    }
}

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
                    OutputSum("Положительная", head.Data);
                }
                else
                {
                    Console.WriteLine("В списке нет положительных элементов");
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

                OutputSum("Положительная", positiveSum);
            }
        }
        public void NegativeSum()
        {
            if (count == 1)
            {
                if (head.Data < 0)
                {
                    OutputSum("Отрицательная", head.Data);
                }
                else
                {
                    Console.WriteLine("В списке нет отрицательных элементов");
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

                if (negativeSum == 0)
                {
                    Console.WriteLine("В списке нет отрицательных элементов");
                }
                else
                {
                    OutputSum("Отрицательная", negativeSum);
                }
                
            }
        }
        public void OutputSum(string type, int sum)
        {
            Console.WriteLine($"{type} сумма: {sum}");
        }
    }
}

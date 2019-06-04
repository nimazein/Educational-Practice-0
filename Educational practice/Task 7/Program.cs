using System;
using System.Collections.Generic;
using System.Threading;


namespace Task_7
{
    class Program
    {
        static List<double> frequencies = new List<double>();
        static List<Node> nodes = new List<Node>();
        static Dictionary<string, double> codes = new Dictionary<string, double>();
        static void Main(string[] args)
        {
            InputFrequencies();
            FillNodes();
            FillCodes();
            PrintCodesAndFrequencies();
            Console.ReadKey();
        }
        private static void InputFrequencies()
        {
            
            frequencies.Add(0.25);
            frequencies.Add(0.25);
            frequencies.Add(0.25);
            frequencies.Add(0.25);


            if (frequencies.Count == 1)
            {
                if (frequencies[0] == 1)
                {
                    Console.WriteLine("0 => 1");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
            }
            frequencies.Sort();
        }
        private static void FillNodes()
        {
            
            while (frequencies.Count != 1)
            {
                Node smallest = new Node(frequencies[0]);
                Node semiSmallest = new Node(frequencies[1]);

                foreach (var el in nodes)
                {
                    if (el.Frequency == frequencies[0])
                    {
                        smallest = el;
                        break;
                    }
                    else
                    {
                        smallest = new Node(frequencies[0]);
                    }
                }
                foreach (var el in nodes)
                {
                    if (el.Frequency == frequencies[1])
                    {
                        semiSmallest = el;
                        break;
                    }
                    else
                    {
                        semiSmallest = new Node(frequencies[1]);
                    }
                }
                Node node = new Node(smallest, semiSmallest);

                smallest.Parent = node;
                semiSmallest.Parent = node;

                frequencies.RemoveAt(1);
                frequencies.RemoveAt(0);
                frequencies.Add(node.Frequency);
                nodes.Add(node);

                frequencies.Sort();
            }          
        }
        private static void FillCodes()
        {
            Node root = nodes[nodes.Count - 1];
            string  cod = "0";
            AddCode(root, ref cod);
        }
       
        private static void AddCode(Node node, ref string cod)
        {
            if (node != null)
            {              
                if (node.Parent != null && node.Code == null)
                {
                    node.Code = cod;
                    node.Code += node.Parent.Code;
                }      
                cod = "0";
                AddCode(node.Left, ref cod);
                cod = "1";
                AddCode(node.Right, ref cod);
            }
        }
        private static void PrintCodesAndFrequencies()
        {
            PrintRecursively(nodes[nodes.Count - 1]);
        }
        private static void PrintRecursively(Node node)
        {
            if (node != null)
            {
                PrintRecursively(node.Left);
                if (node.Left == null && node.Right == null)
                {
                    string reversedCode = ReverseCode(node);
                    if (reversedCode != null)
                        Console.WriteLine(reversedCode + " => " + node.Frequency);
                }
                
                PrintRecursively(node.Right);
            }
        }     
        private static string ReverseCode(Node node)
        {
            if (node.Code != null)
            {
                char[] array = node.Code.ToCharArray();
                Array.Reverse(array);
                return new string(array);
            }
            return null;           
        }
    }
}

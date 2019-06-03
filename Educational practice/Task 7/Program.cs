using System;
using System.Collections.Generic;
using System.Text;

namespace Task_7
{
    class Program
    {
        static List<double> frequencies = new List<double>();
        static StringBuilder code = new StringBuilder();
        static Dictionary<string, string> codes = new Dictionary<string, string>();
        static void Main(string[] args)
        {
            InputFrequencies();
            G();
            OutputInfo();
        }
        private static void InputFrequencies()
        {
            frequencies.Add(0.08);
            frequencies.Add(0.12);
            frequencies.Add(0.1);
            frequencies.Add(0.25);
            frequencies.Add(0.15);
            frequencies.Add(0.3);
            frequencies.Sort();
        }
        private static void G()
        {
            while (frequencies.Count != 1)
            {
                Node smallest = new Node(frequencies[0]);
                Node semiSmallest = new Node(frequencies[1]);

                Node node = new Node(smallest, semiSmallest);

                frequencies.Remove(0);
                frequencies.Remove(1);

                frequencies.Sort();
            }
            Node root = new Node(frequencies[0]);
            Code(root);
        }
        private static void Code(Node root)
        {
            if (root.Left != null)
            {
                code.Append(0);
                Code(root.Left);
            }

            if (root.Right != null)
            {
                code.Append(1);
                Code(root.Right);
            }

            if (root.Left == null && root.Right == null)
            {
                if (code.Length == 0)
                {
                    code.Append(0);
                }
                codes.Add(root.Key, code.ToString());
            }
            try
            {
                code.Remove(code.Length - 1, 1);
            }
            catch (Exception)
            {

            }
        }
        private static void OutputInfo()
        {
            foreach(var el in codes)
            {
                Console.WriteLine(el.Value);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;

namespace Task_2
{
    class Program
    {

        static string[] multipliers = new string[] { "", "D", "T" };
        static List<string> answer = new List<string>();
        static void Main(string[] args)
        {
            FileStream input = new FileStream("INPUT.txt", FileMode.Open);
            StreamReader reader = new StreamReader(input);

            string inputStr = reader.ReadToEnd();
            int n = Convert.ToInt32(inputStr);
            reader.Close();
            input.Close();

            Solve(0, n, "");

            FileStream output = new FileStream("OUTPUT.txt", FileMode.OpenOrCreate);
            StreamWriter writer = new StreamWriter(output);

            writer.WriteLine(answer.Count);
            foreach (string el in answer)
            {
                writer.WriteLine(el);
            }
            writer.Close();
            output.Close();
        }  
        static void Solve(int x, int left, string current)
        {
            if (left == 0)
            {
                answer.Add(current);
            }
            if (x == 3)
            {
                return;
            }
            for (int i = 1; i <= 20; i++)
            {
                for (int j = 1; j <= 3; j++)
                {
                    if (i * j < left || (i * j == left && j == 2))
                    {                       
                        Solve(x + 1, left - i * j, current + multipliers[j-1] + i + " ");
                    }
                }
            }

            if (left > 25)
            {
                Solve(x + 1, left - 25, current + "25 ");
            }
            if (left > 25)
            {
                Solve(x + 1, left - 50, current + "Bull ");
            }
        }
    }
}

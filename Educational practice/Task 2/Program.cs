using System;
using System.Collections.Generic;
using System.IO;

namespace Task_2
{
    class Program
    {
        static int n;
        static StreamWriter writer;
        static List<List<string>> answer;
        static void Main(string[] args)
        {
            GetN();
            initializeList();
            GetStreamWriter();
            Solve();
            CloseStreams();

        }
        private static void GetN()
        {
            FileStream input = new FileStream("input.txt", FileMode.Open);
            StreamReader reader = new StreamReader(input);

            string inputStr = reader.ReadToEnd();
            n = Convert.ToInt32(inputStr);
            reader.Close();
            input.Close();
        }
        private static void GetStreamWriter()
        {
            FileStream output = new FileStream("output.txt", FileMode.OpenOrCreate);
            writer = new StreamWriter(output);
        }
        private static void initializeList()
        {
            answer = new List<List<string>>();

            for (int i = 0; i < 10; i++)
            {
                answer.Add(new List<string>());
            }
        }
        private static void Solve()
        {
            if (n > 170)
            {
                writer.WriteLine("Невозможно");
                return;
            }
            else if (n == 170)
            {
                writer.Write("T20 T20 Bull");
                return;
            }
            else
            {
                while (n > 61)
                {
                    n -= 60;
                    answer[0].Add("T20");
                }

                if (n <= 40)
                {
                    if (n % 2 == 0)
                    {
                        ("D" + n / 2 + "\n");
                    }
                    else
                    {
                        output.Append(1 + "\n");
                        n -= 1;
                        output.Append("D" + n / 2 + "\n");
                    }
                }
                else
                {
                    output.Append(n - 40 + "\n");
                    n = 40;
                    output.Append("D" + n / 2 + "\n");
                }

            }

            for (int i = 0; i < answer.Count; i++)
            {
                for (int j = 0; j < answer[i].Count; j++)
                {
                    writer.Write(answer[i][j] + " ");
                }
                writer.WriteLine("");
            }
        }
        private static void CloseStreams()
        {
            writer.Close();
        }
    }
}

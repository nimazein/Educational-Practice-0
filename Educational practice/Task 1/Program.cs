using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_v2
{
    class Program
    {
        static StreamReader reader = new StreamReader("INPUT.TXT");
        static void Main(string[] args)
        {
            int numberOfIngredients = Convert.ToInt32(reader.ReadLine());
            double[] percentages = new double[numberOfIngredients];

            double sumMass = 0;
            int savedPercent = 0;
            bool[] good = new bool[numberOfIngredients];
            bool[] bad = new bool[numberOfIngredients];

            for (int i = 0; i < numberOfIngredients; i++)
            {
                string currentLine = reader.ReadLine();
                good[i] = (currentLine[0] == '+');

                int substringLength = currentLine.Length - 2;
                percentages[i] = Convert.ToInt32(currentLine.Substring(2, substringLength));
                sumMass += percentages[i];
            }

            for (int i = 0; i < numberOfIngredients; i++)
            {
                percentages[i] = 100 * percentages[i] / sumMass;
                bad[i] = !(percentages[i] > Math.Floor(percentages[i]));
                savedPercent += Convert.ToInt32(Math.Floor(percentages[i]));
            }

            int[] additionalValue = new int[numberOfIngredients];
            savedPercent = 100 - savedPercent;

            for (int j = 0; j < 2; j++)
            {
                for (int i = 0; i < numberOfIngredients; i++)
                {
                    if (bad[i] || good[i] ^ (j == 0))
                        continue;
                    if (--savedPercent < 0)
                        break;
                    additionalValue[i] = 1;

                }
            }

            sumMass = 0;
            for (int i = 0; i < numberOfIngredients; i++)
            {
                percentages[i] = (Math.Floor(percentages[i]) + additionalValue[i]);
                sumMass += percentages[i];
            }

            if (sumMass != 100)
            {
                Console.WriteLine("Error");
                Console.ReadKey();
            }

            OutputAnswer(percentages);
        }
        private static void OutputAnswer(double[] percentages)
        {
            using (System.IO.StreamWriter file =
                new System.IO.StreamWriter("OUTPUT.txt"))
            {
                foreach (double percentage in percentages)
                {
                    file.WriteLine(percentage.ToString());
                }
            }
        }
    }
}

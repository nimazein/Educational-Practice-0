using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {
        static StreamReader reader = new StreamReader("INPUT.TXT");
        static int[] masses;
        static char[] signs;
        static double[] percentages;

        static void Main(string[] args)
        {
            FillMassesAndSigns();
            int productMass = CountProductMass();
            FillPercentages(productMass);
            RoundPercentages();
            OutputAnswer();
        }
        private static void FillMassesAndSigns()
        {
            int numberOfIngredients = Convert.ToInt32(reader.ReadLine());

            masses = new int[numberOfIngredients];
            signs = new char[numberOfIngredients];

            for (int i = 0; i < numberOfIngredients; i++)
            {
                InsertElement(i);
            }
        }
        private static void InsertElement(int i)
        {
            string currentLine = reader.ReadLine();

            char sign = currentLine[0];
            signs[i] = sign;

            int substringLength = currentLine.Length - 2;
            int mass = Convert.ToInt32(currentLine.Substring(2, substringLength));
            masses[i] = mass;
        }
        private static int CountProductMass()
        {
            int productMass = 0;
            foreach (int ingredientMass in masses)
            {
                productMass += ingredientMass;
            }
            return productMass;
        }
        private static void FillPercentages(int productMass)
        {
            int numberOfIngredients = masses.Length;
            percentages = new double[numberOfIngredients];

            for (int i = 0; i < numberOfIngredients; i++)
            {
                double ingredientMass = Convert.ToDouble(masses[i]);
                double percentage = (ingredientMass / Convert.ToDouble(productMass)) * 100;

                percentages[i] = percentage;
            }
        }
        private static void RoundPercentages()
        {
            int numberOfIngredients = masses.Length;
            int percentagesSum = 0;

            for (int i = 0;i < percentages.Length; i++)
            {
                percentages[i] = Math.Floor(percentages[i]);
            }

            for (int i = 0; i < numberOfIngredients; i++)
            {
                if (percentagesSum == 100)
                    break;

                percentagesSum = 0;
                foreach (int percentage in percentages)
                {
                    percentagesSum += percentage;
                }

                if (percentagesSum < 100)
                {
                    if (signs[i] == '+')
                    {
                        percentages[i] = Convert.ToInt32(Math.Ceiling(percentages[i]));
                    }
                }
            }

            for (int i = 1; i < numberOfIngredients; i++)
            {
                if (percentagesSum == 100)
                    break;

                percentagesSum = 0;
                foreach (int percentage in percentages)
                {
                    percentagesSum += percentage;
                }

                if (percentagesSum < 100)
                {
                    percentages[i]++;              
                }
            }
        }
        private static void OutputAnswer()
        {
            using (System.IO.StreamWriter file =
                new System.IO.StreamWriter("OUTPUT.txt"))
            {
                foreach (int percentage in percentages)
                {
                     file.WriteLine(percentage.ToString());
                }
            }
        }
    }
}

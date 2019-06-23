using System;
using System.IO;

namespace Task_1
{
    class Program
    {
        static StreamReader reader = new StreamReader("INPUT.TXT");
        static int[] masses;
        static char[] signs;
        static double[] percentages;
        static int[] newPercentages;

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
            newPercentages = new int[masses.Length];
            // Using Math rules
            for (int i =0; i < masses.Length; i++)
            {
                if (signs[i] == '+')
                {
                    newPercentages[i] = Convert.ToInt32(Math.Ceiling(percentages[i]));
                }
                else
                {   
                    newPercentages[i] = Convert.ToInt32(Math.Floor(percentages[i]));
                }
            }

            // To meet conditions
            int sum = CountSum(); 
            int k = 0;
            while (sum != 100)
            {
                if (k == percentages.Length)
                    k = 0;

                if (sum > 100)
                {
                    if (signs[k] == '+')
                    {
                        newPercentages[k]--;
                    }
                }
                else
                {
                    if (signs[k] == '-')
                    {
                        newPercentages[k]++;
                    }
                }

                sum = CountSum();
                k++;
            }
        }
        private static void OutputAnswer()
        {
            using (System.IO.StreamWriter file =
                new System.IO.StreamWriter("OUTPUT.txt"))
            {
                foreach (int percentage in newPercentages)
                {
                    file.WriteLine(percentage.ToString());
                }
            }
        }
        private static int CountSum()
        {
            int sum = 0;
            foreach (int el in newPercentages)
            {
                sum += el;
            }
            return sum;
        }
    }
}

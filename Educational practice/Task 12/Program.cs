using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_12
{
    class Program
    {
        static int N;
        static int[] array;
        static Random rnd = new Random();

        static List<Result> results = new List<Result>();

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            FillArray();
            ReadKeyAndClear();

            Console.WriteLine("Пирамидная сортировка");
            SortPyramidly();
            ReadKeyAndClear();

            Console.WriteLine("Сортировка подсчетом");
            SortByCounting();
            ReadKeyAndClear();
            // Можно добавить вывод
            Console.ReadKey();

        }
       static void FillArray()
        {           
            Console.Write("Введите N: ");
            N = Convert.ToInt32(Console.ReadLine());

            array = new int[N];

            int firstIndex = 0;
            if (N > 3)
            {
                array[0] = rnd.Next(-100, 0);
                array[1] = rnd.Next(1, 10);
                array[2] = rnd.Next(-100, -2);

                firstIndex = 3;
            }

            FillRandomly(firstIndex);
            Console.WriteLine("Массив заполнен");

        }
        static void FillRandomly(int firstIndex)
        {
            for (int i = firstIndex; i < N; i++)
            {
                array[i] = rnd.Next(-100, 100);
            }
        }
        static void ReadKeyAndClear()
        {
            Console.ReadKey();
            Console.Clear();
        }


        // Pyramid sorting
        static void SortPyramidly()
        {
            SortUnsortedPyramidly();
            ReadKeyAndClear();

            SortAscendingPyramidly();
            ReadKeyAndClear();
            SortDescendingPyramidly();
        }
        static void SortUnsortedPyramidly()
        {
            Console.WriteLine("Неотсортированный массив");
            PrintArray();

            PyramidSorting pyramidSorting = new PyramidSorting();
            pyramidSorting.Sort(array, N);

            Console.WriteLine("Сортированный массив");
            PrintArray();
            Console.WriteLine($"Сравнений: {pyramidSorting.Counter}");

            SaveResult("Пирамидальная сортировка", "Несортированный масссив", pyramidSorting.Counter);

                       
        }
        static void SortAscendingPyramidly()
        {
            PyramidSorting pyramidSorting = new PyramidSorting();

            Console.WriteLine("Уже сортированный по возрастанию массив");
            PrintArray();

            pyramidSorting.Sort(array, N);
            Console.WriteLine("Массив был снова отсортирован");
            Console.WriteLine($"Сравнений: {pyramidSorting.Counter}");

            SaveResult("Пирамидальная сортировка", "Сортированный по возрастанию масссив", pyramidSorting.Counter);
        }
        static void SortDescendingPyramidly()
        {
            PyramidSorting pyramidSorting = new PyramidSorting();

            Console.WriteLine("Сортированный по убыванию массив");
            Array.Reverse(array);
            PrintArray();

            Console.WriteLine("Массив после сортировки");
            pyramidSorting.Sort(array, N);
            PrintArray();
            Console.WriteLine($"Сравнений: {pyramidSorting.Counter}");

            SaveResult("Пирамидальная сортировка", "Сортированный по убыванию масссив", pyramidSorting.Counter);
        }

       

        //Counting sorting
        static void SortByCounting()
        {            
            FIllArrayWithSmallNumbers();
            SortUnsortedByCounting();
            ReadKeyAndClear();

            SortAscendingByCounting();
            ReadKeyAndClear();
            SortDescendingByCounting();
        }
        static void FIllArrayWithSmallNumbers()
        {
            array = new int[N];
            for (int i = 0; i < N; i++)
            {
                array[i] = rnd.Next(1, 5);
            }
        }
        static void SortUnsortedByCounting()
        {
            CountSort countSort = new CountSort();
            Console.WriteLine("Несортированный массив");
            PrintArray();

            Console.WriteLine("Сортированный массив");
            array = countSort.Sort(array);
            PrintArray();

            Console.WriteLine($"Сравнений: {countSort.Counter}");
            SaveResult("Сортировка подсчетом", "Несортированный массив", countSort.Counter);
        }
        static void SortAscendingByCounting()
        {
            CountSort countSort = new CountSort();

            Console.WriteLine("Cортированный по возрастанию массив");
            Array.Reverse(array);
            PrintArray();

            Console.WriteLine("Сортированный массив");
            array = countSort.Sort(array);
            PrintArray();

            Console.WriteLine($"Сравнений: {countSort.Counter}");
            SaveResult("Сортировка подсчетом", "Cортированный по возрастанию массив", countSort.Counter);
        }
        static void SortDescendingByCounting()
        {
            CountSort countSort = new CountSort();
            
            Console.WriteLine("Уже cортированный по убыванию массив");
            PrintArray();

            array = countSort.Sort(array);

            Console.WriteLine($"Сравнений: {countSort.Counter}");
            SaveResult("Сортировка подсчетом", "Cортированный по убыванию массив", countSort.Counter);
        }

        // Supporting Methods
        static void PrintArray()
        {
            foreach (int el in array)
            {
                Console.WriteLine(el);
            }
            Console.ReadKey();
        }
        static void SaveResult(string sortingType, string arrayType, int comparisons)
        {
            Result result = new Result(sortingType, arrayType, comparisons);
            results.Add(result);
        }
    }
}

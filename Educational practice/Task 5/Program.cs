namespace Task_5
{
    class Program
    {
        static Matrix matrix = new Matrix();
        static ConsoleReader reader = new ConsoleReader();
        static ConsolePrinter printer = new ConsolePrinter();
        static void Main(string[] args)
        {          
            matrix.CreateMatrix(reader);
            matrix.FillMatrixRandomly();
            matrix.OutputMatrix(printer);

            matrix.FindMaxNumber();         
            matrix.PrintMaxNumber(printer);
        }
    }
}








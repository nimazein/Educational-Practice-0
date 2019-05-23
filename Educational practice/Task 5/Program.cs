namespace Task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Matrix matrix = new Matrix();
            matrix.CreateMatrix();
            matrix.FillMatrixRandomly();
            matrix.OutputMatrix();
            matrix.FindMaxNumber();

            ConsolePrinter printer = new ConsolePrinter();
            matrix.PrintMaxNumber(printer);
        }
    }
}

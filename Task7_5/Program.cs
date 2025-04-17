namespace Task7_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int res1 = Mult(2, 3);
            Console.WriteLine(res1);
            double res2 = Mult(2.5, 3.5);
            Console.WriteLine(res2);
            Console.ReadKey();
        }

        static int Mult(int number1, int number2)
        {
            return number1 * number2;
        }
        static double Mult(double number1, double number2)
        {
            return number1 * number2;
        }
    }
}

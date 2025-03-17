namespace Task4_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());// кол-во цифр в цисле
            int k = 0;
            while (n > 0)
            {
                k++;
                n /=10;
                
            }
            Console.WriteLine("кол-во цифр" + k);
            Console.ReadKey();
        }

    }
}

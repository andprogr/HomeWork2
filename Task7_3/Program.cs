namespace Task7_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            ///bool reverse = false;
            //Console.WriteLine("Обычный");
            PrintNumbers(numbers);
            //Console.WriteLine("Обратный");
            PrintNumbers(numbers, true);
            Console.ReadKey();


            
        }
        static void PrintNumbers(int[] numbers, bool reverse=false)
        {
            if (!reverse)
            {
                foreach (int element in numbers)
                Console.WriteLine($"{element}");
                Console.ReadKey();
            }
            else
            {
                    for (int i=numbers.Length-1;i>=0; i--)
                    Console.WriteLine($"{numbers[i]}");
            }
                
        
        }
    }
}

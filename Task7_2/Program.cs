namespace Task7_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double edLenght = 5;
            double volume;
            double surfArea;

            CalculateCube(edLenght, out volume, out surfArea);

            Console.WriteLine($"Объем куба: {volume}");
            Console.WriteLine($"Площадь поверхности куба: {surfArea}");
            Console.ReadKey();
        }

            static void CalculateCube(double edLenght, out double volume, out double surfArea)
            {
                
                volume = Math.Pow(edLenght,3);
                surfArea = 6 * Math.Pow(edLenght, 2);

            }
        
    }
}

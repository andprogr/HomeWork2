namespace Task8_2
{
    internal class Program
    {
        static void Main()
        {
            try
            {
                Console.WriteLine("Введите возраст");
                int a = Convert.ToInt32(Console.ReadLine());
                ValidateAge(a);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Ошибка ввода: {ex.Message}");
            }
            catch (FormatException)
            {
                Console.WriteLine($"Введено не число");
            }
            finally
            {
                Console.WriteLine($"Данные введены");
                Console.ReadLine();
            }
            static void ValidateAge(int a)
            {
                if (a < 0)
                    throw new ArgumentException($"Возраст не может быть отрицательным");
                if (a > 150)
                    throw new ArgumentException($"Возраст большой");
            }
        }

    }
}

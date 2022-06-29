using static System.Console;

namespace Task_3
{
    internal class Program
    {
        /// <summary>
        /// Проверка простого числа
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int i = 2;
            bool p = false;

            WriteLine("Введите целое число: ");
            int n = int.Parse(ReadLine());

            while (i < n)
            {
                if (n % i == 0)
                {
                    p = true;
                }
                i++;
            }

            WriteLine((p == false) ? "Число простое" : "Число составное");
            ReadKey();
        }
    }
}

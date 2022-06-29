using static System.Console;

namespace Task_1
{
    internal class Program
    {
        /// <summary>
        /// Приложение по определению чётного или нечётного числа
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            WriteLine("Введите целое число: ");

            WriteLine(int.Parse(ReadLine()) % 2 == 0 ? "чётное" : "нечётное");

            ReadKey();

        }
    }
}

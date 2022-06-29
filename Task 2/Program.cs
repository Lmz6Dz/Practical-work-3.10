using static System.Console;

namespace Task_2
{
    internal class Program
    {
        /// <summary>
        /// Программа подсчёта суммы карт в игре «21»
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            WriteLine("Здравия, сколько у Вас карт на руках: ");

            byte k = byte.Parse(ReadLine());

            int s = 0;

            for (byte i = 0; i < k; i++)
            {

                WriteLine($"Введите номинал {i + 1}-й карты: ");

                switch (ReadLine())
                {
                    case "6": s = s + 6; break;
                    case "7": s = s + 7; break;
                    case "8": s = s + 8; break;
                    case "9": s = s + 9; break;
                    case "10": s = s + 10; break;
                    case "J": s = s + 10; break;
                    case "Q": s = s + 10; break;
                    case "K": s = s + 10; break;
                    case "T": s = s + 10; break;
                    default: WriteLine("Нет такой карты"); --i; break;
                }
            }

            WriteLine($"Сумма карт: {s}");

            ReadKey();

        }
    }
}

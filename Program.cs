using System;

namespace Homework_Week_3_Lesson_23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**************************************************************");
            Console.WriteLine("Znajdź wylosowaną przez nas liczbę w najmniejszej ilości prób!");
            Console.WriteLine("**************************************************************");
            Console.WriteLine();

            int attempts = 0;

            Random random = new Random();
            var secretNumber = random.Next(0, 101);


            while (true)
            {
                Console.Write("Podaj proszę liczbę: ");
                var number = getNumber();

                if (number == secretNumber)
                {
                    attempts++;
                    break;
                }
                else if (number > secretNumber)
                {
                    Console.WriteLine("Liczba przez Ciebie podana jest za duża. Spróbuj raz jeszcze..\n");
                    attempts++;
                    continue;
                }
                else if (number < secretNumber)
                {
                    Console.WriteLine("Liczba przez Ciebie podana jest za mała. Spróbuj raz jeszcze..\n");
                    attempts++;
                    continue;
                }
            }

            ConsoleColor prevColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Magenta;
            

            Console.WriteLine($"\nGratulacje! Odgadłeś naszą wylosowaną liczbę [{secretNumber}] w {attempts} próbach.");

            Console.ForegroundColor = prevColor;

            String.isnu

            Console.ReadLine();

        }

        private static int getNumber()
        {
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out int number))
                {
                    Console.WriteLine("Podana przez Ciebie wartość nie jest liczbą. Spróbuj raz jeszcze...\n");
                    Console.Write("Podaj proszę liczbę: ");
                    continue;
                }
                else if (number < 0)
                {
                    Console.WriteLine("Podana prez Ciebie liczba musi być większa bądź równa zero! Spróbuj raz jeszcze...\n");
                    Console.Write("Podaj proszę liczbę: ");
                    continue;
                }
                else if (number > 100)
                {
                    Console.WriteLine("Podana prez Ciebie liczba musi być mniejsza bądź równa 100! Spróbuj raz jeszcze...\n");
                    Console.Write("Podaj proszę liczbę: ");
                    continue;
                }
                return number;
            }

        }
    }
}

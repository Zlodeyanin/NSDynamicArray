using System;

namespace NSDynamicArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string CommandSum = "sum";
            const string CommandExit = "exit";

            int[] numbers = new int[1];
            int index = 0;
            int sum;
            bool isWork = true;

            while (isWork)
            {
                for (int i = 0; i < numbers.Length - 1; i++)
                {
                    Console.Write(numbers[i] + " ");
                }

                Console.WriteLine();
                Console.WriteLine("Введите число: ");
                Console.WriteLine($"Введите {CommandSum} , чтобы посчитать сумму введённый чисел.");
                Console.WriteLine($"Введите {CommandExit}, чтобы завершить работу.");
                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case CommandSum:
                        sum = 0;

                        for (int i = 0; i < numbers.Length; i++)
                        {
                            sum += numbers[i];
                        }

                        Console.WriteLine($"Сумма введённых чисел: {sum}");
                        break;

                    case CommandExit:
                        isWork = false;
                        break;

                    default:
                        int number = Convert.ToInt32(userInput);
                        numbers[index] = number;
                        int[] tempNumbers = new int[numbers.Length + 1];

                        for (int i = 0; i < numbers.Length; i++)
                        {
                            tempNumbers[i] = numbers[i];
                        }

                        index++;
                        numbers = tempNumbers;
                        break;
                }

                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
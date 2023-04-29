using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_number_27
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 1, 2, 3, 4, 5 };
            int shift = 1;
            int tempNumber;
            int frontNumber;
            int step = 1;
            int lastIndexInArray = numbers.Length - 1;

            Console.WriteLine("Массив до сдвига: ");

            foreach (int number in numbers)
            {
                Console.Write($"{number},");
            }

            for (int i = 0; i < shift; i++)
            {
                tempNumber = numbers[0];

                for (int f = 0; f < numbers.Length; f++)
                {
                    frontNumber = f + step;

                    if (frontNumber <= lastIndexInArray)
                    {
                        numbers[f] = numbers[frontNumber];
                    }
                }

                numbers[lastIndexInArray] = tempNumber;
            }

            Console.WriteLine("\nМассив после сдвига: ");

            foreach (int number in numbers)
            {
                Console.Write($"{number},");
            }
        }
    }
}

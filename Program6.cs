using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int arraySise = 10;
            int[] numbersArray = new int[arraySise];
            int randomMin = 0;
            int randomMax = 9;
            Random random = new Random();
            int maxNumber = int.MinValue;
            int minNumber = int.MaxValue;

            for (int i = 0; i < numbersArray.Length; i++)
            {
                numbersArray[i] = random.Next(randomMin, randomMax);
                Console.Write(numbersArray[i] + " ");
            }

            Console.WriteLine("- массив");
            // В данном случае можно сделать сортировку через переменные randomMin и randomMax.
            // Но предположим, что нам неизветны максимальное и минимальное значения чисел в массиве: 

            for (int i = 0; i < numbersArray.Length; i++)
            {
                if (numbersArray[i] > maxNumber)
                {
                    maxNumber = numbersArray[i];
                }

                if (numbersArray[i] < minNumber)
                {
                    minNumber = numbersArray[i];
                }
            }

            for (int i = minNumber; i <= maxNumber; i++) 
            {
                foreach (int number in numbersArray)
                {
                    if (number == i)
                    {
                        Console.Write(number + " ");
                    }
                }

            }          

            Console.WriteLine("- отсортированный массив ");
        }
    }
}

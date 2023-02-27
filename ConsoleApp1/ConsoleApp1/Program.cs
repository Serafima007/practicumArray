using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задача 1
            int[] array = new int[15];
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-50, 50);
                Console.WriteLine($"array[{i}]={array[i]}");
            }
            byte count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 3 == 0)
                {
                    count++;
                }
            }
            Console.WriteLine($"Количество элементов массива,кратных 3,={count}");

            Console.ReadKey();

        }
    }
}

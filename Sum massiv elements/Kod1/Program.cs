using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Kod1
{
    class Program
    {
        static void Main()
        {
            int temp;
            int sum = 0;

            Console.Write("Введите колличество элементов в массиве: ");
            int count = Convert.ToInt32(Console.ReadLine());

            int[] mas = new int[count];

            for (int i = 0; i < mas.Length; i++)
            {
                Console.Write("Введите элемент массива №{0}: ", i);
                mas[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Исходный массив:");
            for (int i = 0; i < mas.Length; i++)
            {
                Console.Write("{0} ", mas[i]);
            }

            for (int i = 0; i < mas.Length; i++)
            {
                for (int j = i + 1; j < mas.Length; j++)
                {
                    if (mas[i] > mas[j])
                    {
                        temp = mas[i];
                        mas[i] = mas[j];
                        mas[j] = temp;
                    }
                }
            }

            Console.WriteLine("\nСортированный массив:");
            for (int i = 0; i < mas.Length; i++)
            {
                Console.Write("{0} ", mas[i]);
            }

            for (int i = 0; i < mas.Length; i++)
            {
                if ((mas[i] != mas[0]) && (mas[i] != mas[mas.Length - 1]) && (mas[i] > 0))
                    sum = sum + mas[i];
            }

            Console.WriteLine("\nСумма положительных элементов, находящихся между минимальным и максимальным элементами: {0}.", sum);
        }
    }
}

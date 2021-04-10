using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Kod2
{
    class Massiv
    {
        public int count;
        public int[] mas;

        public Massiv()
        {
            Console.Write("Введите колличество элементов в массиве: ");
            count = Convert.ToInt32(Console.ReadLine());
            mas = new int[count];
        }

        public void Vvod()
        {
            for (int i = 0; i < mas.Length; i++)
            {
                Console.Write("Введите элемент массива №{0}: ", i);
                mas[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        public void Vivod()
        {
            for (int i = 0; i < mas.Length; i++)
            {
                Console.Write("{0} ", mas[i]);
            }
        }

        public void Sort()
        {
            int temp;
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
        }

        public void CalcSum()
        {
            int sum = 0;
            for (int i = 0; i < mas.Length; i++)
            {
                if ((mas[i] != mas[0]) && (mas[i] != mas[mas.Length - 1]) && (mas[i] > 0))
                    sum = sum + mas[i];
            }

            Console.WriteLine("\nСумма положительных элементов, находящихся между минимальным и максимальным элементами: {0}.", sum);
        }
    }

    class Program
    {
        static void Main()
        {
            Massiv mass = new Massiv();
            mass.Vvod();
            Console.WriteLine("Исходный массив:");
            mass.Vivod();
            mass.Sort();
            Console.WriteLine("\nСортированный массив:");
            mass.Vivod();
            mass.CalcSum();
        }
    }
}

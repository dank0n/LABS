// Кондратюк Данило
// 11 варіант. Даний масив цілих чилес розміру Н. Перевірити, чи утворюють його елементи арифметичну(геометричну) прогресію. Якщо так, то вивести різницю(знаменник) прогресії, якщо ні - вивести 0.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            do
            {
                Console.Write("n = ");
                n = int.Parse(Console.ReadLine());
                if (n < 2 || n > 20)
                {
                    Console.WriteLine("Error! a must be >= 2 || <= 20");
                }
            } while (n < 2 || n > 20);
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("n" + (i + 1) + "= ");
                a[i] = int.Parse(Console.ReadLine());
            }
            int arf = 0;
            int geo = 0;
            arf = a[1] - a[0];
            geo = a[1] / a[0];
            int count_arf = 0;
            int count_geo = 0;
            for (int i = 0; i < n - 1; i++)
            {
                if (a[i + 1] - a[i] != arf)
                {
                    count_arf++;
                }
                if (a[i + 1] / a[i] != geo)
                {
                    count_geo++;
                }
            }
            if (count_arf == 0)
            {
                Console.WriteLine("Елементи масиву утворюють арифметичну прогрес!ю !з р!зницею " + arf);

            }
            else if (count_geo == 0)
            {
                Console.WriteLine("Елементи масиву утворюють геометричну прогрес!ю !з знаменником " + geo);
            }
            else
            {
                Console.WriteLine("0. Елементи масиву не утворюють н! арифметичну, н! геометричну прогрес!ю!. ");
            }
            Console.ReadKey();
        }
    }
}


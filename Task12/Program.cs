using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task12
{
    class Program
    {

        /* Шейкер-сортировка */
        static int[] ShakerSort(int[] mass)//n^2
        {
            int left = 0,
                right = mass.Length - 1,
                CountCompares = 0,
                CountExchanges = 0;
            bool flag = true;

            while (left <= right&&flag)
            {
                flag = false;
                for (int i = left; i < right; i++)
                {
                    CountCompares++;
                    if (mass[i] > mass[i + 1])
                    {
                        Swap(mass, i, i + 1);
                        CountExchanges++;
                        flag = true;
                    }
                }
                right--;

                for (int i = right; i > left; i--)
                {
                    CountCompares++;
                    if (mass[i - 1] > mass[i])
                    {
                        Swap(mass, i - 1, i);
                        CountExchanges+=2;
                        flag = true;
                    }
                }
                left++;
            }
            Console.WriteLine("Количество сравнений = "+CountCompares);
            Console.WriteLine("Количество пересылок = "+CountExchanges);
            return mass;
        }
        /* Сортировка Шелла */
        static int[] ShellSort(int[] mass)//n^2
        {
            int j;
            int CountCompares=0,
                CountExchanges = 0;
            int step = mass.Length / 2;
            while (step > 0)
            {
                for (int i = 0; i < (mass.Length - step); i++)
                {
                    j = i;
                    while (j >= 0)
                    {
                        if (mass[j] < mass[j + step])
                        {
                            CountCompares++;
                            break;
                        }
                        else
                        {
                            CountCompares++;
                            Swap(mass, j, j + step);
                            j -= step;
                            CountExchanges += 2;
                        }
                    }
                }
                step = step / 2;
            }
            Console.WriteLine("Количество сравнений = " + CountCompares);
            Console.WriteLine("Количество пересылок = " + CountExchanges);
            return mass;
        }

        static void Swap(int[] mass, int i, int j)
        {
            int temp = mass[i];
            mass[i] = mass[j];
            mass[j] = temp;
        }

        /*Вывести массив*/
        static void ShowArray(int[] mass)
        {
            for (int i = 0; i < mass.Length; i++)
            {
                Console.Write(mass[i] + " ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            int[] mass = new int[] { 44, 55, 12, 42, 94, 18, 6, 67, 3, 15, 14, 49, 115, 187, 144, 1, 13, 428, 2, 45, 18, 33 };
            int[] mass1 = new int[] { 44, 55, 12, 42, 94, 18, 6, 67, 3, 15, 14, 49, 115, 187, 144, 1, 13, 428, 2, 45, 18, 33 };
            Console.WriteLine("Сортировка неупорядоченных массивов: ");
            Console.WriteLine("Шейкер-сортировка");
            mass1 = ShakerSort(mass1);
            ShowArray(mass1);
            Console.WriteLine("Сортировка Шелла");
            mass = ShellSort(mass);
            ShowArray(mass);
            Console.Read();
            int[] SortedUp = new int[] { 1, 2, 3, 6, 12, 13, 14, 15, 18, 18, 33, 42, 44, 45, 49, 55, 67, 94, 115, 144, 187, 428 };
            int[] SortedUp1 = new int[] { 1, 2, 3, 6, 12, 13, 14, 15, 18, 18, 33, 42, 44, 45, 49, 55, 67, 94, 115, 144, 187, 428 };
            Console.WriteLine("Сортировка массивов, упорядоченных по возрастанию");
            Console.WriteLine("Шейкер-сортировка");
            SortedUp = ShakerSort(SortedUp);
            ShowArray(SortedUp);
            Console.WriteLine("Сортировка Шелла");
            SortedUp1 = ShellSort(SortedUp1);
            ShowArray(SortedUp1);
            Console.Read();
            Console.Read();
            int[] SortedDown = new int[] {428, 187,144,115,94,67,55,49,45,44,42,33,18,18,15,14,13,12,6,3,2,1 };
            int[] SortedDown1 = new int[] { 428, 187, 144, 115, 94, 67, 55, 49, 45, 44, 42, 33, 18, 18, 15, 14, 13, 12, 6, 3, 2, 1 };
            Console.WriteLine("Сортировка массивов, упорядоченных по убыванию");
            Console.WriteLine("Шейкер-сортировка");
            SortedDown = ShakerSort(SortedDown);
            ShowArray(SortedDown);
            Console.WriteLine("Сортировка Шелла");
            SortedDown1 = ShellSort(SortedDown1);
            ShowArray(SortedDown1);
            Console.Read();
            Console.Read();
        }
    }
}

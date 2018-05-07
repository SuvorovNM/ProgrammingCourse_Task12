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
        static int[] ShakerSort(int[] mass)
        {
            int left = 0,
                right = mass.Length - 1,
                CountCompares = 0,
                CountExchanges = 0;

            while (left <= right)
            {
                for (int i = left; i < right; i++)
                {
                    CountCompares++;
                    if (mass[i] > mass[i + 1])
                    {
                        Swap(mass, i, i + 1);
                        CountExchanges++;
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
                    }
                }
                left++;
            }
            Console.WriteLine("Количество сравнений = "+CountCompares);
            Console.WriteLine("Количество пересылок = "+CountExchanges);
            return mass;
        }
        static int[] ShellSort(int[] mass)
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
            int[] mass = new int[] { 44, 55, 12, 42, 94, 18, 6, 67 };
            int[] mass1 = new int[] { 44, 55, 12, 42, 94, 18, 6, 67 };
            mass1 = ShakerSort(mass1);
            mass = ShellSort(mass);
            ShowArray(mass);
            Console.Read();
        }
    }
}

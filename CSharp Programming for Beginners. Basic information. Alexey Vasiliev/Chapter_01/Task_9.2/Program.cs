using System;
/*
Задача №9.

Напишите программу, в которой пользователь вводит число,
а программой отображается последовательность из трех чисел: число, на единицу меньше введенного,
введенное число и число, на единицу больше введнного. 

Предложите консольную вресию программы.
*/

namespace Task_9._2
    {
    class Program
        {
        static void Main(string[] args)
            {
            Console.Write("Введите число: ");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{num - 1} {num} {num + 1}");
            }
        }
    }

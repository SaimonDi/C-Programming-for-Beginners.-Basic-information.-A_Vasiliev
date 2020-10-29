using System;
/*
Задача №8.

Напишите программу для вычисления суммы двух чисел. Оба числа вводятся пользователем. 
Для вычисления суммы используйте оператор +. 

Предложите консольную вресию программы.
*/

namespace Task_8._2
    {
    class Program
        {
        static void Main(string[] args)
            {
            Console.Write("Введите первое число: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе число: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Сумма чисел равна {a+b}.");
            }
        }
    }

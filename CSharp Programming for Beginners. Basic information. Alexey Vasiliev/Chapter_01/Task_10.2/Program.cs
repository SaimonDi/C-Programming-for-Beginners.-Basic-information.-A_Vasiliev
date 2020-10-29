using System;
/*
Задача №10.

Напишите программу, в которой пользователь вводит два числа,
а программой вычисляется и отображается сумма и разность этих чисел. 

Предложите консольную вресию программы.
*/
namespace Task_10._2
    {
    class Program
        {
        static void Main(string[] args)
            {
            Console.Write("Введите первое число: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе число: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Сумма этих чисел равна: {a + b}\r\nРазность этих чисел равна {b - a}");
            }
        }
    }

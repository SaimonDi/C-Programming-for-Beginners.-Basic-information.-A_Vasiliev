using System;
/*
 * Задача №3.
 * 
Напишите программу, в которой пользователь последовательно вводит название текущего дня недели,
название месяца и дату(номер в месяце). 
Программа выводит сообщение о сегодняшней дате(день недели, дата, месяц). 

Предложите консольную вресию программы.
 * 
 */

namespace Task_3._2
    {
    class Program
        {
        static void Main(string[] args)
            {
            Console.Write("Какой сегодня день недели? ");
            string week = Console.ReadLine();
            Console.Write("А какое число? ");
            int day = Convert.ToInt32(Console.ReadLine());
            Console.Write("Какой сейчас месяц? ");
            string month = Console.ReadLine();

            Console.WriteLine($"Сегодняшняя дата: {week} {day} {month}");
            }
        }
    }

using System;
/*
Задача №4.

Напишите программу, в которой пользователю предлагается ввести название месяца и количество дней в этом месяце. 
Программа выводит сообщение о том, что соответствующий месяц содержит указанное количество дней. 

Предложите версии для ввода/вывода данных через консоль.
*/
namespace Task_4._1
    {
    class Program
        {
        static void Main(string[] args)
            {
            Console.Write("Какой сейчас месяц? ");
            string month = Console.ReadLine();
            Console.Write("Сколько дней в этом месяце? ");
            string dayInMonth = Console.ReadLine();

            Console.WriteLine($"Сейчас {month} и в нём {dayInMonth} день");
            }
        }
    }

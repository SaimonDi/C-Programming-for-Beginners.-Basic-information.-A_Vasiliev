using System;
/*
Задача №6.

Напишите программу, в которой пользователь вводит имя и год рождения, а программа отображает сообщение,
содержащее имя пользователя и его возраст. 

Предложите консольную вресию программы.
*/

namespace Task_6._2
    {
    class Program
        {
        static void Main(string[] args)
            {
            Console.Write("Введите ваше имя: ");
            string name = Console.ReadLine();
            Console.Write("Введи год вашего рождения: ");
            int year = Convert.ToInt32(Console.ReadLine());
            int date = DateTime.Now.Year;

            Console.WriteLine($"Вас зовут {name} и вам {date-year}");

            }
        }
    }

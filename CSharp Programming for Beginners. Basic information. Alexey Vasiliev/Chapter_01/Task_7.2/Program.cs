using System;
/*
Задача №7.

Напишите программу, в которой по возрасту опредялется год рождения. 
Возраст пользователь вводит в окно с полем, а вычисленный год рождения отображается в другом диалоговом окне.

Предложите консольную вресию программы.
*/

namespace Task_7._2
    {
    class Program
        {
        static void Main(string[] args)
            {
            Console.Write("Введите ваш возраст: ");
            int year = Convert.ToInt32(Console.ReadLine());
            int date = DateTime.Now.Year;

            Console.WriteLine($"Ваш год рождения {date-year}.");
            }
        }
    }

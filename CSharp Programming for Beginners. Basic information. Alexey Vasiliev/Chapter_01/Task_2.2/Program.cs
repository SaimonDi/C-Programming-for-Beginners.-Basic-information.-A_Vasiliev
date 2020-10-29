using System;
/*
Задача №2.

Напишите программу, в которой пользователь вводит имя и возраст. 
Программа отоббражает сообщение об имени и возрасте пользователя. 

Предложите консольную вресию программы.

*/

namespace Task_2._2
    {
    class Program
        {
        static void Main(string[] args)
            {
            Console.Write("Введите ваше имя: ");
            string name = Console.ReadLine();
            Console.Write("Введите ваш возраст: ");
            string years = Console.ReadLine();

            Console.WriteLine($"Вас зовут {name} и вам {years}");
            }
        }
    }

using System;

/*
Задача №1.

Напишите программу, в котрой пользователь вводит сначала имя, а затем фамилию. 
Программа выводит сообщение с информацией об имени и фамилии пользователя. 

Предложите консольную вресию программы.
*/

namespace Task_1._2
    {
    class Program
        {
        static void Main(string[] args)
            {
            Console.Write("Введите ваше имя: ");
            string name = Console.ReadLine();
            Console.Write("Введите вашу фамилию: ");
            string lastName = Console.ReadLine();

            Console.WriteLine($"Вас зовут: {name} {lastName}");
            }
        }
    }

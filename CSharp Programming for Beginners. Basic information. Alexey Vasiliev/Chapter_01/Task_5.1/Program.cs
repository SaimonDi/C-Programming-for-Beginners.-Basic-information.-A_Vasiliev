using System;
/*
Задача №5.

Напишите программу, в которой по году рождения определяется возраст пользователя. 
Используйте консольный ввод и вывод данных.
*/

namespace Task_5._1
    {
    class Program
        {
        static void Main(string[] args)
            {
            Console.Write("Введите ваш год рождения: ");
            int year = Convert.ToInt32(Console.ReadLine());
            int tempDate = DateTime.Today.Year;

            Console.WriteLine($"Вам примерно {tempDate - year}.");
            }
        }
    }

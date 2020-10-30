using System;
/*
	Задние №4
	
	Напишите программу, которая проверяет, 
	попадает ли введенное пользователем число в диапазон от 5 до 10 включительно
*/

namespace Task_04
    {
    class Program
        {
        static void Main(string[] args)
            {
            Console.Write("Введите число в диапазоне от 5 до 10: ");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine((5 <= number) && (number <= 10) ? "Число подходит под критерии" : "Число не подходит под критерии");
            }
        }
    }

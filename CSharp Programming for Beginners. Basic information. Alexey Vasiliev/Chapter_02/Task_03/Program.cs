using System;
/*
	Задние №3
	
	Напишите программу, которая проверяет, 
	удовлетворяет ли введенное пользователем число следующим критериям:
	число делится на 5 и при этом оно не меньше 10.
*/

namespace Task_03
    {
    class Program
        {
        static void Main(string[] args)
            {
            Console.Write("Введите число, которое делится 5 на и при этом не меньше 10: ");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine((number % 5 == 0) && (number > 10) ? "Число подходит под условия" : "Число не подходит условиям");
            }
        }
    }

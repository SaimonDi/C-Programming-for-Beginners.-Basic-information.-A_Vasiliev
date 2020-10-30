using System;
/*
	Задние №1
	
	Напишите программу, которая проверяет, делится ли введенное пользователем число на 3.
*/
namespace Task_01
    {
    class Program
        {
        static void Main(string[] args)
            {
            Console.Write("Введите число: ");
            int number = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine(number % 3 == 0 ? "Число делится на 3" : "Число не делится на три");
            }
        }
    }

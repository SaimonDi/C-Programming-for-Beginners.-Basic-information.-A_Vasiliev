using System;
/*
	Задние №5
	
	Напишите программу, которая проверяет, 
	сколько тысяч во введенном пользователем числе
	(определяется четвертая цифра справа в десятичном представлении числа)	
*/

namespace Task_05
    {
    class Program
        {
        static void Main(string[] args)
            {
            Console.Write("Введите число больше тысячи: ");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"в этом числе {number / 1000 % 1000} тысяч");
            }
        }
    }

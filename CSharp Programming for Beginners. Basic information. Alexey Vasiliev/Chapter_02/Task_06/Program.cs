using System;
/*
	Задние №6
	
	Напишите программу, которая проверяет
	вторую цифру в восьмеричном представлении числа, введенного пользователем.
	Число делится в десятичном(обычном) представлении.
*/

namespace Task_06
    {
    class Program
        {
        static void Main(string[] args)
            {
            Console.Write("Введите число: ");
            int num1 = Convert.ToInt32(Console.ReadLine(), 8);

            string num2 = Convert.ToString(num1, 8);
            int number = Convert.ToInt32(num2);

            Console.WriteLine(number / 10 % 10);

            }
        }
    }

using System;
/*
	Задние №9
	
	Напишите программу, в которой для введенного пользователем числа
	в бинарном представлении четвертый бит устанавливается равным нулю.
*/

namespace Task_09
    {
    class Program
        {
        static void Main(string[] args)
            {
            Console.Write("Введите число: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            int num2 = (Convert.ToInt32(Convert.ToString(num1 >> 3, 2)) % 10 == 1) ? num1 - 8 : num1;

            Console.WriteLine(Convert.ToString(num1, 2) + " " + Convert.ToString(num2, 2));
            }
        }
    }

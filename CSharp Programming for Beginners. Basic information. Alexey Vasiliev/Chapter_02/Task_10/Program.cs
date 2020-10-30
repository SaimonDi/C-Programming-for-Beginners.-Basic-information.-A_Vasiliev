using System;
/*
	Задние №10
	
	Напишите программу, в которой для введенного пользователем числа
	в бинарном представлении значение второго бита меняется на противоположное 
	(исходное нулевое значение бита меняется на единичное, а исходное единичное значение бита меняется на нулевое).
*/
namespace Task_10
    {
    class Program
        {
        static void Main(string[] args)
            {
            Console.Write("Введите число: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            int num2 = (Convert.ToInt32(Convert.ToString(num1 >> 1, 2)) % 10 == 1) ? num1 - 2 : num1 + 2;

            Console.WriteLine(Convert.ToString(num1, 2) + " " + Convert.ToString(num2, 2));
            }
        }
    }

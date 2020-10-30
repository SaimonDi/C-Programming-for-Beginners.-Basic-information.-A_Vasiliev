using System;
/*
	Задние №8
	
	Напишите программу, в которой для введенного пользователем числа 
	в бинарном представлении третий бит устанавливается равным единице.
*/

namespace Task_08
    {
    class Program
        {
        static void Main(string[] args)
            {
            Console.Write("Введите число: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            int num2 = (Convert.ToInt32(Convert.ToString(num1 >> 2, 2)) % 10 != 1) ? num1 + 4 : num1;

            Console.WriteLine(Convert.ToString(num1, 2) + " " + Convert.ToString(num2, 2));
            }
        }
    }

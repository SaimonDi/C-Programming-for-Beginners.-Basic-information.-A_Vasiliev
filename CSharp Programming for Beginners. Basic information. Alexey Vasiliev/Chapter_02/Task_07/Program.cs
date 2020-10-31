using System;

/*
	Задние №7
	
	Напишите программу, которая вычисляет третий бит справа в двоичном представлении числа,
	введенного пользователем. Число вводится в десятичном(обычном) представлении.
	В программе используйте оператор побитового сдвига.
*/

namespace Task_07
    {
    class Program
        {
        static void Main(string[] args)
            {
            Console.Write("Введите число: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Трертий бит равен: { Convert.ToInt32(Convert.ToString(num1 >> 3, 2)) % 10}");
            }
        }
    }

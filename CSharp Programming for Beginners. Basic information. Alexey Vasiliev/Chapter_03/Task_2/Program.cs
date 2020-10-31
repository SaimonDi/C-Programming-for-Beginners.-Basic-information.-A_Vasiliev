using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
	Задние №2
	
	Напишите программу в которой пользователь последователь но вводит два целых числа.
	Программа определяет, какое из чисел больше или они равны.
	
	Результаты проверки отображаются в сообщении. 
	Используйте обработку исключений.
*/
namespace Task_2
    {
    class Program
        {
        static void Main(string[] args)
            {
            try
                {
                Console.Write("Введите первое число: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите второе число: ");
                int num2 = Convert.ToInt32(Console.ReadLine());
                if(num1>num2)
                    {
                    Console.WriteLine($"Первое число больше второго: {num1} > {num2}");
                    }
                else if (num1<num2)
                    {
                    Console.WriteLine($"Второе число больше первого: {num2} > {num1}");
                    }
                else
                    {
                    Console.WriteLine("Числа равны.");
                    }
                }
            catch
                {
                Console.WriteLine("Необходимо ввести число!");
                }
            }
        }
    }

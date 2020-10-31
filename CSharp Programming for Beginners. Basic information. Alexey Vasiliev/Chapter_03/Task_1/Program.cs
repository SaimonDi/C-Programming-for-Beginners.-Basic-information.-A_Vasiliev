using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
	Задние №1
	
	Напишите программу в которой пользователь вводит число,
	а программа проверяет, делится ли это число на 3 и на 7.
	
	Результаты проверки отображаются в сообщении. 
	Используйте обработку исключений.
*/
namespace Task_1
    {
    class Program
        {
        static void Main(string[] args)
            {
            try
                {
                Console.Write("Введите число: ");
                int num = Convert.ToInt32(Console.ReadLine());

                if(num%3==0&&num%7==0)
                    {
                    Console.WriteLine($"Число {num} подходит под критерии.");
                    }
                else
                    {
                    Console.WriteLine("Число не подходит под критерии.");    
                    }

                }
            catch
                {
                Console.WriteLine("Необходимо ввести число!");
                }
            }
        }
    }

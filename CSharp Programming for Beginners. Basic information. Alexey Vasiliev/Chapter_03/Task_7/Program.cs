using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
	Задние №7
	
	Напишите программу для вычисления суммы квадратов натуральных чисел. 
	Для проверки результата воспользуйтесь тем, что 1^2+2^2+3^2 +...+n^2=(n(n+1)(2n+1))/6.
	
	Предложите версии программы, использующие разные операторы цикла.
*/
namespace Task_7
    {
    class Program
        {
        static void Main(string[] args)
            {
            int sum = 0;
            try
                {
                Console.Write("Введите число: ");
                int number = Convert.ToInt32(Console.ReadLine());

                for(int i = 1; i <= number;i++)
                    {
                    sum += (int)Math.Pow(i,2);
                    }
                }
            catch
                {
                Console.WriteLine("Необходимо вводить число!");
                }
            Console.WriteLine($"Сумма квадрата суммы чисел равна: {sum}");
            }
        }
    }

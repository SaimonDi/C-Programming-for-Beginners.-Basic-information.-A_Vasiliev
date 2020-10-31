using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
/*
	Задние №6
	
	Напишите программу в которой вычисляется сумма нечетных чисел.
	Для проверки результата воспользуйте тем, что 2+4+6+...+2n=n(n+1).
	
	Предложите версии программы, использующие разные операторы цикла.
*/
namespace Task_6
    {
    class Program
        {
        static void Main(string[] args)
            {
            int number = 0, sum = 0;
            try
                {
                Console.Write("Введите число: ");
                number = Convert.ToInt32(Console.ReadLine());

                for(; number > 0; number--)
                    {
                    if(number % 2 == 1)
                        sum += number;
                    }
                }
            catch
                {
                Console.WriteLine("Необходимо число!");
                }
            Console.WriteLine($"Сумма нечётных чисел равна {sum}");
            }
        }
    }

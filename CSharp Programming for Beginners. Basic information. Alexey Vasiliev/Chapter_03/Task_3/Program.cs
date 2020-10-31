using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
	Задние №3
	
	Напишите программу в которой вычисляет сумма чисел, которые вводит пользователь.
	Программа выводит запрос на ввод числа, считает введенное пользователем число,
	прибавляет его к сумме и снова выводит запрос на ввод числа.
	Процесс продолжается до тех пор, пока пользователь не введет нулевое значение.
	
	Используйте обработку исключений.
*/
namespace Task_3
    {
    class Program
        {
        static void Main(string[] args)
            {
            int num, sum = 0;
            try
                {
                do
                    {
                    Console.Write("Введите число: ");
                    num = Convert.ToInt32(Console.ReadLine());

                    sum += num;
                    } while(num != 0);
                }
            catch
                {
                Console.WriteLine("Необходимо ввести число!");
                }

            Console.WriteLine($"Сумма введённых чисел равна: {sum}");
            }
        }
    }

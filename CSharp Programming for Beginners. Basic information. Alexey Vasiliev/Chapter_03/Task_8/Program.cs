using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
	Задние №8
	
	Напишите программу в которой выводится последовательно чисел Фиббоначчи. 
	Первые два числа в этой последовательности равны 1,
	а каждое следующее равно сумме двух предыдущих(получается последовательно 
	1,1,2,3,5,8,13,21,34,55,89,...). Количество чисел в последовательности вводится пользователем.
	
	Предложите версии программы использующие разные операторы цикла.
	
*/
namespace Task_8
    {
    class Program
        {
        static void Main(string[] args)
            {
			int a = 1, b = 1, next;
            Console.Write("Введите количество чисел в последовательности Фиббоначи: "); 
            int howMany = Convert.ToInt32(Console.ReadLine());

            Console.Write("1 1 ");

            while(howMany-2>0)
                {
                next = a + b;

                a = b;
                b = next;

                Console.Write($"{next} ");
                howMany--;
                }

            Console.WriteLine(Environment.NewLine+"Конец.");
            }
        }
    }

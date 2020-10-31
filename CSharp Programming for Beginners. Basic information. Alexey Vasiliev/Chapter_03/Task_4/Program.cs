using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
	Задние №4
	
	Напишите программу в которой пользователь вводит целое число в диапазоне от 1 до 7,
	а программа определяет по этому числу день недели. Если введенное пользователем число
	выходит за допустимы диапазон, выводит сообщение о том, что введено некорректное значени.
	
	Используйте оператор switch. 
	Предложите механизм обработки ошибки, связанной с вводом нечислового значния.
*/
namespace Task_4
    {
    class Program
        {
        static void Main(string[] args)
            {
            try
                {
                Console.Write("Введите число от 1 до 7: ");
                int number = Convert.ToInt32(Console.ReadLine());
                
                switch(number)
                    {
                    case 1: Console.WriteLine("Понедельник."); break;
                    case 2: Console.WriteLine("Вторник."); break;
                    case 3: Console.WriteLine("Среда."); break;
                    case 4: Console.WriteLine("Четверг."); break;
                    case 5: Console.WriteLine("Пятница."); break;
                    case 6: Console.WriteLine("Суббота."); break;
                    case 7: Console.WriteLine("Воскресенье."); break;
                    default:
                    Console.WriteLine("Введенно некоректное значение"); break;
                    }
                }
            catch
                {
                Console.WriteLine("Необходимо ввести число!");
                }
            }
        }
    }

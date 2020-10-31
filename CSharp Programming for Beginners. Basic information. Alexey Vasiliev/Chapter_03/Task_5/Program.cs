using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
	Задние №5
	
	Напишите программу в которой пользователю предлагается ввести название дня недели. 
	По введенному названию программа определяет порядковый номер дня в неделе.
	Если пользователь вводит неправильное название дня, программа выводит сообщение о том, что такого дня нет.
	
	Предложите версию программы на основе вложенных условных оперторов и на основе оператора выбора switch.
*/
namespace Task_5
    {
    class Program
        {
        static void Main(string[] args)
            {
            Console.Write("Введите день недели: ");
            string weekDay = Console.ReadLine();

            switch(weekDay)
                {
                case "понедельник": 
                case "Понедельник": Console.WriteLine($"Это 1 день недели."); break;
                case "вторник": 
                case "Вторник": Console.WriteLine($"Это 2 день недели."); break;
                case "среда": 
                case "Среда": Console.WriteLine($"Это 3 день недели."); break;
                case "четверг": 
                case "Четверг": Console.WriteLine($"Это 4 день недели."); break;
                case "пятница": 
                case "Пятница": Console.WriteLine($"Это 5 день недели."); break;
                case "суббота": 
                case "Суббота": Console.WriteLine($"Это 6 день недели."); break;
                case "воскресенье": 
                case "Воскресенье": Console.WriteLine($"Это 7 день недели."); break;
                default:
                Console.WriteLine("Такого дня недели не существует"); break;
                }
            }
        }
    }

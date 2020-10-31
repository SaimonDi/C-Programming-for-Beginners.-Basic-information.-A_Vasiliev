using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
	Задние №10
	
	Напишите программу, в которой вычисляется сумма чисел, удовлетворяющих таким критериям:
	при делении на 5 в остатке получается 2, или при делении на 3 в остатке получается 1.
	Количество чисел в сумме вводится пользователем.
	Программа отображает числа, которые суммируются, и значение суммы.
	
	Предложите версии программы использующие разные операторы цикла.
 	Используйте обработку исключений.
*/
namespace Task_10
    {
    class Program
        {
        static void Main(string[] args)
            {
            
            try
                {
                Console.Write("Введите число: ");
                int sum = Convert.ToInt32(Console.ReadLine());
                int printSum = sum;
                string printS="";

                for(int i = 2; i <= sum; i++,sum--)
                    {
                    if(((i % 5 == 2) || (i % 3 == 1)) && ((sum % 5 == 2) || (sum % 3 == 1)))
                        {
                        printS=$"{i} + {sum} = {printSum}";
                        Console.WriteLine(printS);
                        }
                    }
                if(printS=="")
                    {
                    Console.WriteLine("Необходимых сумм не нашлось :(");
                    }
                }
            catch
                {
                Console.WriteLine("Необходиммо ввести число!");
                }
            }
        }
    }

using System;
/*
	Задние №9
	
	Напишите программу, в которой пользователь вводит два целых числа.
	Программа выводит все целые числа - начиная с наименьшего (из двух введенных чисел)
	и заканчивая наибольшим(из двух введенных чисел).
	
	Предложите версии программы использующие разные операторы цикла.
 	Используйте обработку исключений.
	*/
namespace Task_9
    {
    class Program
        {
        static void Main(string[] args)
            {
            string manyNumber = "";
            try
                {
                Console.Write("Введите первое число: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите второе число: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                if(num1 > num2)
                    {
                    while(num1 >= num2)
                        {
                        manyNumber += num2.ToString() + " ";
                        num2++;
                        }
                    }
                else if(num1 <= num2)
                    {
                    while(num1 >= num2)
                        {
                        manyNumber += num1.ToString() + " ";
                        num1++;
                        }
                    }
                else
                    {
                    Console.WriteLine($"Числа равны: {num1}");
                    }

                Console.WriteLine(manyNumber);
                }
            catch
                {
                Console.WriteLine("Необходимо ввести числа!");
                }
            }
        }
    }

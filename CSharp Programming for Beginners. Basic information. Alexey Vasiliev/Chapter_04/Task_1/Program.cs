using System;
/*
	Задние №1
	
	Напишите программу, в которой создается одномерный числовой масив и заполняется числами, 
	которые при делении на 5 дают в остатке 2(числа 2,7,12,17 и так далее). Размер массива вводится пользователем. 
	
	Предусмотреть обработку ошибки, связанной с вводом некорректного значения.
*/

namespace Task_1
    {
    class Program
        {
        static void Main(string[] args)
            {
            int[] massNumb;

            try
                {
                Console.Write("Определите размер массива: ");
                int howMany = Convert.ToInt32(Console.ReadLine());

                massNumb = new int[howMany];
                int i = 0;

                for(int j = 0; j < massNumb.Length; j++)
                    {
                    do
                        {
                        i++;
                        if(i % 5 == 2)
                            {
                            massNumb[j] = i;
                            }
                        } while(massNumb[j] != i);
                    }

                foreach(int s in massNumb)
                    {
                    Console.Write($"{s,2} ");
                    }
                }
            catch
                {
                Console.WriteLine("Некорректное значение!");
                }
            }
        }
    }

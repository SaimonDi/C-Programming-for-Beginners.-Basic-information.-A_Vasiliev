using System;
/*
	Задние №2
	
	Напишите программу, в которой создается массив из 11 целочисленных элементов. 
	Массив заполняется степенями двойки - числами 2^0=1,2^1=2,2^2=4,2^3=8 и так далее до 2^10=1024.
	При заполнении массива учесть, что начальный элемент равен 1, а каждый следющий больше
	предыдущего в 2 раза.  
	
	Отобразить массив в консольном окне в прямом и обратном порядке.
	Размер массива задается переменной.
*/
namespace Task_2
    {
    class Program
        {
        static void Main(string[] args)
            {
            int x = 11;
            int[] massNumb = new int[x];

            for(int i = 0; i < massNumb.Length; i++)
                {
                massNumb[i] = (int)Math.Pow(2, i);
                }

            for(int i = 0; i < massNumb.Length; i++)
                {
                Console.Write($"2^{i}={massNumb[i]}  ");
                }
            Console.WriteLine();

            for(int i = massNumb.Length - 1; i >= 0; i--)
                {
                Console.Write($"2^{i}={massNumb[i]}  ");
                }
            }
        }
    }

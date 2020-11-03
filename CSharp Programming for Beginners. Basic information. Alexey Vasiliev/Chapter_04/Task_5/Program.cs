using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
	Задние №5
	
	Напишите программу, в которой создается массив и заполняется случайными числами.
	Массив отображается в консольном окне. В этом массиве необходимо определить элемент
	с минимальным значением. В частности, программа должна вывести значение элемента с минимальным
	значением и индекс этого элемента. Если элементов с минимальным  значением несколько, 
	должны быть выведены индексы всех этих элементов.
*/
namespace Task_5
    {
    class Program
        {
        static void Main(string[] args)
            {
            int[] massNumb = new int[100];
            Random rnd = new Random();

            for(int i = 0; i < massNumb.Length; i++)
                {
                massNumb[i] = rnd.Next(1,101);
                }

            int index = 0;
            int value = massNumb[index];
            string s = "";

            for(int i = 0; i < massNumb.Length; i++)
                {
                if(massNumb[i]<value)
                    {
                    value = massNumb[i];
                    index = i;
                    }
                }

            Console.WriteLine($"Минимальное число: {value}");

            for(int i = 0; i < massNumb.Length; i++)
                {
                if(massNumb[i]==value)
                    {
                    value = massNumb[i];
                    index = i;
                    s += $"{index} ";
                    }
                }
            
            Console.WriteLine($"Индексы : {s}");
            }
        }
    }

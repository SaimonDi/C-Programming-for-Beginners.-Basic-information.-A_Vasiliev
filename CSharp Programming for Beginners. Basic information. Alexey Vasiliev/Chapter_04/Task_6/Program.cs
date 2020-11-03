using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
	Задние №6
	
	Напишите программу, в которой создается целочисленный массив, заполняется случайными числами 
	и после этого значенния элементов в массиве сортируются в порядке убывания значений.
*/
namespace Task_6
    {
    class Program
        {
        static void Main(string[] args)
            {
            int[] massNumb = new int[10];
            Random rnd = new Random();
            int k;

            for(int i = 0; i < massNumb.Length; i++)
                {
                massNumb[i] = rnd.Next(100);
                }

            foreach(int item in massNumb)
                {
                Console.Write($"{item}\t");
                }
            Console.WriteLine();

            for(int j = 0; j < massNumb.Length; j++)
                {
                for(int i = 0; i < massNumb.Length - 1; i++)
                    {
                    if(massNumb[i] < massNumb[i + 1])
                        {
                        k = massNumb[i];
                        massNumb[i] = massNumb[i + 1];
                        massNumb[i + 1] = k;
                        }
                    }
                }

            foreach(int item in massNumb)
                {
                Console.Write($"{item}\t");
                }

            }
        }
    }

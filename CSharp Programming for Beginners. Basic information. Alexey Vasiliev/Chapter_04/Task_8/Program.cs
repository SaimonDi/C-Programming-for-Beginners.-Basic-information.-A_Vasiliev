using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
	Задние №8
	
	Напишите программу, в которой создается двумерный целочисленный массив. 
	Он заполняется случайными числами. затем в этом массиве строки и столбцы меняются местами:
	первая строка становится первым столбцом, вторая строка становится вторым столбцом и так далее.
	Например, если исходный массив стоял из 3 строк и столбцов, 
	то в итоге получаем массив из 5 строк и 3 столбцов.
	
*/
namespace Task_8
    {
    class Program
        {
        static void Main(string[] args)
            {
            int[,] massNumb = new int[3,5], massNumbInvert = new int[massNumb.GetLength(1),massNumb.GetLength(0)];
            Random rnd = new Random();

            for(int i = 0; i < massNumb.GetLength(0); i++)
                {
                for(int j = 0; j < massNumb.GetLength(1); j++)
                    {
                    massNumb[i, j] = rnd.Next(100);
                    Console.Write($"{massNumb[i,j]}\t");
                    massNumbInvert[j, i] = massNumb[i, j];
                    }
                Console.WriteLine();
                }
            Console.WriteLine();


            for(int i = 0; i < massNumbInvert.GetLength(0); i++)
                {
                for(int j = 0; j < massNumbInvert.GetLength(1); j++)
                    {
                    Console.Write($"{massNumbInvert[i,j]}\t");
                    }
                Console.WriteLine();
                }
            Console.WriteLine();
            }
        }
    }

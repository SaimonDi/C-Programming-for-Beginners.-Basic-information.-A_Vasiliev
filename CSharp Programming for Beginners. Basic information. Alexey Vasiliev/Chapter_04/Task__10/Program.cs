using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
/*
	Задние №10
	
	Напишите программу, в которой создается двумерный числовой массив и этот массив заполняется "змейкой":
	сначала первая строка(слева направо), затем последний столбец(сверху вниз), последняя строка
	(справа налево), первый столбец (снизу вверх), вторая строка(слева направо) и так далее.
*/
namespace Task__10
    {
    class Program
        {
        static void Main(string[] args)
            {
            int rows = 5, cols = 5;
            int[,] array = new int[rows, cols];
            int k = 0;

            for(int j = 0; j < cols; j++) //1
                {
                array[0, j] = k; k++;
                }
            for(int i = 1; i < rows; i++) //2
                {
                array[i, 4] = k; k++;
                }
            for(int j = 3; j >= 0; j--) //3
                {
                array[4, j] = k; k++;
                }
            for(int i = 3; i > 0; i--) //4
                {
                array[i, 0] = k; k++;
                }
            for(int j = 1; j < cols - 1; j++) //5
                {
                array[1, j] = k; k++;
                }
            for(int i = 2; i < rows - 1; i++) //6
                {
                array[i, 3] = k; k++;
                }
            for(int j = 2; j > 0; j--) //7
                {
                array[3, j] = k; k++;
                }
            for(int i = 2; i > 1; i--) //8
                {
                array[i, 1] = k; k++;
                }
            for(int j = 2; j > 1; j--) //9
                {
                array[2, j] = k; k++;
                }



            for(int i = 0; i < array.GetLength(0); i++)
                {
                for(int j = 0; j < array.GetLength(1); j++)
                    {
                    Console.Write($"{array[i,j]}\t");
                    }
                Console.WriteLine();
                }
            Console.WriteLine();
            }
        }
    }

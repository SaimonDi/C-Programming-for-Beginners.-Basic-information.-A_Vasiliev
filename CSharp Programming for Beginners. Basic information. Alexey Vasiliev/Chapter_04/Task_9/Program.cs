using System;
/*
	Задние №9
	
	Напишите программу, в которой создается и инициализируется двумерный числовой массив.
	Затем из этого массива удаляется строка и столбец(создается новый массив,
	в котором по сравнению  с исходным удалена одна строка и один столбец).
	Индекс удаляемой строки и индекс адаляемого столбца определяется
	с помощью генератора случайных чисел.
*/
namespace Task_9
    {
    class Program
        {
        static void Main(string[] args)
            {
            int[,] massNumb = new int[3, 5], massNumbAlter = new int[massNumb.GetLength(0) - 1, massNumb.GetLength(1) - 1];
            Random rnd = new Random();
            int k = rnd.Next(1, massNumb.GetLength(0)), l = rnd.Next(1, massNumb.GetLength(1));

            for(int i = 0; i < massNumb.GetLength(0); i++)
                {
                for(int j = 0; j < massNumb.GetLength(1); j++)
                    {
                    massNumb[i, j] = rnd.Next(100);
                    Console.Write($"{massNumb[i, j]}\t");
                    }
                Console.WriteLine();
                }
            Console.WriteLine();

            for(int i = 0, a = 0; i < massNumbAlter.GetLength(0); i++, a++)
                {
                for(int j = 0, b = 0; j < massNumbAlter.GetLength(1); j++, b++)
                    {
                    if(k == a) a++;
                    if(l == b) b++;
                    massNumbAlter[i, j] = massNumb[a, b];
                    Console.Write($"{massNumbAlter[i, j]}\t");
                    }
                Console.WriteLine();
                }
            Console.WriteLine();
            }
        }
    }

using System;
/*
	Задние №3
	
	Напишите программу, в которой создается одномерный символьный массив из 10 элементов. 
	Массив заполняется буквами "через одну", начиная с буквы 'а': 
	тоесть массив заполняется буквами 'a','c','e','g' и так далее.
	
	Отобразить массив в консольном окне в прямом и боратном порядке.
	Размер массива задается переменной.
*/
namespace Task_3
    {
    class Program
        {
        static void Main(string[] args)
            {
            char[] massChar = new char[10];

            for(int i = 0; i < massChar.Length; i++)
                {
                massChar[i] = (char)('a' + 2*i);
                }

            foreach(char s in massChar)
                {
                Console.Write($"{s,2}");
                }
            Console.WriteLine();

            for(int i = massChar.Length - 1; i >= 0; i--)
                {
                Console.Write($"{massChar[i],2}");
                }
            Console.WriteLine();
            }
        }
    }

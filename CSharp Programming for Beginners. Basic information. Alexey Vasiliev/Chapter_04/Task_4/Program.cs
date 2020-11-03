/*
	Задние №4
	
	Напишите программу, в которой создается символьный массив из 10 элементов. 
	Массив заполнить большими (прописными) буквами английского алфавита. Буквы берутся подряд,
	но только согласные(то есть гласные буквы 'A','E' и 'I' при присваивании значений
	элементам массива нужно пропустить).
	
	Отобразите содержимое созданного массива в консольном окне.
*/
namespace Task_4
    {
    class Program
        {
        static void Main(string[] args)
            {
            char[] massChar = new char[10];

            for(int i = 0, j = 0; i < massChar.Length; i++, j++)
                {
                while((char)('A' + j) == 'A' | (char)('A' + j) == 'E' | (char)('A' + j) == 'I')
                    {
                    j++;
                    }
                massChar[i] = (char)('A' + j);
                }

            foreach(char s in massChar)
                {
                System.Console.Write($"{s,2}");
                }
            System.Console.WriteLine();

            }
        }
    }

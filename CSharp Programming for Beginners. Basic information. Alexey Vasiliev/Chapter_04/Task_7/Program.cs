/*
	Задние №7
	
	Напишите программу, в которой создается целочисленный массив,
	а затем порядок элементов в массиве меняется на обратный.
*/
namespace Task_7
    {
    class Program
        {
        static void Main(string[] args)
            {
            int[] massNumb = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] massNumbInvert = new int[massNumb.Length];

            foreach(int item in massNumb)
                {
                System.Console.Write($"{item}\t");
                }
            System.Console.WriteLine();

            for(int i = 0, j = massNumb.Length-1; i < massNumb.Length; i++, j--)
                {
                massNumbInvert[j] = massNumb[i];
                }
            massNumb = massNumbInvert;

            foreach(int item in massNumb)
                {
                System.Console.Write($"{item}\t");
                }
            System.Console.WriteLine();
            }
        }
    }

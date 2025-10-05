using Tyuiu.FisherMA.Sprint4.Task3.V14.Lib;

namespace Tyuiu.FisherMA.Sprint4.Task3.V14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int[,] matrix =
            {
                {3, 2, 3, 3, 5},
                {2, 3, 3, 7, 3},
                {7, 5, 2, 7, 3},
                {4, 2, 7, 5, 2},
                {3, 5, 4, 2, 6}
            };

            int result = ds.Calculate(matrix);

            Console.Title = "Спринт #4 | Выполнил: Фишер М. A. | ИИПб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы                                                 *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #14                                                             *");
            Console.WriteLine("* Выполнил: Фишер Максим Алексеевич | ИИПб-25-1                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный массив 5x5 с элементами от 2 до 7.                        *");
            Console.WriteLine("* Найти максимальный элемент в четвертой строке массива.                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Исходный массив:                                                        *");
            Console.WriteLine("***************************************************************************");

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"Максимальный элемент в 4-й строке: {result}");
            Console.ReadKey();
        }
    }
}

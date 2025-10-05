using Tyuiu.FisherMA.Sprint4.Task7.V10.Lib;

namespace Tyuiu.FisherMA.Sprint4.Task7.V10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Фишер М. A. | ИИПб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Преобразование строки в двумерный массив                          *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #10                                                             *");
            Console.WriteLine("* Выполнил: Фишер Максим Алексеевич | ИИПб-25-1                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дана строка из одноразрядных цифр: \"695847142536\".                     *");
            Console.WriteLine("* Преобразовать её в матрицу 3x4 и подсчитать сумму нечётных чисел.       *");
            Console.WriteLine("***************************************************************************");

            string input = "695847142536";
            int[,] matrix = ds.ConvertStringToMatrix(input, 3, 4);

            Console.WriteLine("* Матрица 3x4:                                                            *");
            Console.WriteLine("***************************************************************************");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }

            int result = ds.Calculate(matrix);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"Сумма нечётных чисел: {result}");
            Console.ReadKey();
        }
    }
}

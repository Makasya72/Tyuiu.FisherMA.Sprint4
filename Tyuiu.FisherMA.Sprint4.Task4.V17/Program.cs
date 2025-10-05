using Tyuiu.FisherMA.Sprint4.Task4.V17.Lib;

namespace Tyuiu.FisherMA.Sprint4.Task4.V17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Фишер М. A. | ИИПб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы (ввод с клавиатуры)                             *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #17                                                             *");
            Console.WriteLine("* Выполнил: Фишер Максим Алексеевич | ИИПб-25-1                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный массив 5x5, заполненный значениями с клавиатуры (2..7).   *");
            Console.WriteLine("* Найти сумму чётных элементов массива.                                   *");
            Console.WriteLine("***************************************************************************");

            int[,] matrix = new int[5, 5];

            Console.WriteLine("* Введите 25 чисел от 2 до 7 (5 строк по 5 чисел):                        *");

            for (int i = 0; i < 5; i++)
            {
                string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                for (int j = 0; j < 5 && j < input.Length; j++)
                {
                    matrix[i, j] = Convert.ToInt32(input[j]);
                }
            }

            int result = ds.Calculate(matrix);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"Сумма чётных элементов массива: {result}");
            Console.ReadKey();
        }
    }
}

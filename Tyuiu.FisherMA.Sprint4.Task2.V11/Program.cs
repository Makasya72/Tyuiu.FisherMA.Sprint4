using Tyuiu.FisherMA.Sprint4.Task2.V11.Lib;

namespace Tyuiu.FisherMA.Sprint4.Task2.V11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Фишер М. A. | ИИПб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы (случайные значения)                           *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #11                                                             *");
            Console.WriteLine("* Выполнил: Фишер Максим Алексеевич | ИИПб-25-1                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный массив из 15 элементов, заполненный случайными числами   *");
            Console.WriteLine("* в диапазоне от 3 до 8. Подсчитать сумму чётных элементов массива.       *");
            Console.WriteLine("***************************************************************************");

            int[] array = new int[15];
            Random rnd = new Random();

            Console.WriteLine("* Исходный массив:                                                       *");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(3, 9); 
                Console.Write(array[i] + " ");
            }

            int result = ds.Calculate(array);

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}

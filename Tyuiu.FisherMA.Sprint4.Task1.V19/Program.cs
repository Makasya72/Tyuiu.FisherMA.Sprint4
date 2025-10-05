using Tyuiu.FisherMA.Sprint4.Task1.V19.Lib;

namespace Tyuiu.FisherMA.Sprint4.Task1.V19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Фишер М. A. | ИИПб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы (ввод с клавиатуры)                            *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #19                                                             *");
            Console.WriteLine("* Выполнил: Фишер Максим Алексеевич | ИИПб-25-1                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный массив из 12 элементов, значения вводятся с клавиатуры   *");
            Console.WriteLine("* (в диапазоне от 2 до 9). Подсчитать сумму чётных элементов массива.     *");
            Console.WriteLine("***************************************************************************");

            int[] array = new int[12];
            Console.WriteLine("* Введите 12 целых чисел от 2 до 9 через пробел:                          *");

            string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < 12 && i < input.Length; i++)
            {
                array[i] = Convert.ToInt32(input[i]);
            }

            int result = ds.GetSumEven(array);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}

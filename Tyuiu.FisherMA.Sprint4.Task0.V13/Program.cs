using Tyuiu.FisherMA.Sprint4.Task0.V13.Lib;

namespace Tyuiu.FisherMA.Sprint4.Task0.V13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int[] array = { 2, 6, 2, 3, 4, 5, 4, 9, 7, 8 };
            int result = ds.GetSumEven(array);

            Console.Title = "Спринт #4 | Выполнил: Фишер М. A. | ИИПб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы                                                *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #13                                                             *");
            Console.WriteLine("* Выполнил: Фишер Максим Алексеевич | ИИПб-25-1                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан массив {2, 6, 2, 3, 4, 5, 4, 9, 7, 8}.                              *");
            Console.WriteLine("* Найти сумму всех чётных элементов массива.                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}

using Tyuiu.FisherMA.Sprint4.Task6.V2.Lib;

namespace Tyuiu.FisherMA.Sprint4.Task6.V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Фишер М. A. | ИИПб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Класс Array                                                       *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #2                                                              *");
            Console.WriteLine("* Выполнил: Фишер Максим Алексеевич | ИИПб-25-1                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан строковый массив:                                                   *");
            Console.WriteLine("* [\"Белый\", \"Черный\", \"Зеленый\", \"Синий\", \"Красный\", \"Желтый\", \"Фиолетовый\"] *");
            Console.WriteLine("* Вывести элементы, длина которых больше 5 символов.                      *");
            Console.WriteLine("***************************************************************************");

            string[] colors = { "Белый", "Черный", "Зеленый", "Синий", "Красный", "Желтый", "Фиолетовый" };

            Console.WriteLine("* Исходный массив:                                                        *");
            Array.ForEach(colors, c => Console.Write(c + " "));
            Console.WriteLine();
            Console.WriteLine("***************************************************************************");

            string[] result = ds.Calculate(colors);

            Console.WriteLine("* Элементы длиной больше 5 символов:                                      *");
            Console.WriteLine("***************************************************************************");
            Array.ForEach(result, c => Console.WriteLine(c));

            Console.ReadKey();
        }
    }
}

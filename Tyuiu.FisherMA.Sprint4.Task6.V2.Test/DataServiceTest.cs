using Tyuiu.FisherMA.Sprint4.Task6.V2.Lib;

namespace Tyuiu.FisherMA.Sprint4.Task6.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            string[] colors = { "Белый", "Черный", "Зеленый", "Синий", "Красный", "Желтый", "Фиолетовый" };

            string[] result = ds.Calculate(colors);

            string[] expected = { "Черный", "Зеленый", "Красный", "Желтый", "Фиолетовый" };

            CollectionAssert.AreEqual(expected, result);
        }
    }
}

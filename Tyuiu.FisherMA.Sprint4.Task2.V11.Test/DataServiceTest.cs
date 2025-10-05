using Tyuiu.FisherMA.Sprint4.Task2.V11.Lib;

namespace Tyuiu.FisherMA.Sprint4.Task2.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int[] array = { 3, 4, 8, 7, 5, 6, 3, 4, 8, 8, 5, 7, 6, 3, 4 };

            int result = ds.Calculate(array);
            int expected = 58; 

            Assert.AreEqual(expected, result);
        }
    }
}

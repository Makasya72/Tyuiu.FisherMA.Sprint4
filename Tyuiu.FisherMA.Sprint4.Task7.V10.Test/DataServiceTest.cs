using Tyuiu.FisherMA.Sprint4.Task7.V10.Lib;

namespace Tyuiu.FisherMA.Sprint4.Task7.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            string input = "695847142536";
            int rows = 3;
            int cols = 4;

            int result = ds.Calculate(input, rows, cols);
            int expected = 30; 

            Assert.AreEqual(expected, result);
        }
    }
}

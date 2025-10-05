using Tyuiu.FisherMA.Sprint4.Task3.V14.Lib;

namespace Tyuiu.FisherMA.Sprint4.Task3.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
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
            int expected = 7; 

            Assert.AreEqual(expected, result);
        }
    }
}

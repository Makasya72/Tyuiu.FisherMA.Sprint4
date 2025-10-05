using Tyuiu.FisherMA.Sprint4.Task5.V10.Lib;

namespace Tyuiu.FisherMA.Sprint4.Task5.V10.Test
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
                { -4, -2,  5,  7,  0 },
                {  3,  6, -1, -4,  7 },
                {  2, -3,  1,  0, -2 },
                {  5,  3, -4, -4,  4 },
                { -1,  6,  0,  2, -3 }
            };

            int result = ds.Calculate(matrix);
            int expected = 61; 

            Assert.AreEqual(expected, result);
        }
    }
}

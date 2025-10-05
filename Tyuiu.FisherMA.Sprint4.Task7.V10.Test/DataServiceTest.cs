using Tyuiu.FisherMA.Sprint4.Task7.V10.Lib;

namespace Tyuiu.FisherMA.Sprint4.Task7.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidConvertStringToMatrix()
        {
            DataService ds = new DataService();
            string input = "695847142536";
            int[,] expected =
            {
                {6, 9, 5, 8},
                {4, 7, 1, 4},
                {2, 5, 3, 6}
            };

            int[,] result = ds.ConvertStringToMatrix(input, 3, 4);

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Assert.AreEqual(expected[i, j], result[i, j]);
                }
            }
        }

        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[,] matrix =
            {
                {6, 9, 5, 8},
                {4, 7, 1, 4},
                {2, 5, 3, 6}
            };

            int result = ds.Calculate(matrix);
            int expected = 30; 

            Assert.AreEqual(expected, result);
        }
    }
}

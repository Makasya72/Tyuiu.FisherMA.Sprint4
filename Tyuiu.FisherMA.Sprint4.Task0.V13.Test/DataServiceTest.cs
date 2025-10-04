using Tyuiu.FisherMA.Sprint4.Task0.V13.Lib;

namespace Tyuiu.FisherMA.Sprint4.Task0.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumEven()
        {
            DataService ds = new DataService();
            int[] array = { 2, 6, 2, 3, 4, 5, 4, 9, 7, 8 };

            int result = ds.GetSumEven(array);
            int expected = 26;

            Assert.AreEqual(expected, result);
        }
    }
}

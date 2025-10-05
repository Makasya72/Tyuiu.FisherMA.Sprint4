using Tyuiu.FisherMA.Sprint4.Task7.V10.Lib;

namespace Tyuiu.FisherMA.Sprint4.Task7.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CalcTest()
        {
            DataService ds = new DataService();
            int n = 3, m = 4;
            string value = "695847142536";
            int wait = 38; 

            int res = ds.Calculate(n, m, value);
            Assert.AreEqual(wait, res);
        }
    }
}

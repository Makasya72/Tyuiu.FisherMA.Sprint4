﻿using Tyuiu.FisherMA.Sprint4.Task1.V19.Lib;

namespace Tyuiu.FisherMA.Sprint4.Task1.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumEven()
        {
            DataService ds = new DataService();
            int[] array = { 6, 6, 9, 6, 9, 3, 8, 2, 9, 5, 7, 4 };

            int result = ds.GetSumEven(array);
            int expected = 32; 

            Assert.AreEqual(expected, result);
        }
    }
}

using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.FisherMA.Sprint4.Task0.V13.Lib
{
    public class DataService : ISprint4Task0V13
    {
        public int GetSumEven(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    sum += array[i];
                }
            }
            return sum;
        }

        public int GetSumEvenArrEl(int[] array)
        {
            throw new NotImplementedException();
        }
    }
}

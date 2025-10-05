using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.FisherMA.Sprint4.Task3.V14.Lib
{
    public class DataService : ISprint4Task3V14
    {
        public int Calculate(int[,] array)
        {
            int row = 3; 
            int max = array[row, 0];

            for (int j = 1; j < array.GetLength(1); j++)
            {
                if (array[row, j] > max)
                {
                    max = array[row, j];
                }
            }

            return max;
        }
    }
}

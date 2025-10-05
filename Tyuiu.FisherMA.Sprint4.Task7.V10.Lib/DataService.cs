using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.FisherMA.Sprint4.Task7.V10.Lib
{
    public class DataService : ISprint4Task7V10
    {
     
        public int Calculate(string input, int rows, int cols)
        {
            int[,] matrix = new int[rows, cols];
            int index = 0;
            int sum = 0;

           
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    int num = int.Parse(input[index].ToString());
                    matrix[i, j] = num;

                    if (num % 2 != 0)
                    {
                        sum += num;
                    }

                    index++;
                }
            }

            return sum;
        }
    }
}

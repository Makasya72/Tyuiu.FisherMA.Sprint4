using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.FisherMA.Sprint4.Task7.V10.Lib
{
    public class DataService : ISprint4Task7V10
    {
        public int[,] ConvertStringToMatrix(string input, int rows, int cols)
        {
            int[,] matrix = new int[rows, cols];
            int index = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (index < input.Length)
                    {
                        matrix[i, j] = int.Parse(input[index].ToString());
                        index++;
                    }
                }
            }

            return matrix;
        }

        public int Calculate(int[,] matrix)
        {
            int sum = 0;
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i, j] % 2 != 0)
                    {
                        sum += matrix[i, j];
                    }
                }
            }

            return sum;
        }

        public int Calculate(int n, int m, string value)
        {
            int[,] matrix = ConvertStringToMatrix(value, n, m);
            return Calculate(matrix);
        }
    }
}
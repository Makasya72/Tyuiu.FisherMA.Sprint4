using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.FisherMA.Sprint4.Task6.V2.Lib
{
    public class DataService : ISprint4Task6V2
    {
        public string[] Calculate(string[] array)
        {
            
            string[] filtered = Array.FindAll(array, s => s.Length > 5);
            return filtered;
        }
    }
}

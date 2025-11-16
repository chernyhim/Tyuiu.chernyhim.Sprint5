using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
namespace Tyuiu.chernyhim.Sprint5.Task0.V1.Lib
{
    public class DataService : ISprint5Task0V1
    {
        public string SaveToFileTextData(int x)
        {
            string path = Path.Combine(Path.GetTempPath(),"OutPutFileTask0.txt");
            double z = x * x * x + 2 * x * x + 5 * x + 4;
            File.WriteAllText(path, Convert.ToString(z));
            return path;
        }
    }
}

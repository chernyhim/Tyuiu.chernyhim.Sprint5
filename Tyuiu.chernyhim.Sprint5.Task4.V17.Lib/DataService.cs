using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
namespace Tyuiu.chernyhim.Sprint5.Task4.V17.Lib
{
    public class DataService : ISprint5Task4V17
    {
        public double LoadFromDataFile(string path)
        {
            string strx = File.ReadAllText(path);
            double strxd = Convert.ToDouble(strx);
            double result = Math.Round((Math.Sin(2/(3*strxd))+strxd*strxd),3);
            return result;
        }
    }
}

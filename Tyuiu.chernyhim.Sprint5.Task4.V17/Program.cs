using Tyuiu.chernyhim.Sprint5.Task4.V17.Lib;
using System.IO;
namespace Tyuiu.chernyhim.Sprint5.Task4.V17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint5\InPutDataFileTask4V17.txt";
            double res = ds.LoadFromDataFile(path);
            Console.WriteLine(res);
        }
    }
}

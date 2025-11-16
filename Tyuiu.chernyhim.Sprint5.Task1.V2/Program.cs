using Tyuiu.chernyhim.Sprint5.Task1.V2.Lib;
using System.IO;
namespace Tyuiu.chernyhim.Sprint5.Task1.V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input start value: ");
            int start = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Input stop value: ");
            int end = Convert.ToInt16(Console.ReadLine());
            DataService ds = new DataService();
            string path = ds.SaveToFileTextData(start, end);
            FileInfo fileinfo = new FileInfo(path);
            string res = ds.SaveToFileTextData(start, end);
            Console.WriteLine("File:" + res);
            Console.WriteLine("Created");
        }
    }
}

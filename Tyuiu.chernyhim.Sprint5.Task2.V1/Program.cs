using Tyuiu.chernyhim.Sprint5.Task2.V1.Lib;
using System.IO;
namespace Tyuiu.chernyhim.Sprint5.Task2.V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int[,] mtrx = new int[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    Console.WriteLine($"Input [{i + 1},{j + 1}] element");
                    mtrx[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            string path = ds.SaveToFileTextData(mtrx);
            FileInfo fileInfo = new FileInfo(path); 
            string res = ds.SaveToFileTextData(mtrx);
            Console.WriteLine("File:" + res);
            Console.WriteLine("Created");
        }
    }
}

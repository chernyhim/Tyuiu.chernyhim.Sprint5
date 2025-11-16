using Tyuiu.chernyhim.Sprint5.Task0.V1.Lib;
namespace Tyuiu.chernyhim.Sprint5.Task0.V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int x = 5;
            Console.WriteLine("x = "+x);
            string res = ds.SaveToFileTextData(x);
            Console.WriteLine("File:" + res); 
            Console.WriteLine("Created"); 
        } 
    }
}

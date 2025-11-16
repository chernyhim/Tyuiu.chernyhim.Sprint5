using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.chernyhim.Sprint5.Task1.V2.Lib
{
    public class DataService : ISprint5Task1V2
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt");
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            if (fileExists)
            {
                File.Delete(path);
            }
            double y;
            string stry;
            for(int  x = startValue; x <= stopValue; x++)
            {
                if (Math.Cos(x) - 2 * x != 0)
                {
                    y = Math.Round((2 * x - 3) / (Math.Cos(x) - 2 * x) + 5 * x - 6, 2);
                    stry = Convert.ToString(y);
                }
                else
                {
                    y = 0;
                    stry = Convert.ToString(y);
                }

                if (x != stopValue)
                {
                    File.AppendAllText(path, stry + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(path, stry);
                }
            }
            return path;
        }
    }
}

using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.chernyhim.Sprint5.Task2.V1.Lib
{
    public class DataService : ISprint5Task2V1
    {
        public string SaveToFileTextData(int[,] matrix)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask2.cvs");
            FileInfo fileinfo = new FileInfo(path);
            if (fileinfo.Exists)
            {
                fileinfo.Delete();
            }
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i,j] % 2 != 0)
                    {
                        matrix[i,j] = 0;
                    }
                }
            }
            string str = "";
            for (int i = 0;i < matrix.GetLength(0); i++)
            {
                for (int j = 0;j < matrix.GetLength(1); j++)
                {
                    if (j != cols - 1)
                    {
                        str = str + matrix[i, j] + ";";
                    }
                    else
                    {
                        str = str + matrix[i, j];
                    }
                }
                if (i != rows - 1)
                {
                    File.AppendAllText(path, str + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(path, str);
                }

                str = "";

            }
            return path;
        }
    }
}

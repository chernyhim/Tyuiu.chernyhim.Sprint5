using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
using System.Text;
namespace Tyuiu.chernyhim.Sprint5.Task3.V11.Lib
{
    public class DataService : ISprint5Task3V11
    {
        public string SaveToFileTextData(int x)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask3.bin");
            FileInfo fileinfo = new FileInfo(path);
            if (fileinfo.Exists)
            {
                fileinfo.Delete();
            }
            double y;
            y = Math.Round((4 - Math.Pow(x, 3)) / Math.Pow(x, 2), 3);
            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate), Encoding.UTF8))
            {
                writer.Write(BitConverter.GetBytes(y));
            }
            return path;
        }
    }
}

using Tyuiu.chernyhim.Sprint5.Task2.V1.Lib;
using System.IO;
namespace Tyuiu.chernyhim.Sprint5.Task2.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] mtrx = { { 6, 9, 4 },
                            { 7, 2, 4 },
                            { 4, 8, 3 } };
            string path = ds.SaveToFileTextData(mtrx);
            FileInfo fileInfo = new FileInfo(path);
            Assert.IsTrue(fileInfo.Exists);
        }
    }
}

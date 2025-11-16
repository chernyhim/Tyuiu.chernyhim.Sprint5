using Tyuiu.chernyhim.Sprint5.Task0.V1.Lib;
using System.IO;
namespace Tyuiu.chernyhim.Sprint5.Task3.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 3;
            string path = ds.SaveToFileTextData(x);
            FileInfo fileInfo = new FileInfo(path);
            Assert.IsTrue(fileInfo.Exists);
        }
    }
}

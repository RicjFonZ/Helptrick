using Helptrick.ViewModel;
using NUnit.Framework;

namespace Helptrick.Test
{
    [TestFixture, Category("LongRunning")]
    public class Test
    {
        [Test, Category("Long")]
        public void Test1()
        {
            Assert.AreEqual("teste2", TestClass.GetString());

        }
    }
}

using Helptrick.ViewModel;
using NUnit.Framework;

namespace Helptrick.Test
{
    [TestFixture]
    public class Test
    {
        [Test]
        public void Test1()
        {
            Assert.AreEqual("teste2", TestClass.GetString());

        }
    }
}

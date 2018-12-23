using NUnit.Framework;

namespace Helptrick.Tests
{
    class TestClass
    {
        [TestFixture, Category("LongRunning")]
        public class Test
        {
            [Test, Category("Long")]
            public void Test1()
            {
                Assert.AreEqual("teste2", ViewModel.TestClass.GetString());

            }
        }
    }
}

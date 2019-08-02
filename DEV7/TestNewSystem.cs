using NUnit.Framework;
namespace DEV7
{
    [TestFixture]
    class TestNewSystem
    {
        [TestCase]
        public void TestConvertCountSystem()
        {
            NewSystem test = new NewSystem();
            Assert.AreEqual("0", test.ConvertCountSystem("0", 6));
            Assert.AreEqual("111", test.ConvertCountSystem("7", 2));
            Assert.AreEqual("-1", test.ConvertCountSystem("-1", 2));
            Assert.AreEqual("1DB1F927", test.ConvertCountSystem("2147483647", 20));
            Assert.AreEqual("-1DB1F927", test.ConvertCountSystem("-2147483647", 20));
            Assert.AreEqual("-A", test.ConvertCountSystem("-10", 12));
        }
    }
    [TestFixture]
    class TestCheckValue
    {
        [TestCase]
        public void TestCheckCorrectValues()
        {
            CheckValue test = new CheckValue();
            Assert.AreEqual(false, test.CheckCorrectValues("",2));
            Assert.AreEqual(false, test.CheckCorrectValues("5", 0));
            Assert.AreEqual(false, test.CheckCorrectValues("", 0));
            Assert.AreEqual(true, test.CheckCorrectValues("7", 2));
            Assert.AreEqual(false, test.CheckCorrectValues("7", 1));
            Assert.AreEqual(false, test.CheckCorrectValues("7", 21));
        }
    }
}

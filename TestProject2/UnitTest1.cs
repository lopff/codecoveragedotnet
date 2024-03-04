namespace TestProject2
{
    [TestClass]
    public class UnitTest1
    {
        

        [TestMethod]
        public void TestIsANumber()
        {
            Project2.Class1 class1 = new Project2.Class1();
            Assert.IsTrue(class1.isANumber("123"));
            Assert.IsTrue(class1.isANumber("-123.1456"));
            Assert.IsFalse(class1.isANumber("-E123.1456"));
            Assert.IsFalse(class1.isANumber("O"));
        }
    }
}
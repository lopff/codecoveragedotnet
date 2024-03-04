namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        Project1.Class1 class1 = new Project1.Class1();

        [TestMethod]
        public void TestSumNums()
        {
            Assert.AreEqual(class1.SumNums(new int[] { 2, 2 }), 4);
            Assert.AreEqual(class1.SumNums(new int[] { 2, 4, 8 }), 14);
        }

        [TestMethod]
        public void AverageNums()
        {
            Assert.AreEqual(class1.AverageNums(new double[] { 2, 2 }), 2);
            Assert.AreEqual(class1.AverageNums(new double[] { 2, 4, 2, 4 }), 3);
        }
    }
}
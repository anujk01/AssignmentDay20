using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AssignmentDay20
{
    [TestClass]
    public class UnitTest6
    {
        [TestMethod]
        public void Reflection_Return_Method()
        {
            string expected = "happy";
            MoodAnalyserFactory factory = new MoodAnalyserFactory();
            string actual = factory.InvokeAnalyserMethod("happy", "AnalyzeMood");
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Reflection_Return_Invalid_Method()
        {
            string expected = "happy";
            MoodAnalyserFactory factory = new MoodAnalyserFactory();
            string actual = factory.InvokeAnalyserMethod("happy", "Analyze");

            Assert.AreEqual(expected, actual);
        }
    }
}
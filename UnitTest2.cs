using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AssignmentDay20
{
    [TestClass]
    public class UnitTest2
    {
        [TestInitialize]
        public void SetUp()
        {
            UC2_HandleException moodanalyzer = new UC2_HandleException(string.Empty);
        }
        [TestMethod]
        public void TestMethodForHappyMood()

        {
            string expected = "Happy Mood";
            UC2_HandleException moodAnalyser = new UC2_HandleException("I am in happy Mood");
            string actual = moodAnalyser.Analyzer();
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethodForSadMood()

        {
            string expected = "sad";
            UC2_HandleException moodAnalyser = new UC2_HandleException("I am in sad Mood");
            string actual = moodAnalyser.Analyzer();
            Assert.AreEqual(expected, actual);
        }
    }
}

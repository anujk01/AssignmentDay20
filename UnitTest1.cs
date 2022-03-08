using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AssignmentDay20
{
    [TestClass]
    public class UnitTest1
    {
        UC1_MoodAnalyzer moodAnalyser;
        string message = " I am in happy Mood";
        [TestInitialize]
        public void SetUp()
        {
            moodAnalyser = new UC1_MoodAnalyzer(message);
        }
        [TestMethod]
        public void TestMethodForHappyMood()

        {
            string expected = "happy";

            string actual = moodAnalyser.Analyzer();
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethodForSadMood()

        {
            string expected = "sad";
            UC1_MoodAnalyzer moodAnalyser = new UC1_MoodAnalyzer("I am in sad Mood");
            string actual = moodAnalyser.Analyzer();
            Assert.AreEqual(expected, actual);
        }
    }
}

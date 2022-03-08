using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AssignmentDay20
{
    [TestClass]
    public class UnitTest3
    {
        [TestInitialize]
        public void SetUp()
        {
            UC3_CustomException moodanalyzer = new UC3_CustomException(string.Empty);
        }
        [TestMethod]
        public void TestMethodForHappyMood()

        {
            string expected = "happy";
            UC3_CustomException moodAnalyzer = new UC3_CustomException("I am in happy Mood");
            string actual = moodAnalyzer.AnalyzeMood();
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethodForSadMood()

        {
            string expected = "sad";
            UC3_CustomException moodAnalyzer = new UC3_CustomException("I am in sad Mood");
            string actual = moodAnalyzer.AnalyzeMood();
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethodForNullMood()

        {
            string expected = "happy";
            UC3_CustomException moodAnalyzer = new UC3_CustomException("I am in happy Mood");
            string actual = moodAnalyzer.AnalyzeMood();
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethodForCustomizedNullException()

        {
            string expected = "Mood should not be null";
            try
            {

                UC3_CustomException moodAnalyzer = new UC3_CustomException(null);
                moodAnalyzer.AnalyzeMood();
            }
            catch (CustomException ex)
            {
                Assert.AreEqual(expected, ex.Message);
            }
        }
        [TestMethod]
        public void TestMethodForCustomizedEmptyException()

        {
            string expected = "Mood should not be empty";
            try
            {

                UC3_CustomException moodAnalyzer = new UC3_CustomException(string.Empty);
                moodAnalyzer.AnalyzeMood();
            }
            catch (CustomException ex)
            {
                Assert.AreEqual(expected, ex.Message);
            }

        }
    }
}
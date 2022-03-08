using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AssignmentDay20
{
    [TestClass]
    public class UnitTest5
    {
        [TestMethod]
        public void ParameterConstructor()
        {
            string message = "I am in happy mood";
            UC5_ParameterConstructor expected = new UC5_ParameterConstructor(message);
            object actual = null;
            try
            {
                MoodAnalyserFactory factory = new MoodAnalyserFactory();
                actual = factory.CreateParameterizedConstructor("ParameterConstructor", "MoodAnalyser", message);

            }
            catch (CustomException ex)
            {
                throw new System.Exception(ex.Message);
            }
            actual.Equals(expected);
        }


        [TestMethod]
        public void InvalidClass()
        {
            string message = "I am in happy mood";
            UC5_ParameterConstructor expected = new UC5_ParameterConstructor(message);
            object actual = null;
            try
            {
                MoodAnalyserFactory factory = new MoodAnalyserFactory();
                actual = factory.CreateParameterizedConstructor("ParameterConstructor", "MoodAnalyser", message);

            }
            catch (CustomException actual1)
            {
                Assert.AreEqual(expected, actual1.Message);
            }
        }

    }
}
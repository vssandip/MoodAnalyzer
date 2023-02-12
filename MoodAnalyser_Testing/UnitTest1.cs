using MoodAnalyzer;

namespace MoodAnalyser_Testing
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string message = "i am sad";
            Mood a = new Mood(message);
            string mood = a.check();
            Assert.AreEqual(mood, "sad");
        }
        [TestMethod]
        public void TestMethod2()
        {
            string message = "Happy";
            Mood1 a = new Mood1(message);
            string mood = a.check();
            Assert.AreEqual(mood, "happy");
        }
        [TestMethod]
        public void TestMethod3()
        {
            string message = "i am any mood";
            Mood2 a = new Mood2(message);
            string mood = a.check();
            Assert.AreEqual(mood, "happy");
        }
        [TestMethod]

        public void TestMethod4()
        {
            Mood analyser = new Mood(null);
            try
            {


                string message = analyser.check();
                Assert.AreEqual(message, "happy");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }

}
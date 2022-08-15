using ReflectionMoodAnalyser;

namespace MoodAnalyserTest
{
    public class Tests
    {

        MoodAnalyseFactory moodAnalyserfactory;
        [SetUp]
        public void Setup()
        {
            moodAnalyserfactory = new MoodAnalyseFactory();
        }

        /// <summary>
        /// TC-4.1 Given MoodAnalyse Class Name Should Return MoodAnalyser Object
        /// </summary>
        [Test]
        public void MoodAnalyserClassName_ShouldReturn_MoodAnalyserObject()
        {
            string message = null;
            object expected = new MoodAnalyser(message);
            object obj = MoodAnalyseFactory.CreateMoodAnalyse("ReflectionMoodAnalyser.MoodAnalyser", "MoodAnalyser");
            expected.Equals(obj);
        }

        /// <summary>
        /// TC-4.2 Given MoodAnalyse Class Name When Improper Should Throw Exception
        /// </summary>,
        [Test]
        public void MoodAnalyserClassName_Improper_Should_ThrowMoodAnalyserException()
        {
            object obj = null;

            string expected = "Class is Not found";
            try
            {
                obj = MoodAnalyseFactory.CreateMoodAnalyse("ReflectionMoodAnalyser.Mood", "Mood");
            }
            catch (MoodAnalyserCustomException exception)
            {
                Assert.AreEqual(expected, exception.Message);
            }
        }

        /// <summary>
        /// TC-4.3 Given MoodAnalyse Class Name When Constructor is Improper Should Throw Exception
        /// </summary >
        [Test]
        public void MoodAnalyserClassName_ConstructorIsImproper_Should_ThrowMoodAnalyserException()
        {
            object obj = null;

            string expected = "Constructor is Not found";
            try
            {
                obj = MoodAnalyseFactory.CreateMoodAnalyse("ReflectionMoodAnalyser.MoodAnalyser", "AnalyserMood");
            }
            catch (MoodAnalyserCustomException exception)
            {
                Assert.AreEqual(expected, exception.Message);
            }
        }

    }
}
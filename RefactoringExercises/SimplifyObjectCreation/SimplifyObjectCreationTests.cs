using NUnit.Framework;

namespace RefactoringExercises.SimplifyObjectCreation
{
    [TestFixture]
    public class SimplifyObjectCreationTests
    {
        private Pupil _result;

        [SetUp]
        public void SetUp()
        {
            var pupilFinder = new PupilFinder();
            _result = pupilFinder.Find("Sammy Shah");
        }

        [Test]
        public void Retrieves_correct_pupil_details()
        {
            Assert.That(_result.Name, Is.EqualTo("Samira Shah"));
            Assert.That(_result.Nickname, Is.EqualTo("Sammy"));
            Assert.That(_result.BestFriend, Is.EqualTo("Aoife O’Reilly"));
        }

        [Test]
        public void Retrieves_correct_results()
        {
            Assert.That(_result.MathsResult, Is.EqualTo("C"));
            Assert.That(_result.EnglishResult, Is.EqualTo("A"));
            Assert.That(_result.RunningResult, Is.EqualTo("A*"));
        }
    }
}
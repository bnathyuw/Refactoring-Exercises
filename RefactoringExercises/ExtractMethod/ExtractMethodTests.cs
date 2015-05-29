using System;
using NUnit.Framework;

namespace RefactoringExercises.ExtractMethod
{
    [TestFixture]
    public class ExtractMethodTests : IThink
    {
        private const string DefaultFavouriteColour = "yellow";
        private const DayOfWeek DefaultDayOfWeek = DayOfWeek.Monday;
        private bool _hasThoughtLongAndHard;
        private UltimateQuestion _ultimateQuestion;

        [SetUp]
        public void SetUp()
        {
            _hasThoughtLongAndHard = false;

            _ultimateQuestion = new UltimateQuestion(this);
        }

        [Test]
        public void Thinks_long_and_hard()
        {
            _ultimateQuestion.GetAnswer(DefaultDayOfWeek, DefaultFavouriteColour);
            
            Assert.That(_hasThoughtLongAndHard, Is.True);
        }

        [TestCase(DayOfWeek.Monday)]
        [TestCase(DayOfWeek.Tuesday)]
        [TestCase(DayOfWeek.Wednesday)]
        [TestCase(DayOfWeek.Thursday)]
        [TestCase(DayOfWeek.Friday)]
        [TestCase(DayOfWeek.Saturday)]
        [TestCase(DayOfWeek.Sunday)]
        public void Gives_expected_answer_for_each_day(DayOfWeek day)
        {
            var actual = _ultimateQuestion.GetAnswer(day, DefaultFavouriteColour);
            
            const int expected = 42;
            Assert.That(actual, Is.EqualTo(expected));
        }

        [TestCase("violet")]
        [TestCase("indigo")]
        [TestCase("blue")]
        [TestCase("green")]
        [TestCase("yellow")]
        [TestCase("orange")]
        [TestCase("red")]
        public void Gives_expected_answer_for_each_colour(string favouriteColour)
        {
            var actual = _ultimateQuestion.GetAnswer(DefaultDayOfWeek, favouriteColour);

            const int expected = 42;
            Assert.That(actual, Is.EqualTo(expected));
        }

        public void ThinkLongAndHard()
        {
            _hasThoughtLongAndHard = true;
        }
    }
}
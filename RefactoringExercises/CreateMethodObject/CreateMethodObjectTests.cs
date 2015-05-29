using System;
using NUnit.Framework;

namespace RefactoringExercises.CreateMethodObject
{
    [TestFixture]
    public class CreateMethodObjectTests : IAuthenticate
    {
        private string _actualPassword;
        private LogInWidget _logInWidget;

        [SetUp]
        public void SetUp()
        {
            _actualPassword = null;

            _logInWidget = new LogInWidget();
        }

        [Test]
        public void Logs_in_with_correct_password()
        {
            _logInWidget.LogIn(this, "Thomas Harold Flowers", new DateTime(1905, 12, 22), "Poplar");

            Assert.That(_actualPassword, Is.EqualTo("22Flowers12Poplar1905"));
        }

        public void Authenticate(string password)
        {
            _actualPassword = password;
        }
    }
}
using System;
using System.Linq;

namespace RefactoringExercises.CreateMethodObject
{
    public class LogInWidget
    {
        public void LogIn(IAuthenticate authenticator, string name, DateTime dob, string townOfBirth)
        {
            var surname = name.Split(' ').Last();
            var password = string.Format("{0:dd}{1}{0:MM}{2}{0:yyyy}", dob, surname, townOfBirth);

            authenticator.Authenticate(password);
        }
    }
}
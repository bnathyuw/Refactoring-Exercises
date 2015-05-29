CREATE METHOD OBJECT
====================

BACKGROUND
----------

This code sample is designed to let you practise creating method objects from closely related parameters.

The class to refactor, LogInWidget, has been created to sidestep problems when users forget their passwords. It generates a password using a highly secure algorithm: combining the user’s date of birth with their surname and town of birth.

The test in CreateMethodObjectTests ensures that the correct password is passed into the Authenticator.

QUESTIONS
---------

1. Do any of the parameters of LogIn form a logical group?
2. How can you use Create Method Object to deal with these smells?
3. Can you perform this refactoring using just ReSharper shortcuts?
4. Are there any remaining parameters?
5. How could you deal with them?
6. Can you further improve the code using other refactorings?

Create a single project with a test class.

    dotnet new console -n BowlingGame02
    dotnet add package xunit
    dotnet add package xunit.runner.visualstudio
    vim BowlingGameTest.cs
    dotnet test // no tests found

    BowlingGame
        BowlingGameTest.cs

Add the first test, `testGutterGame()` 

Red (no Game)
Green

Red (no roll)

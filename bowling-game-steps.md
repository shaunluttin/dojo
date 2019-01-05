
01 Create test project; rename class/file.

    dotnet new xunit --name BowlingGameTest
    vim */*.cs
    :Ex 
    dotnet watch --project BowlingGameTest test

02 Add testGutterGame; build fails: 'Game' could not be found

03 Add lib project; rename class/file; add reference

    dotnet new classlib --name BowlingGame
    :Ex
    dotnet add BowlingGameTest\BowlingGameTest.csproj reference BowlingGame\BowlingGame.csproj

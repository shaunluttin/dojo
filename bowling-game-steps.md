
01 Create test project; rename class/file.

    dotnet new xunit --name BowlingGameTest
    vim */*.cs
    :Ex 
    dotnet watch --project BowlingGameTest test

02 Fail testGutterGame; 'Game' could not be found

03 Add lib project; rename class/file; add reference; 1/1

    dotnet new classlib --name BowlingGame
    :Ex
    dotnet add BowlingGameTest\BowlingGameTest.csproj reference BowlingGame\BowlingGame.csproj

04 Fail testAllOnes: 

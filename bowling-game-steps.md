
## Vim Tips

Ex:
vsplit

## Standard Commits

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

04 Fail testAllOnes: Expected 20 Actual 0

05 Pass testAllOnes

06 Refactor shared test code

07 Fail testSpare: Expected 16 Actual 13

08 Refactor/redesign in preparation for testSpare

09 Use const not magic number (explanatory variable)

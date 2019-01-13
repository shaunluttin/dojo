
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

07 Fail testOneSpare: Expected 16 Actual 13

08 Refactor/redesign in preparation for testOneSpare

09 Use const not magic number (explanatory variable)

10 Pass testOneSpare

11 Refactor Game: explanatory variables/methods & comments

12 Refactor Tests: explanatory method

13 Refactor/redesign in preparation for testOneStrike

14 Pass testOneStrike

15 Factor out IsSpare, IsStrike, FramesPerGame

16 Pass testPerfectGame. Done!

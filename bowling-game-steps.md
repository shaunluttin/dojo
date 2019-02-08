
## My Toolsets

* ConEmu / Vim / PowerShell / .NET Core

## My Personal Steps

1. Open three console windows in ConEmu (these could be Vim tabs).
  1. notes
  2. code editing
  3. test runner
  4. optionally: commits
2. Then follow the "standard commits"

## Vim Tips

Ex:
vsplit

## Directory Structure

    BowlingGameXX
      GameTest.cs
      Game.cs
      BowlingGame.csproj

For the demo, keep the test and implementation in the same project.
In a production app, these would usually be in separate projects.

## Standard Commits

01 Create test project; rename file/class; start watcher.

    dotnet new xunit --name BowlingGameXX
    vim *.cs
    dotnet watch test

02 Fail testGutterGame: 'Game' could not be found

03 Pass testGutterGame: add Game.cs with Roll & Score

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

16 Factor out SpareBonus, StrikeBonus, and FrameSum

17 Pass testPerfectGame. Done!


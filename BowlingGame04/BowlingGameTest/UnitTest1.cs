using System;
using Xunit;
using BowlingGame;

namespace BowlingGameTest
{
    public class UnitTest1
    {
        [Fact]
        public void testGutterGame() 
        {
            var g = new Game();
            for(var i = 0; i < 20; ++i)
                g.roll(0);
        }
    }
}
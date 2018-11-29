using System;
using Xunit;
using BowlingGame;

namespace BowlingGameTest
{
    public class BowlingGameTest
    {
        [Fact]
        public void testGutterGame()
        {
            var g = new Game();
            for (var i = 0; i < 20; ++i)
                g.roll(0);

            Assert.Equal(0, g.score());
        }

        [Fact]
        public void testAllOnes()
        {
            var g = new Game();
            for (var i = 0; i < 20; ++i)
                g.roll(1);

            Assert.Equal(20, g.score());
        }
    }
}

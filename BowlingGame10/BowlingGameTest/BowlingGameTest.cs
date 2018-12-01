using System;
using Xunit;
using BowlingGame;

namespace BowlingGameTest
{
    public class BowlingGameTest 
    {
        private Game g;

        public BowlingGameTest()
        {
            g = new Game();
        }

        [Fact]
        public void testGutterGame()
        {
            for (var i = 0; i < 20; ++i)
                g.roll(0);

            Assert.Equal(0, g.score());
        }

        [Fact]
        public void testAllOnes()
        {
            for (var i = 0; i < 20; ++i)
                g.roll(1);

            Assert.Equal(20, g.score());
        }
    }
}

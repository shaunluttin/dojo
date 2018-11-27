using System;
using Xunit;
using BowlingGame;

namespace BowlingGameTest
{
    public class UnitTest1
    {
        private Game g;

        private void setup()
        {
            g = new Game();
        }

        [Fact]
        public void testGutterGame() 
        {
            setup();
            for(var i = 0; i < 20; ++i)
                g.roll(0);

            var score = g.score();
            Assert.Equal(0, score);
        }

        [Fact]
        public void testAllOnes()
        {
            setup();
            for(var i = 0; i < 20; ++i)
                g.roll(1);

            var score = g.score();
            Assert.Equal(20, score);
        }
    }
}

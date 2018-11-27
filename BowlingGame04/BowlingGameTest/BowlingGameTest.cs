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

        private void rollMany(int rolls, int pinsPerRoll)
        {
            for(var i = 0; i < rolls; ++i)
                g.roll(pinsPerRoll);
        }

        [Fact]
        public void testGutterGame() 
        {
            setup();
            rollMany(20, 0);

            var score = g.score();
            Assert.Equal(0, score);
        }

        [Fact]
        public void testAllOnes()
        {
            setup();
            rollMany(20, 1);

            var score = g.score();
            Assert.Equal(20, score);
        }
    }
}

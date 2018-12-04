using System;
using Xunit;
using BowlingGame;

namespace BowlingGameTest
{
    public class BowlingGameTest
    {
        private Game _g;

        public BowlingGameTest()
        {
            _g = new Game();
        }

        [Fact]
        public void testGutterGame()
        {
            rollMany(20, 0);
            Assert.Equal(0, _g.score());
        }

        [Fact]
        public void testAllOnes()
        {
            rollMany(20, 1);
            Assert.Equal(20, _g.score());
        }

        private void rollMany(int rolls, int pins)
        {
            for (var i = 0; i  < rolls; i++) // ugly magic number 20
                _g.roll(pins);
        }
    }
}

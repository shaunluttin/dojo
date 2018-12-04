using System;
using Xunit;
using BowlingGame;

namespace BowlingGameTest
{
    public class BowlingGameTest
    {
        private Game _g;

        private const int RollsPerGame = 20;

        public BowlingGameTest()
        {
            _g = new Game();
        }

        [Fact]
        public void testGutterGame()
        {
            rollMany(RollsPerGame, 0);
            Assert.Equal(0, _g.score());
        }

        [Fact]
        public void testAllOnes()
        {
            rollMany(RollsPerGame, 1);
            Assert.Equal(RollsPerGame, _g.score());
        }

        [Fact]
        public void testOneSpare()
        {
            _g.roll(5);
            _g.roll(5);
            _g.roll(3);
            rollMany(17, 0);
            Assert.Equal(16, _g.score());
        }

        private void rollMany(int rolls, int pins)
        {
            for (var i = 0; i  < rolls; i++) 
                _g.roll(pins);
        }
    }
}

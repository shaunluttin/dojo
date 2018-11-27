using System;
using Xunit;
using BowlingGame;

namespace BowlingGameTest
{
    public class BowlingGameTest
    {
        private Game _g;

        private void setup()
        {
            _g = new Game(); 
        }

        private void rollMany(int number, int pins)
        {
            for (var i = 0; i < number; ++i)
                _g.roll(pins);
        }

        [Fact]
        public void testGutterGame()
        {
            setup();
            rollMany(20, 0);
            Assert.Equal(0, _g.score());
        }

        [Fact]
        public void testAllOnes()
        {
            setup();
            rollMany(20, 1);
            Assert.Equal(20, _g.score());
        }
    }
}

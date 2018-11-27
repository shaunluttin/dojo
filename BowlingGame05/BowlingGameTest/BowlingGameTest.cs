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

        private void rollMany(int number, int pins)
        {
            for (var i = 0; i < number; ++i)
                _g.roll(pins);
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

        [Fact]
        public void testOneSpare()
        {
            _g.roll(5); 
            _g.roll(5); // spare
            _g.roll(3); 
            rollMany(17, 0);
            Assert.Equal(16, _g.score());
        }
    }
}

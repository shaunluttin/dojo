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

        [Fact]
        public void testGutterGame()
        {
            setup();
            for (var i = 0; i < 20; ++i)
                _g.roll(0);

            Assert.Equal(0, _g.score());
        }

        [Fact]
        public void testAllOnes()
        {
            setup();
            for (var i = 0; i < 20; ++i)
                _g.roll(1);

            Assert.Equal(20, _g.score());
        }
    }
}

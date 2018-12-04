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
            for (var i = 0; i  < 20; i++) // ugly magic number 20
                _g.roll(0);

            Assert.Equal(0, _g.score());
        }

        [Fact]
        public void testAllOnes()
        {
            for (var i = 0; i  < 20; i++) // ugly magic number 20
                _g.roll(1);

            Assert.Equal(20, _g.score());
        }
    }
}

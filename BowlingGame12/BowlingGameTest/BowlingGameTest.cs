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
            this._g = new Game();
        }

        [Fact]
        public void testGutterGame()
        {
            RollMany(20, 0);

            Assert.Equal(0, this._g.Score());
        }

        [Fact]
        public void testAllOnes()
        {
            RollMany(20, 1);

            Assert.Equal(20, this._g.Score());
        }

        private void RollMany(int rolls, int pins)
        {
            for (var i = 0; i < rolls; ++i) 
            {
                this._g.Roll(pins); 
            }
        }
    }
}

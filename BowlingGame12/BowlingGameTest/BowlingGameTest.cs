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
            for (var i = 0; i < 20; ++i) 
            {
                this._g.Roll(0); 
            }

            Assert.Equal(0, this._g.Score());
        }

        [Fact]
        public void testAllOnes()
        {
            for (var i = 0; i < 20; ++i) 
            {
                this._g.Roll(1); 
            }

            Assert.Equal(20, this._g.Score());
        }
    }
}

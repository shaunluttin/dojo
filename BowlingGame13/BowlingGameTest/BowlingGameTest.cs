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
            // arrange
            _g = new Game();
        }

        [Fact]
        public void testGutterGame()
        {
            // act
            RollMany(20, 0);

            // assert
            Assert.Equal(0, _g.Score());
        }

        [Fact]
        public void testAllOnes()
        {
            // act
            RollMany(20, 1);

            // assert
            Assert.Equal(20, _g.Score());
        }

        private void RollMany(int rolls, int pins)
        {
            for (var i = 0; i < rolls; ++i) {
                _g.Roll(pins);
            }
        }
    }
}

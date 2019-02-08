using System;
using Xunit;

namespace BowlingGame15
{
    public class GameTest
    {
        private Game _game;

        public GameTest() 
        {
            _game = new Game();
        }

        [Fact]
        public void TestGutterGame()
        {
            RollMany(20, 0);

            Assert.Equal(0, _game.Score());
        }

        [Fact]
        public void TestAllOnes()
        {
            RollMany(20, 1);

            Assert.Equal(20, _game.Score());
        }

        private void RollMany(int rolls, int pins)
        {
            for (var i = 0; i < rolls; i++) {
                _game.Roll(pins);
            }
        }
    }
}

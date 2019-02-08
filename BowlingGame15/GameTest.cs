using System;
using Xunit;

namespace BowlingGame15
{
    public class GameTest
    {
        [Fact]
        public void testGutterGame()
        {
            var game = new Game();

            for (var i = 0; i < 20; i++) {
                game.Roll(0);
            }

            Assert.Equal(0, game.Score());
        }

        [Fact]
        // ugly repetition
        public void testAllOnes()
        {
            var game = new Game();

            for (var i = 0; i < 20; i++) {
                game.Roll(1);
            }

            Assert.Equal(20, game.Score());
        }
    }
}

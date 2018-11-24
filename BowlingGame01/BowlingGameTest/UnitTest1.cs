using System;
using Xunit;
using BowlingGame;

namespace BowlingGameTest
{
    public class UnitTest1
    {
        [Fact]
        public void testGutterGame()
        {
            var game = new Game();
            for (var i = 0; i < 20; i++) {
                game.roll(0);
            }

            Assert.Equal(0, game.score());
        }
    }
}

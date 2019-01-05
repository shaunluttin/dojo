using System;
using Xunit;

namespace BowlingGameTest
{
    public class BowlingGameTest
    {
        [Fact]
        public void testGutterGame()
        {
            // arrange
            var g = new Game();

            // act
            for (var i = 0; i < 20; ++i) {
                g.Roll(0);
            }

            // assert
            Assert.Equal(0, g.Score());
        }
    }
}

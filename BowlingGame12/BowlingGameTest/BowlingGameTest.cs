using System;
using Xunit;
using BowlingGame;

namespace BowlingGameTest
{
    public class BowlingGameTest
    {
        [Fact]
        public void testGutterGame()
        {
            var g = new Game();

            for (var i = 0; i < 20; ++i) 
            {
                g.Roll(0); 
            }

            Assert.Equal(0, g.Score());
        }

        [Fact]
        public void testAllOnes()
        {
            var g = new Game(); // duped code

            for (var i = 0; i < 20; ++i) 
            {
                g.Roll(1); 
            }

            Assert.Equal(20, g.Score());
        }
    }
}

using System;
using Xunit;
using BowlingGame;

namespace BowlingGameTest
{
    public class BowlingGameTest
    {
        [Fact]
        public void testGutter()
        {
            var g = new Game();
            for(var i = 0; i <= 20; ++i) 
                g.roll(0);

            Assert.Equal(g.score(), 0);
        }
    }
}

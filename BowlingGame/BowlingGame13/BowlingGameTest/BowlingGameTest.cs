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
        public void TestGutterGame()
        {
            // act
            RollMany(20, 0);

            // assert
            Assert.Equal(0, _g.Score());
        }

        [Fact]
        public void TestAllOnes()
        {
            // act
            RollMany(20, 1);

            // assert
            Assert.Equal(20, _g.Score());
        }

        [Fact]
        public void TestOneSpare()
        {
            // act
            RollSpare();

            _g.Roll(3);

            RollMany(17, 0);

            // assert
            Assert.Equal(16, _g.Score());
        }

        [Fact]
        public void TestOneStrike()
        {
            // act
            RollStrike(); // 10 + 3 + 4 = 17

            _g.Roll(3); // 20
            _g.Roll(4); // 24

            RollMany(16, 0); // one fewer b/c of the strike

            // assert
            Assert.Equal(24, _g.Score());
        }

        [Fact]
        public void TestPerfectGame()
        {
            // act
            // 
            // a player who rolls a strike in the last frame is 
            // awarded two bonus rolls; ergo, twelve rolls total in a perfect game
            // 
            RollMany(12, 10); 

            // assert
            Assert.Equal(300, _g.Score());
        }

        private void RollStrike()
        {
            _g.Roll(10);
        }

        private void RollSpare()
        {
            _g.Roll(5);
            _g.Roll(5);
        }

        private void RollMany(int rolls, int pins)
        {
            for (var i = 0; i < rolls; ++i) {
                _g.Roll(pins);
            }
        }
    }
}

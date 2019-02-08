namespace BowlingGameTest
{
    using System;
    using BowlingGame;
    using Xunit;

    public class BowlingGameTest
    {
        private const int RollsPerGame = 20;

        private Game g;

        public BowlingGameTest()
        {
            this.g = new Game();
        }

        [Fact]
        public void TestGutterGame()
        {
            this.RollMany(RollsPerGame, 0);
            Assert.Equal(0, this.g.Score());
        }

        [Fact]
        public void TestAllOnes()
        {
            this.RollMany(RollsPerGame, 1);
            Assert.Equal(RollsPerGame, this.g.Score());
        }

        [Fact]
        public void TestOneSpare()
        {
            this.g.Roll(5);
            this.g.Roll(5);
            this.g.Roll(3);
            this.RollMany(17, 0);
            Assert.Equal(16, this.g.Score());
        }

        private void RollMany(int rolls, int pins)
        {
            for (var i = 0; i < rolls; i++)
            {
                this.g.Roll(pins);
            }
        }
    }
}

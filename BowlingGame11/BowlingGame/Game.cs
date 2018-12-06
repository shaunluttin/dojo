namespace BowlingGame
{
    using System;

    public class Game
    {
        private int[] rolls = new int[21]; // ugly magic number
        private int currentRoll;

        public void Roll(int pins)
        {
            this.rolls[this.currentRoll++] = pins;
        }

        public int Score()
        {
            var score = 0;
            for (var i = 0; i < this.rolls.Length; ++i)
            {
                score += this.rolls[i];
            }

            return score;
        }
    }
}

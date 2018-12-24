using System;

namespace BowlingGame
{
    public class Game
    {
        private int _roll = 0;

        private int[] _rolls = new int[20]; // magic number

        public void Roll(int pins)
        {
            this._rolls[this._roll++] = pins;
        }

        public int Score()
        {
            var score = 0;
            for (var i = 0; i < 20; i++) 
            {
                 score += this._rolls[i];
            }

            return score;
        }
    }
}

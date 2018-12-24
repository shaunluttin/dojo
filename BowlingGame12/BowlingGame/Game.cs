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
            const int frames = 10; // two rolls per frame
            for (int frame = 0, roll = 0; frame < frames; frame += 1, roll += 2) 
            {
                if (this._rolls[roll] + this._rolls[roll + 1] == 10)
                {
                    // spare
                    score += this._rolls[roll] + this._rolls[roll + 1];
                    score += this._rolls[roll + 2];
                }
                else 
                {
                    score += this._rolls[roll] + this._rolls[roll + 1];
                }
            }

            return score;
        }
    }
}

using System;

namespace BowlingGame
{
    public class Game
    {
        private int _score;

        public void Roll(int pins)
        {
            this._score += pins;
        }

        public int Score()
        {
            return this._score;
        }
    }
}

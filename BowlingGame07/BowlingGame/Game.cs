using System;

namespace BowlingGame
{
    public class Game
    {

        private int _score;

        public void roll(int pins)
        {
            _score += pins;
        }

        public int score()
        {
            return _score;
        }
    }
}

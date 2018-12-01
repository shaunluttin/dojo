using System;

namespace BowlingGame
{
    public class Game
    {
        private int _score;
        private int _currentRoll;
        private int[] _rolls = new int[21];

        public void roll(int pins)
        {
            _score += pins;

            _rolls[_currentRoll++] = pins;
        }

        public int score()
        {
            const int frames = 10;

            var score = 0;
            var roll = 0;
            for (var frame = 0; frame < frames; ++frame)
            {
                if(_rolls[roll] + _rolls[roll + 1] == 10)
                {
                    score += 10 + _rolls[roll + 2];
                }
                else 
                {
                    score += _rolls[roll] + _rolls[roll + 1];
                }


                roll += 2;
            }

            return score;
        }
    }
}

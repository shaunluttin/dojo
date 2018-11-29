using System;

namespace BowlingGame
{
    public class Game
    {
        private int[] _rolls = new int[21];

        private int _currentRoll;

        public void roll(int pins)
        {
           _rolls[_currentRoll++] = pins;
        }

        public int score()
        {
            var score = 0;
            var i = 0;
            for (var frame = 0; frame < 10; ++frame)
            {
                // isSpare
                if (_rolls[i] + _rolls[i+1] == 10) {
                    // sum the two rolls from this frame
                    score += _rolls[i] + _rolls[i + 1];
                    // add the first roll from the next fame
                    score += _rolls[i + 2];
                } 
                else {
                    // sum the two rolls from this frame
                    score += _rolls[i] + _rolls[i + 1];
                }

                // account for the two rolls from this frame
                i += 2;
            }

            return score;
        }
    }
}

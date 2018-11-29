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
            var frameIndex = 0;
            for (var frame = 0; frame < 10; ++frame)
            {
                // isSpare
                if (_rolls[frameIndex] + _rolls[frameIndex+1] == 10) {
                    // sum the two rolls from this frame
                    score += _rolls[frameIndex] + _rolls[frameIndex + 1];
                    // add the first roll from the next fame
                    score += _rolls[frameIndex + 2];
                } 
                else {
                    // sum the two rolls from this frame
                    score += _rolls[frameIndex] + _rolls[frameIndex + 1];
                }

                // account for the two rolls from this frame
                frameIndex += 2;
            }

            return score;
        }
    }
}

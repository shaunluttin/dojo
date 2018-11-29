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
                if (isSpare(frameIndex)) {
                    // take the score from this frame (which is 10)
                    // add the first roll from the next fame
                    score += 10 + _rolls[frameIndex + 2];
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

        private bool isSpare(int frameIndex)
        {
            return 
                _rolls[frameIndex] + 
                _rolls[frameIndex+1] == 10;
        }
    }
}

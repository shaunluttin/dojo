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
            var frameIndex = 0; // the first roll of the frame
            for (var frame = 0; frame < frames; ++frame)
            {
                if(isSpare(frameIndex))
                {
                    score += 10 + _rolls[frameIndex + 2];
                }
                else 
                {
                    score += _rolls[frameIndex] + _rolls[frameIndex + 1];
                }


                frameIndex += 2;
            }

            return score;
        }

        private bool isSpare(int frameIndex)
        {
            return _rolls[frameIndex] + _rolls[frameIndex + 1] == 10;
        }
    }
}

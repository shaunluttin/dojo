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
            const int frames = 10;

            var score = 0;
            var frameIndex = 0;
            for(var frame = 0; frame < frames; ++frame)
            {
                if(_rolls[frameIndex] == 10) 
                {
                    score += 10 + _rolls[frameIndex + 1] + _rolls[frameIndex + 2];
                    frameIndex += 1;
                }
                else if(isSpare(frameIndex))
                {
                    score += 10 + _rolls[frameIndex + 2];
                    frameIndex += 2;
                } 
                else
                {
                    score += _rolls[frameIndex] + _rolls[frameIndex + 1];
                    frameIndex += 2;
                }
            }

            return score;
        }

        private bool isSpare(int frameIndex)
        {
            return _rolls[frameIndex] + _rolls[frameIndex + 1] == 10;
        }
    }
}

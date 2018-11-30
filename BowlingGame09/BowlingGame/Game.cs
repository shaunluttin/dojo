using System;

namespace BowlingGame
{
    public class Game
    {
        private int[] _rolls = new int[21];
        private int _currentRoll;
        private const int _frames = 10;
        private const int _perfectScore = 10;

        public void roll(int pins) 
        {
            _rolls[_currentRoll++] = pins;
        }

        public int score() 
        {
            var score = 0;
            var frameIndex = 0;
            for(var frame = 0; frame < _frames; ++frame)
            {
                if(isStrike(frameIndex)) 
                {
                    score += _perfectScore + strikeBonus(frameIndex);
                    frameIndex += 1;
                }
                else if(isSpare(frameIndex))
                {
                    score += _perfectScore + spareBonus(frameIndex);
                    frameIndex += 2;
                } 
                else
                {
                    score += sumOfBallsInFrame(frameIndex);
                    frameIndex += 2;
                }
            }

            return score;
        }

        private int sumOfBallsInFrame(int frameIndex)
        {
            return _rolls[frameIndex] + _rolls[frameIndex + 1];
        }

        private int spareBonus(int frameIndex)
        {
            return _rolls[frameIndex + 2];
        }

        private int strikeBonus(int frameIndex)
        {
            return _rolls[frameIndex + 1] + _rolls[frameIndex + 2];
        }

        private bool isStrike(int frameIndex)
        {
            return _rolls[frameIndex] == _perfectScore;
        }

        private bool isSpare(int frameIndex)
        {
            return _rolls[frameIndex] + _rolls[frameIndex + 1] == _perfectScore;
        }
    }
}

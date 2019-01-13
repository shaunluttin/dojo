using System;

namespace BowlingGame
{
    public class Game
    {
        private const int RollsPerGame = 20;
        private const int FramesPerGame = 10;
        private const int MaxFrameScore = 10;

        private int[] _rolls = new int[RollsPerGame];

        private int _roll = 0;

        public void Roll(int pins) 
        { 
            _rolls[_roll++] = pins;
        }

        public int Score() 
        {
            // frameIndex is the first roll of each frame
            var frameIndex = 0;
            var score = 0;

            for(var frame = 0; frame < FramesPerGame; frame++)
            {
                // spare
                if (IsSpare(frameIndex)) 
                {
                    // the spare bonus is the value of 
                    // the first roll of the next frame
                    score += MaxFrameScore + _rolls[frameIndex + 2];

                    frameIndex += 2;
                    continue;
                }

                // strike
                if(IsStrike(frameIndex)) 
                {
                    // the strike bonus is the value of 
                    // the both rolls of the next frame
                    score += MaxFrameScore + 
                        _rolls[frameIndex + 1] + 
                        _rolls[frameIndex + 2];

                    frameIndex += 1;
                    continue;
                }

                // neither spare nor strike
                score += _rolls[frameIndex] + _rolls[frameIndex + 1];

                frameIndex += 2;
            }

            return score;
        }

        private bool IsStrike(int frameIndex) => 
            _rolls[frameIndex] == MaxFrameScore;

        private bool IsSpare(int frameIndex) => 
            _rolls[frameIndex] + _rolls[frameIndex + 1] == MaxFrameScore;
    }
}

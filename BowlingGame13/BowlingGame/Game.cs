using System;

namespace BowlingGame
{
    public class Game
    {
        private const int RollsPerGame = 20;

        private int[] _rolls = new int[RollsPerGame];

        private int _roll = 0;

        public void Roll(int pins) 
        { 
            _rolls[_roll++] = pins;
        }

        private int GetFrameScore(int frameIndex) 
        {
            return _rolls[frameIndex] + _rolls[frameIndex + 1];
        }

        public int Score() 
        {
            const int RollsPerFrame = 2;
            const int MaxFrameScore = 10;
            int score = 0;

            // The frameIndex represents the first roll of each frame
            for(var frameIndex = 0; 
                    frameIndex < _rolls.Length; 
                    frameIndex += RollsPerFrame)
            {
                var frameScore = GetFrameScore(frameIndex);

                if (frameScore == MaxFrameScore) // IsSpare
                {
                    // add the spare bonus, which is the value of 
                    // the first roll of the next frame
                    score += _rolls[frameIndex + 2];
                }

                score += frameScore;
            }

            return score;
        }
    }
}

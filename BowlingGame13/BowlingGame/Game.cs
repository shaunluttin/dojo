﻿using System;

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

        public int Score() 
        {
            const int MaxFrameScore = 10;

            // frameIndex is the first roll of each frame
            var frameIndex = 0;
            var score = 0;

            for(var frame = 0; frame < 10; frame++) // magic number
            {
                // spare
                if (_rolls[frameIndex] + _rolls[frameIndex + 1] == MaxFrameScore) 
                {
                    // add the spare bonus, which is the value of 
                    // the first roll of the next frame
                    score += MaxFrameScore + _rolls[frameIndex + 2];
                    frameIndex += 2;
                    continue;
                }

                // not spare
                score += _rolls[frameIndex] + _rolls[frameIndex + 1];
                frameIndex += 2;
            }

            return score;
        }
    }
}

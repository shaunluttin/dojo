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
            for(var i = 0; i < _rolls.Length; ++i)
                score += _rolls[i];

            return score;
        }
    }
}

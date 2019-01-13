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

        public int Score() 
        {
            int score = 0;

            for(var i = 0; i < _rolls.Length; i++) 
            {
                score += _rolls[i];    
            }

            return score;
        }
    }
}

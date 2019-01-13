using System;

namespace BowlingGame
{
    public class Game
    {
        private int[] _rolls = new int[20]; // ugly magic number

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

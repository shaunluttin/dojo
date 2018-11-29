using System;

namespace BowlingGame
{
    public class Game
    {
        private int _score;

        private int[] _rolls = new int[21];

        private int _currentRoll;

        public void roll(int pins)
        {
           _score += pins; 
           _rolls[_currentRoll++] = pins;
        }

        public int score()
        {
            return _score;
        }
    }
}

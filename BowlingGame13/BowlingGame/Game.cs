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

            for(var i = 0; i < _rolls.Length; i += 2) // ugly
            {
                var frameScore = _rolls[i] + _rolls[i + 1];

                if (frameScore == 10) // ugly
                {
                    // spare
                    // add the spare bonus, which is the value of 
                    // the first roll of the next frame
                    score += _rolls[i + 2];
                }

                score += frameScore;
            }

            return score;
        }
    }
}

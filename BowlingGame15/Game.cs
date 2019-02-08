namespace BowlingGame15
{
    public class Game 
    {
        const int RollsPerGame = 20;

        private int[] _rolls = new int[RollsPerGame];

        private int _currentRoll = 0;

        public void Roll(int pins) 
        {
            _rolls[_currentRoll++] = pins;
        }

        public int Score() 
        {
            var score = 0;
            foreach (var roll in _rolls) 
            {
                score += roll;
            }

            return score;
        }
    }
}

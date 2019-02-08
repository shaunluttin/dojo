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
            
            // the frameIndex is the first roll of the frame: 0,2,4,...,18
            for (var frameIndex = 0; frameIndex < 20; frameIndex += 2)
            {
                var frameScore = _rolls[frameIndex] + _rolls[frameIndex + 1];

                // spare
                if (frameScore == 10) 
                {
                    frameScore += _rolls[frameIndex + 2];
                }

                score += frameScore;
            }

            return score;
        }
    }
}

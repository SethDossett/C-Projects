namespace Math_Game.models
{
    internal class Game
    {
        public Game(int score, int numberOfQuestions, DateTime date, GameType gameType)
        {
            Score = score;
            NumberofQuestions = numberOfQuestions;
            Date = date;
            Type = gameType;
        }

        public int Score { get; set; }

        public int NumberofQuestions { get; set; }

        public DateTime Date { get; set; }

        public GameType Type { get; set; }

    }
    internal enum GameType
    {
        Addition, Subtraction, Multiplication, Division
    }
}

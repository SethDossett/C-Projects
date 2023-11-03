using Math_Game.models;
namespace Math_Game;

internal class GameEngine
{
    private int _correctAnswer;
    private int _numberOfQuestions = 5;
    private int _answersCorrect;
    private GameType _gameType;
    public GameEngine()
    {

    }

    public void StartGame(int gameChoice)
    {

        switch (gameChoice)
        {
            case 1:
                _gameType = GameType.Addition;
                break;
            case 2:
                _gameType = GameType.Subtraction;
                break;
            case 3:
                _gameType = GameType.Multiplication;
                break;
            case 4:
                _gameType = GameType.Division;
                break;
            default:
                _gameType = GameType.Addition;
                break;

        }

        Console.WriteLine(_gameType.ToString() + " Game Selected \n");
        _answersCorrect = 0;

        PlayGame(_gameType);

    }
    private void PlayGame(GameType gameType)
    {
        for (int i = 0; i < _numberOfQuestions; i++)
        {
            Console.WriteLine($"Question  ({i + 1}  of  {_numberOfQuestions})");
            GetProblem(gameType);
            Results(CheckAnswer(_correctAnswer));
        }
        EndGame();
    }
    private void EndGame()
    {
        Console.WriteLine("Game Over! You Got " + _answersCorrect + " of " + _numberOfQuestions + " right!");
        Helpers.Scores.Add(new models.Game(_answersCorrect, _numberOfQuestions, DateTime.Now, _gameType));

        //press any key to go back to Menu
        Console.WriteLine("Press any key to return to menu");
        Console.ReadKey(false);
        Console.Clear();
        Program.menu.OpenMenu();

    }
    private void GetProblem(GameType gameType)
    {
        string problem;

        _correctAnswer = GetAnswer(gameType, out problem);
        Console.WriteLine(problem);

    }
    private int GetAnswer(GameType gameType, out string problem)
    {
        var rand1 = new Random();
        var rand2 = new Random();
        int num1 = rand1.Next(1, 9);
        int num2 = rand2.Next(1, 9);

        int answer = 0;
        string op = "";


        switch (gameType)
        {
            case GameType.Addition:

                answer = num1 + num2;
                op = "+";
                break;

            case GameType.Subtraction:

                answer = num1 - num2;
                op = "-";
                break;

            case GameType.Multiplication:

                answer = num1 * num2;
                op = "*";
                break;

            case GameType.Division:

                do
                {
                    num1 = rand1.Next(101);
                    num2 = rand2.Next(101);

                } while (num1 % num2 != 0);

                answer = num1 / num2;

                op = "/";
                break;

            default:
                answer = num1 + num2;
                op = "+";
                break;

        }

        problem = ($"{num1} {op} {num2} =");

        return answer;
    }
    private bool CheckAnswer(int correctAnswer)
    {
        var theirAnswer = Console.ReadLine();

        theirAnswer = Helpers.ValidateResults(theirAnswer);

        if (int.Parse(theirAnswer) == correctAnswer) return true;

        else return false;
    }
    private void Results(bool correct)
    {
        if (correct)
        {
            Console.WriteLine("Correct!");
            _answersCorrect++;
        }
        else
        {
            Console.WriteLine("Incorrect! The answer was " + _correctAnswer);
        }
    }


}

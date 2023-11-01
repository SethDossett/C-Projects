namespace Math_Game
{
    public class Game
    {
        private int _correctAnswer;
        private int _numberOfQuestions = 10;
        private int _answersCorrect;
        public Game()
        {

        }

        public void StartGame(int gameChoice)
        {
            Console.WriteLine("You Chose " + gameChoice);
            Console.WriteLine("Game Playing");
            _answersCorrect = 0;

            PlayGame(gameChoice);

        }
        private void PlayGame(int gameChoice)
        {
            for (int i = 0; i < _numberOfQuestions; i++)
            {
                Console.WriteLine("Question " + (i + 1) + " of " + _numberOfQuestions);
                GetProblem(gameChoice);
                Results(CheckAnswer(_correctAnswer));
            }
            EndGame();
        }
        private void EndGame()
        {
            Console.WriteLine("Game Over! You Got " + _answersCorrect + " of " + _numberOfQuestions + " right!");
            Program.Scores.Add($"Game {Program.Scores.Count + 1} : {_answersCorrect} of {_numberOfQuestions}");

            //press any key to go back to Menu
            Console.WriteLine("Press any key to return to menu");
            Console.ReadKey(false);
            Console.Clear();
            Program.menu.OpenMenu();

        }
        private void GetProblem(int choice)
        {
            string problem;

            _correctAnswer = GetAnswer(choice, out problem);
            Console.WriteLine(problem);

        }
        private int GetAnswer(int operation, out string problem)
        {
            var rand1 = new Random();
            var rand2 = new Random();
            int num1 = rand1.Next(101);
            int num2 = rand2.Next(101);

            int answer = 0;
            string op = "";
            try
            {
                if (operation == 1)
                {
                    answer = num1 + num2;
                    op = "+";
                }
                else if (operation == 2)
                {
                    answer = num1 - num2;
                    op = "-";
                }
                else if (operation == 3)
                {
                    answer = num1 * num2;
                    op = "*";
                }
                else if (operation == 4)
                {
                    do
                    {
                        num1 = rand1.Next(101);
                        num2 = rand2.Next(101);

                    } while (num1 % num2 != 0);

                    answer = num1 / num2;

                    op = "/";
                }
            }
            catch
            {
                answer = num1 + num2;
                op = "+";
            }

            problem = (num1 + " " + op + " " + num2);

            return answer;
        }
        private bool CheckAnswer(int correctAnswer)
        {
            int theirAnswer = 0;
            while (true)
            {
                try
                {
                    theirAnswer = int.Parse(Program.GetInput());
                    break;
                }
                catch
                {
                    Console.WriteLine("Please select a valid Option");
                }
            }
            if (theirAnswer == correctAnswer) return true;
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
}

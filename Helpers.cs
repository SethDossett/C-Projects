using Math_Game.models;
namespace Math_Game;

internal class Helpers
{
    public static List<Game> Scores = new List<Game>
    {
        /*new Game (5, 5, DateTime.Now.AddDays(1), GameType.Addition),
        new Game (4,  5, DateTime.Now.AddDays(2), GameType.Multiplication),
        new Game (4,  5, DateTime.Now.AddDays(3), GameType.Division),
        new Game (3,  5, DateTime.Now.AddDays(4), GameType.Subtraction),
        new Game (1,  5, DateTime.Now.AddDays(5), GameType.Addition),
        new Game (2,  5, DateTime.Now.AddDays(6), GameType.Multiplication),
        new Game (3,  5, DateTime.Now.AddDays(7), GameType.Division),
        new Game (4,  5, DateTime.Now.AddDays(8), GameType.Subtraction),
        new Game (4,  5, DateTime.Now.AddDays(9), GameType.Addition),
        new Game (1,  5, DateTime.Now.AddDays(10), GameType.Multiplication),
        new Game (0,  5, DateTime.Now.AddDays(11), GameType.Subtraction),
        new Game (2,  5, DateTime.Now.AddDays(12), GameType.Division),
        new Game (5,  5, DateTime.Now.AddDays(13), GameType.Subtraction),*/
    };

    public static string GetInput()
    {
        string result = "";
        do
        {
            result = Console.ReadLine();
            if (string.IsNullOrEmpty(result))
                Console.WriteLine("Empty Input, Please try again");

        } while (string.IsNullOrEmpty(result));

        return result.Trim().ToLower();
    }
    public static string? ValidateResults(string result)
    {
        while (string.IsNullOrEmpty(result) || !Int32.TryParse(result, out _))
        {
            Console.WriteLine("your answer needs to be an integer. Try Again");
            result = Console.ReadLine();
        }

        return result.Trim().ToLower();
    }
    public static void QuitApp()
    {
        Console.Clear();
        Console.WriteLine("Quit Application");
        Environment.Exit(1);
    }
    public static void ShowPreviousGames()
    {
        //implement a search filter option for players to see results based on what they would like it to be ordered by.

        //IEnumerable<Game> gamesToPrint = Scores.Where(x => x.Date > new DateTime(2022, 08, 09)).OrderByDescending(x => x.Score);

        Console.Clear();
        Console.WriteLine("Games History:");
        Console.WriteLine("------------------------------------");

        if (Scores.Count == 0) Console.WriteLine("No Previous Games");

        foreach (Game game in Scores)
        {
            Console.WriteLine($"{game.Date} : {game.Score} out of {game.NumberofQuestions} correct.");
        }

        //press any key to go back to Menu
        Console.WriteLine("------------------------------------ \n");
        Console.WriteLine("Press any key to return to menu");
        Console.ReadKey(false);
        Console.Clear();
        Program.menu.OpenMenu();
    }
}

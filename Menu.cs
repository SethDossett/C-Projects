namespace Math_Game;

internal class Menu
{
    public Menu()
    {

    }
    public void OpenMenu()
    {
        Console.Clear();
        Console.WriteLine("Press 1 to Play Game.");
        Console.WriteLine("Press 2 to See Previous Games.");
        Console.WriteLine("Press 3 to Quit.");
        int choice = 0;
        while (true)
        {
            try
            {
                choice = int.Parse(Helpers.GetInput());
                if (choice == 1)
                {
                    GiveChoices();
                    break;
                }
                else if (choice == 2)
                {
                    Helpers.ShowPreviousGames();
                    break;
                }
                else if (choice == 3)
                {
                    Helpers.QuitApp();
                    break;
                }
                else
                {
                    choice = 0;
                    Console.WriteLine("Invalid input");
                }
            }
            catch
            {
                choice = 0;
                Console.WriteLine("Invalid input");
            }

        }
    }
    private void PrintMenuOptions()
    {
        Console.WriteLine("Press 1 for Addition.");
        Console.WriteLine("Press 2 for Subtraction.");
        Console.WriteLine("Press 3 for Multiplication.");
        Console.WriteLine("Press 4 for Division.");
        Console.WriteLine("Press 5 to return to menu.");
    }

    private void ValidChoice(int choice)
    {
        if (choice == 5)
        {
            OpenMenu();
            return;
        }
        GameEngine game = new GameEngine();
        Console.Clear();
        game.StartGame(choice);
    }
    private void GiveChoices()
    {
        Console.Clear();
        Console.WriteLine("Welcome, Please choose an operation \n");
        int choice = 0;
        PrintMenuOptions();
        while (true)
        {
            try
            {
                choice = int.Parse(Helpers.GetInput());
                if (choice > 0 && choice <= 5) break;
                else
                {
                    choice = 0;
                    Console.WriteLine("Invalid input");
                }
            }
            catch
            {
                choice = 0;
                Console.WriteLine("Invalid input");
            }
        }
        ValidChoice(choice);
    }
}

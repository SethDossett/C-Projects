namespace Math_Game
{
    public class Menu
    {
        public Menu()
        {

        }
        public void OpenMenu()
        {
            Console.WriteLine("Press 1 to Play Game.");
            Console.WriteLine("Press 2 to See Previous Games.");
            Console.WriteLine("Press 3 to Quit.");
            int choice = 0;
            while (true)
            {
                try
                {
                    choice = int.Parse(Program.GetInput());
                    if (choice == 1)
                    {
                        GiveChoices();
                        break;
                    }
                    else if (choice == 2)
                    {
                        ShowPreviousGames();
                        break;
                    }
                    else if (choice == 3)
                    {
                        Program.QuitApp();
                        break;
                    }
                    else
                    {
                        choice = 0;
                        Console.WriteLine("Please select a valid Option");
                    }
                }
                catch
                {
                    choice = 0;
                    Console.WriteLine("Please select a valid Option");
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
        private void ShowPreviousGames()
        {
            Console.WriteLine("Previous games:");
            if (Program.Scores.Count == 0) Console.WriteLine("No Previous Games");

            for (int i = 0; i < Program.Scores.Count; i++)
            {
                Console.WriteLine(Program.Scores[i]);
            }

            //press any key to go back to Menu
            Console.WriteLine("Press any key to return to menu");
            Console.ReadKey(false);
            Console.Clear();
            Program.menu.OpenMenu();
        }
        private void ValidChoice(int choice)
        {
            if (choice == 5)
            {
                OpenMenu();
                return;
            }
            Game game = new Game();
            Console.Clear();
            game.StartGame(choice);
        }
        private void GiveChoices()
        {
            Console.Clear();
            Console.WriteLine("Welcome, Please choose an operation");
            int choice = 0;
            while (true)
            {
                PrintMenuOptions();
                try
                {
                    choice = int.Parse(Program.GetInput());
                    if (choice > 0 && choice <= 5) break;
                    else
                    {
                        choice = 0;
                        Console.Clear();
                        Console.WriteLine("Please select a valid Option");
                    }
                }
                catch
                {
                    choice = 0;
                    Console.Clear();
                    Console.WriteLine("Please select a valid Option");
                }
            }
            ValidChoice(choice);
        }
    }
}

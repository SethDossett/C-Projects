namespace Math_Game
{
    internal class Program
    {
        public static Menu menu = new Menu();

        public static void Main(string[] args)
        {
            menu.OpenMenu();
        }
        public static void QuitApp()
        {
            Console.Clear();
            Console.WriteLine("Quit Application");
        }
        public static string GetInput()
        {
            string result = "";
            do
            {
                result = Console.ReadLine();
                if (string.IsNullOrEmpty(result))
                    Console.WriteLine("Empty Input, Please try again");

            } while (string.IsNullOrEmpty(result));

            return result;
        }

    }
}
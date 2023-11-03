namespace Math_Game;

internal class Program
{
    public static Menu menu = new Menu();


    public static void Main(string[] args)
    {
        Console.WriteLine($"Welcome, it's {DateTime.UtcNow.DayOfWeek} \n");
        Console.WriteLine("Press any key to begin.");
        Console.ReadKey(false);
        menu.OpenMenu();
    }

}

using System;

public class Program
{
    public static void Main(string[] args)
    {
        void Menu()
        {
            Console.WriteLine("Welcome, Please choose an operation");
            int choice = 0;
            while (true)
            {
                try
                {
                    choice = int.Parse(Console.ReadLine());
                    if (choice == 1) Console.WriteLine("Hey");
                    else { 
                    
                        Console.WriteLine("Try Again");
                    }
                }
                catch
                {
                    
                }
                break;
            }
        }

        Menu();
    }
}



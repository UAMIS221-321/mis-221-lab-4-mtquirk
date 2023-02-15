//Main
Console.WriteLine("Enter 1 to display full triangle, Enter 2 to display partial triangle, Enter 3 to exit");
string input = Console.ReadLine();
if (input == "1")
{
    GetFull();
}
else if (input == "2")
{
    GetPartial();
}
else if (input == "3")
{
    Exit();
}
else
{
    ReturnToMenu();
}

//Methods
static void Main()
{
    Console.WriteLine("Enter 1 to display full triangle, Enter 2 to display partial triangle, Enter 3 to exit");
    string input = Console.ReadLine();
    if (input == "1")
    {
        GetFull();
    }
    else if (input == "2")
    {
        GetPartial();
    }
    else if (input == "3")
    {
        Exit();
    }
    else
    {
        ReturnToMenu();
    }
}

static void GetFull()
{
    Random rnd = new Random();
    int number = rnd.Next(3, 9);
    for(int i = 1; i<=number; i++)
    {
        for(int j = 1; j<=i; j++)
        {
            Console.Write("");
        }
        for(int k = 1; k<= i; k++)
        {
            Console.Write("o ");
        }
        Console.WriteLine("");
    }
}

static void GetPartial()
{
    Random rnd = new Random();
    int number = rnd.Next(3, 9);
    for(int i = 1; i<=number; i++)
    {
        for(int j = 1; j<=i; j++)
        {
            Console.Write("");
        }
        for(int k = 1; k<= i; k++)
        {
            Random rando = new Random();
            int value = rando.Next(2);
            if (value == 0)
            {
                Console.Write("o ");
            }
            else if (value == 1)
            {
                Console.Write("  ");
            }
        }
        Console.WriteLine("");
    }
}

static void Exit()
{
    Console.WriteLine("You chose to exit. Thank you for using my code! Goodbye.");
}

static void ReturnToMenu()
{
    Console.WriteLine("Error. Not a valid option. Returning to menu.");
    Main();
}






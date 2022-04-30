using ConsoleApplications.StdRedirections;

while (true)
{
    ShowMenu();
    int input;
    while (int.TryParse(Console.ReadLine(), out input) == false)
    {
        Console.WriteLine("Enter correct input!");
        ShowMenu();
    }

    if (input == 0) return;
    else if (input == 1) RedirectStdHandle.main();
    else continue;
}

void ShowMenu()
{
    Console.WriteLine("0. Exit");
    Console.WriteLine("1. Redirect standart in/out/error handles");
    Console.Write("Choose action: ");
}
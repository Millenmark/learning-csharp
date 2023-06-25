for (int x = 1; x <= 100; x++)
{
    if (x % 5 == 0 && x % 3 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($"{x}: Electric and Fire");
    }
    else if (x % 5 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"{x}: Electric");
    }
    else if (x % 3 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"{x}: Fire");
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine($"{x}: Normal");
    }
}

Console.ReadKey(true);

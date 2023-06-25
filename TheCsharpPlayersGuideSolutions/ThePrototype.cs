int user1;

do
{
    Console.Write("User 1, enter a number between 0 and 100: ");
    user1 = Convert.ToInt32(Console.ReadLine());
}
while (user1 < 0 || user1 > 100);

Console.Clear();


while (true)
{
    Console.Write("User 2, guess the number: ");
    int user2 = Convert.ToInt32(Console.ReadLine());

    if (user2 > user1) Console.WriteLine($"{user2} is too high. \n");
    else if (user2 < user1) Console.WriteLine($"{user2} is too low \n");
    else break;
}

Console.WriteLine("You guessed the number!");


Console.ReadKey(true);

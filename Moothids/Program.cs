
// Intro to make Dan feel giddy
Console.WriteLine("Hello, Dan!");
Console.WriteLine("Welcome to MOO-thids!");
Console.WriteLine("Within the Bowels of this project already exists an Array of Cow Names");
Console.WriteLine("If you can guess one, I'll give you a cookie.... like, ok well it's still a 'fake' cookie.... but not one that will track you forever or anything..... PROMISE!");
Console.WriteLine("Also, to save time for me and you..... they are all lowercase lol, and one is definately beef");
Console.WriteLine("Good Luck!");

// Prompt the Dan
Console.WriteLine("Okay, Let's give it a shot. What name do you think is in the list?");
Console.WriteLine();
string? guess = Console.ReadLine();
Console.WriteLine();

// Required array
string[] listofnames = ["beef", "burger", "yourmom", "miltank", "angus", "dan"];

// Required loop
foreach (string name in listofnames)
{
    // Required Conditional & use of Required Method
    if (nameFound(guess, name))
    {
        Console.WriteLine("Have a Cookie!");
    }
    else
    {
        Console.WriteLine("No Match");
    }
}

Console.WriteLine("We both know with some refactors and a bit of grit this could be sooooo MOO-ch better, also it has fatal flaws in terms of user input controll, but I'm on a time crunch baby!");

// Required Method
bool nameFound(string guess, string name)
{
    return guess.Equals(name);
}

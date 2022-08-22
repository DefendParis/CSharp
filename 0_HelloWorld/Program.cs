//Change appearance of Console
Console.Title = "Matrix";
Console.ForegroundColor = ConsoleColor.DarkGreen;

void text(string text, int time = 35)
{
    foreach (char c in text)
    {
        Console.Write(c);
        Thread.Sleep(time);
    }
}

//Presentation

text("Hello Chosen One");


text("\nDo you wanna go on an adventure? \n");

string answer = Console.ReadLine();

if (answer == "no")
{
    text("Okay then");
    Thread.Sleep(500);
}

else if (answer == "yes")
{
    text("\nLet's go deeper then");
}
else
{
    text("okay");
}

text("\So you want to know about the things keeping an eye on you?");
Console.ReadLine();
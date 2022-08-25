//Change appearance of Console
Console.Title = "Matrix";
Console.ForegroundColor = ConsoleColor.DarkGreen;

void text(string text, int time = 20)
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

text("\nSo you want to know about the things keeping an eye on you?\n");

string answer1 = Console.ReadLine();

if (answer1 == "no")
    {
        text("Well good luck then...\n");
        Thread.Sleep(500);
    }

else if (answer1 == "yes")
    {
        text("\nWell let's go into The Matrix");
        Console.Clear();
    }
    
text("Hello again.\n");
Console.ReadLine();

string[] places = {"Google", "Meta", "Twitter"};

for (int i = 0; i < places.Length; i++)
{
    int rank = i + 1;
    Console.WriteLine(rank + ". "+ places[i] );
}

string[] yourplaces = new string[3];

Console.WriteLine("Type the worst tech companies that spies on you");

for (int i = 0; i < yourplaces.length; i++)
{
    yourplaces[i] = Console.ReadLine();
}

Console.WriteLine("\nJust for fun, here they are alphabetically: ");

Array.Sort(yourplaces);

for (int i = 0; i < yourplaces.length; i++)
{
    Console.WriteLine(yourplaces[i]);    
}







//Change appearance of Console
Console.Title = "Matrix";
Console.ForegroundColor = ConsoleColor.DarkGreen;

#region first clear
void text(string text, int time = 20)
{
    foreach (char c in text)
    {
        Console.Write(c);
        Thread.Sleep(time);
    }
}

void text1(string text, int time = 1)
{
    foreach (char c in text)
    {
        Console.Write(c);
        Thread.Sleep(time);
    }
}

//These voids is for writing one character at a time at differnt speeds

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
#endregion first clear

#region second clear
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

for (int i = 0; i < yourplaces.Length; i++)
{
    yourplaces[i] = Console.ReadLine();
}

Console.WriteLine("\nJust for fun, here they are alphabetically: ");

Array.Sort(yourplaces);

for (int i = 0; i < yourplaces.Length; i++)
{
    Console.WriteLine(yourplaces[i]);    
}
Console.ReadLine();

int count = 0;
bool loop = true;
while(loop) {
    if(count == 250) {
        loop = false;
    }
    else {
        count++;
        Thread.Sleep(10);
        Random numbers = new Random();
        Console.WriteLine(numbers.Next());
    }
}
        Console.WriteLine("aaaah");
        Console.Clear();

#endregion second clear 

#region third clear

text("So the Matrix have found us, now you will have to roll a dice\n");
Thread.Sleep(200);
text("\nIf you roll a six, i can get you safely away. Any other number i can't guarantee your safety\n");
Thread.Sleep(200);
text("\nSo lets see if the program wants you dead or alive\n");
Thread.Sleep(500);
Console.Clear();

Random rd= new Random();

int rand_rum = rd.Next(1,7);

        Console.WriteLine("-----------------");
        Console.WriteLine("|               |");
        Console.WriteLine("|               |");
        Console.WriteLine("|               |");
        Console.WriteLine("-----------------");
    Console.SetCursorPosition(8, 2);

    Console.WriteLine(rand_rum);
    Console.SetCursorPosition(0, 6);
    
if (rand_rum == 6)
    {
        text("\nWell the computer really likes you huh\n");
        Thread.Sleep(400);
    }
else 
    {
        text("Well i wish you good luck on your journey");
        count = 0;
        loop = true;
            while(loop) {
            if(count == 250) {
        loop = false;
            }
        else {
        count++;
            text1("\nGood Luck");
    }
}
    }
#endregion
#region 
//The "#region" can be used to 'collapse' areas of code so you can focus on the key areas
//Comments can be done in a couple different ways, after // and multiline between /* comment */
/*
multi
line
comment
*/

//All of these functionalities is for the programmers, the compiler deletes them when creating the executable (.exe)
//Programmers can use them to document their code and help future programmers understand their thinking.
#endregion

#region Assignment; Write your own story
/* Todays assignment
*   Run this program
*   Read and understand this programs source code
*   Write a short story using the Console for input and output
*   Try to make use of as many of the below techniques as possible
*/

//Console.WriteLine("...");
//Console.ReadLine();
//int.Parse("123");
//if, elseif, else

//bool ExampleBool = true;
//int ExampleInt = 123;
//float ExampleFloat = 123.21f;
//string ExampleString = "Example 123";
#endregion

#region Variables
Console.WriteLine("Hello little one");
Console.WriteLine("What is your name?");

//<Type> <Name> = <Value> ;
string myString = "This is how to define a string variable!";

//Reading a string from the console
myString = Console.ReadLine();

//Writing it back to the console
Console.WriteLine("Oi Bas Ned" + myString + ", Vil du se min hemmeligheder");
#endregion

#region Data types
Console.WriteLine("Do you want to learn about the simplest data types?");
/*
* The four main basic types we we will work with in the beginning are:
* bool, Int, Float and String   
* bool or boolean, can only be 'true' or 'false'
* Int, or integer, is a whole number; 1, 2, 3
* Float is a decimal number; 3.14 or 7.777
* Strings is just text found between quotationmarks "This is a string, easy right?"
*/

    Console.WriteLine("...");
    Console.ReadLine();

Console.WriteLine("...The end...");
Console.ReadLine();

#endregion


/* Teachers corner

* Operators; +, -, /, *, %, ++, --, *=, +=, -=

* Casting
int.Parse()
Convert.ToInt32()
(int)
*/
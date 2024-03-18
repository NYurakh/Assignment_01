// See https://aka.ms/new-console-template for more information
Console.WriteLine("What is your name?");
string userName = Console.ReadLine() ?? "Anonymous";
Console.WriteLine("Hello, " + userName);

Console.WriteLine("How old are you?");
int age = int.Parse(Console.ReadLine());

if (age < 18)
{
Console.WriteLine("You are too young to use this program");
} else {
    Console.WriteLine("Welcome!");
}



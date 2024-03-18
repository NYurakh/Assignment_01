// See https://aka.ms/new-console-template for more information
Console.WriteLine("What is your name?");
string userName = Console.ReadLine() ?? "Anonymous";
Console.WriteLine("Hello, " + userName);

Console.WriteLine("How old are you?");
int age = int.Parse(Console.ReadLine());
Console.WriteLine("Your age is: " + age);
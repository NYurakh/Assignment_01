// See https://aka.ms/new-console-template for more information
Console.WriteLine("What is your name?");
string userName = Console.ReadLine() ?? "Anonymous";
Console.WriteLine("Hello, " + userName);
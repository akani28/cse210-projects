using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Prep1 World!");

        Console.Write("What is your first name? ");
        String firstName = Console.ReadLine();
        firstName = firstName.ToUpper().Substring(0 ,1) + firstName.Substring(1);
        Console.Write("What is your last name? ");
        String lastName = Console.ReadLine();
        lastName = lastName.ToUpper().Substring(0,1)+lastName.Substring(1);
        Console.WriteLine("");
        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}.");
    }
}
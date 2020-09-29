using System;

class SelectionStatement
{
    public void LearnIfElse()
    {
        Console.Write("Enter your age: ");
        string ageString = Console.ReadLine();
        byte age = byte.Parse(ageString);

        if (age > 60)
        {
            Console.WriteLine("You're eligible for pension.");
        }
        else if(age > 50)
        {
            Console.WriteLine("You're about to be eligible for pension.");
        }
        else
        {
            Console.WriteLine("You're not eligible for pension.");
        }
    }

    public void LearnSwitchCases()
    {
        Console.Write("Enter your hobby: ");
        string hobby = Console.ReadLine();

        switch(hobby)
        {
            case "books":
            Console.WriteLine("You're a nerd");
            break;

            case "swimming":
            Console.WriteLine("You must be fit");
            break;

        }

    }
}
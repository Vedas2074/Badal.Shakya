using System;
using AccessModifierAndMethods;

// namespace CSharpBasics
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.WriteLine("Hello World!");
//             Console.Write("Enter your name: ");
//             string name = Console.ReadLine();
//             Console.WriteLine("Hi, "+ name);
//         }
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         SelectionStatement selectionStatement = new SelectionStatement();
//         selectionStatement.LearnSwitchCases();

//     }
// }

class Program
{
    static void Main123()
    {
        IterationStatement iterationStatement = new IterationStatement();
        iterationStatement.LearnForLoops();

        AccessModifier accessModifier = new AccessModifier();
        accessModifier.DoSomething();

        Person person = new Person();
        person.Name = "Badal";
        person.Age = 121;

        var x = person.Age;
    }
}

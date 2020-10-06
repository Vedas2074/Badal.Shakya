// using System;
// using AccessModifierAndMethods;

// // namespace CSharpBasics
// // {
// //     class Program
// //     {
// //         static void Main(string[] args)
// //         {
// //             Console.WriteLine("Hello World!");
// //             Console.Write("Enter your name: ");
// //             string name = Console.ReadLine();
// //             Console.WriteLine("Hi, "+ name);
// //         }
// //     }
// // }

// // class Program
// // {
// //     static void Main()
// //     {
// //         SelectionStatement selectionStatement = new SelectionStatement();
// //         selectionStatement.LearnSwitchCases();

// //     }
// // }

// class Program
// {
//     static void Main123()
//     {
//         IterationStatement iterationStatement = new IterationStatement();
//         iterationStatement.LearnForLoops();

//         AccessModifier accessModifier = new AccessModifier();
//         accessModifier.DoSomething();

//         Person person = new Person();
//         person.Name = "Badal";
//         person.Age = 121;

//         var x = person.Age;
//     }
// }

using System;
using LearningClasses;

class Program
{
    static void Main1234()
    {
        var person1 = new Person("Badal", "Lalitpur");
        var person2 = new Person("Ramesh", "Ktm", 23);
        var person3 = new Person("Ram", "Bhaktapur", 45);

        var person4 = new Person();
        var x = Person.ScientificName;

        var y = Math.Sqrt(343);

        var s = Calculator.Sum(23, 34);
        var s1 = Calculator.Sum<int>(23, 34);
        var s2 = Calculator.Sum<decimal>(23123.12m, 34345132.1m);
    }
}

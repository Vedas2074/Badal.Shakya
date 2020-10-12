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
    static void Main()
    {
        // var person1 = new Person("Badal", "Lalitpur");
        // var person2 = new Person("Ramesh", "Ktm", 23);
        // var person3 = new Person("Ram", "Bhaktapur", 45);

        // var person4 = new Person();
        // var x = Person.ScientificName;

        // var y = Math.Sqrt(343);

        // var s = Calculator.Sum(23, 34);
        // var s1 = Calculator.Sum<int>(23, 34);
        // var s2 = Calculator.Sum<decimal>(23123.12m, 34345132.1m);

        // Rectangle rectangle = new Rectangle();
        // rectangle.Length = 23.6;
        // rectangle.Breadth = 6.32;

        //Inheritance example       
        // Rectangle r = new Rectangle()
        // {
        //     //Object Initializer
        //     Length = 23.6,
        //     Breadth = 6.32
        // };
        
        // var area = rectangle.GetArea();
        // var perimeter = rectangle.GetPerimeter();

        //using constructor
        Shape r1 = new Rectangle(23.6, 6.32);
        Rectangle r2 = new Rectangle(278.6, 61.32);
        r1.PrintDetails();
        r2.PrintDetails();

        // var r1Area = r1.GetArea();

        //Assignable to Grand-Parent class
        Shape s4 = new Square(45.3);
        s4.PrintDetails();

        // Square sq = new Square(34.5);
        // var sqPerimeter = sq.GetPerimeter();

        Shape c = new Circle(23.5);
        // var cArea = c.GetArea();
        c.PrintDetails();
    }
}

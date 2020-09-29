using System;
using System.Linq;

namespace AccessModifierAndMethods
{
    class Methods
    {
        void PrintInfo()
        {
            Console.WriteLine("Printing Something");
            Multiply(23.5f, 2332.45f);
            Multiply(23.5f, 2332.45f, 453.65f);

            Sum(123, 423, 3452);

            Greet("Badal", "Mr.");
            Greet("Shanta");

            byte[] numbers = { 2, 4, 5, 8, 123, 58, 23 };
            // (byte, byte) result = FindMinMax(numbers);
            (byte Min, byte Max) result = FindMinMax(numbers);

            //Named Argument
            PrintCustomerDetails(age: 23, name: "Badal", isMale: true, address: "Lalitpur");
        }

        void PrintSomething(string message)
        {
            Console.WriteLine("message");
        }

        float Multiply(float firstNum, float secondNum)
        {
            float product = firstNum * secondNum;
            return product;
        }
        float Multiply(float firstNum, float secondNum, float thirdNum)
        {
            float product = firstNum * secondNum * thirdNum;
            return product;
        }

        double Sum(params double[] numbers)
        {
            double sum = 0;
            foreach (double num in numbers)
            {
                sum = sum + num;
            }
            return sum;
        }

        //Optional arguments
        string Greet(string name, string prefix = "Miss")
        {
            // string fullName = prefix + "," + name;
            string fullName = $"{prefix}, {name}";//string interpolation
            return fullName;
        }

        //Returning multiple values : using tuples
        (byte, byte) FindMinMax(byte[] numbers)
        {
            byte max = numbers.Max();
            byte min = numbers.Min();

            return (min, max);
        }

        void PrintCustomerDetails(string name, string address, byte age, bool isMale)
        {
            Console.WriteLine($"{name}[{age}], {address}");
        }

        float Subtract(float firstNum, float secondNum)
        {
            return firstNum - secondNum;
        }

        //Expression bodied member
        float Subtract1(float firstNum, float secondNum) => firstNum - secondNum;
    }
}
using System;
using System.Linq;
using System.Collections.Generic;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            // LINQ - Language Integrated Query
            int[] numbers = { 23, 45, 67, 12, 34, 45, 78, 90, 11, 14, 16, 27};

            //Find all the elements from numbers which are less than 75 and greater than 20
            
            //Using method syntax - lambda expression
            var result1 = numbers.Select(x => x < 75 && x > 20);

            //Query syntax - query expression
            var result2 = from x in numbers
                          where x < 75 && x > 20
                          select x;

            string[] names = { "Bishnu", "Bipin", "Rojeena", "Sanjana", "Anjana", "Anisha", "Badal"};

            // Find names that starts with letter 'B' and having length less than 6
            var result3 = from name in names
                          where name.StartsWith("B") && name.Length < 6
                          select name;
            
            //Projections
            var result4 = from num in numbers
                          select num * num;

            //Ordering (In Ascending)
            var result5 = from num in numbers
                          orderby num
                          select num;

            //Partitioning
            var result6 = numbers.Take(5);
            var result7 = numbers.Skip(5).Take(5);

            //Quantifiers
            var isEvenThere = numbers.Any(num => num % 2 == 0); //check if there is any even number in the array
            var areAllEvens = numbers.All(num => num % 2 == 0); //check if all the numbers in the array are even
            var is26There = numbers.Contains(26); //check if the array contains 26

            var result8 = Enumerable.Range(1,1000);
            // var result9 = Enumerable.Repeat("Hello World", 10);

            List<Person> people = new List<Person>
            {
                new Person() {Id = 1, FirstName = "Badal", LastName = "Shakya", Address = "Lalitpur", Age = 21},
                new Person() {Id = 2, FirstName = "Ram", LastName = "Khatri", Address = "Ktm", Age = 25},
                new Person() {Id = 3, FirstName = "Shyam", LastName = "Shrestha", Address = "Bhaktapur", Age = 16},
                new Person() {Id = 4, FirstName = "Bishnu", LastName = "Rawal", Address = "Ktm", Age = 41},
                new Person() {Id = 5, FirstName = "Hari", LastName = "Joshi", Address = "Lalitpur", Age = 46},
                
            };

            //Find all people who live in Kathmandu
            var result10 = from person in people
                           where person.Address == "Ktm"
                           select person;

            //Find all people who are minors who live in Bhaktapur
            var result11 = from person in people
                           where person.Age < 18 && person.Address == "Bhaktapur"
                           select person; 

        }
    }
}

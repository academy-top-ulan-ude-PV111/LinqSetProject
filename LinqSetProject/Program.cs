namespace LinqSetProject
{
    class Person
    {
        public string? Name { get; set; }
        public int Age { set; get; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>
            {
                new Person{ Name = "Bob", Age = 24 },
                new Person{ Name = "Tommy", Age = 33 },
                new Person{ Name = "Sam", Age = 17 },
                new Person{ Name = "Mike", Age = 42 },
                new Person{ Name = "Susan", Age = 25 },
                new Person{ Name = "Tim", Age = 24 },
                new Person{ Name = "Phill", Age = 17 },
                new Person{ Name = "Anna", Age = 25 },
            };

            List<Person> personsA = new List<Person>
            {
                persons[0],
                persons[1],
                persons[2],
                persons[3],
                persons[4],
            };
            foreach (var p in personsA)
                Console.WriteLine($"{p.Name} {p.Age}");
            Console.WriteLine(new String('-', 10));

            List<Person> personsB = new List<Person>
            {
                persons[5],
                persons[1],
                persons[6],
                persons[3],
                persons[7],
            };

            foreach (var p in personsB)
                Console.WriteLine($"{p.Name} {p.Age}");
            Console.WriteLine(new String('-', 10));

            Console.WriteLine("A Except B");
            var personAExcept = personsA.Except(personsB);
            foreach (var p in personAExcept)
                Console.WriteLine($"{p.Name} {p.Age}");
            Console.WriteLine(new String('-', 10));

            Console.WriteLine("A Intersect B");
            var personAIntersect = personsA.Intersect(personsB);
            foreach (var p in personAIntersect)
                Console.WriteLine($"{p.Name} {p.Age}");
            Console.WriteLine(new String('-', 10));

            Console.WriteLine("A Union B");
            var personAUnion = personsA.Union(personsB);
            foreach (var p in personAUnion)
                Console.WriteLine($"{p.Name} {p.Age}");
            Console.WriteLine(new String('-', 10));

            Console.WriteLine("A Concat B");
            var personAConcat = personsA.Concat(personsB);
            foreach (var p in personAConcat)
                Console.WriteLine($"{p.Name} {p.Age}");
            Console.WriteLine(new String('-', 10));

            Console.WriteLine("A Distinct B");
            var personDistinct = personAConcat.Distinct();
            foreach (var p in personDistinct)
                Console.WriteLine($"{p.Name} {p.Age}");
            Console.WriteLine(new String('-', 10));

            Console.WriteLine("A Except Simmetric B");
            var personExcept = personsA.Union(personsB)
                                       .Except(personsA.Intersect(personsB));

            foreach (var p in personExcept)
                Console.WriteLine($"{p.Name} {p.Age}");
            Console.WriteLine(new String('-', 10));
        }
    }
}
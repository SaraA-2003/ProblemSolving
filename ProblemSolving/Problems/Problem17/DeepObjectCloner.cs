using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;


//this version satisfy the reference loop and lists and nested objects 


//namespace ProblemSolving.Problems.Problem17
//{
//    internal class DeepObjectCloner
//    {
//        public static void Run()
//        {
//            Person a = new Person { Name = "Ahmad" };
//            Person b = new Person { Name = "Sara" };
//            Person c = new Person { Name = "Sama" };

          
//            a.Friends.Add(b);
//            a.Friends.Add(c);

//            b.Friends.Add(a); // reference loop
//            b.Friends.Add(c);

//            c.Friends.Add(a); // reference loop

//            Person clone = DeepClone(a);

//            clone.Name = "Jana";
//            clone.Friends[0].Name = "Malak";
//            clone.Friends[0].Friends[1].Name = "Eliaa";

        
//            Console.WriteLine("Original name: " + a.Name);
//            Console.WriteLine("Original friend 1: " + a.Friends[0].Name);
//            Console.WriteLine("Original friend 2: " + a.Friends[1].Name);

//            Console.WriteLine("\n\nAfter clone\n");

//            Console.WriteLine("Clone name: " + clone.Name);
//            Console.WriteLine("Clone friend 1: " + clone.Friends[0].Name); 
//            Console.WriteLine("Clone friend 2: " + clone.Friends[1].Name);

            



//        }


//        class Person
//            {
//                public string Name { get; set; }
//                public List<Person> Friends { get; set; } = new List<Person>();

//        }




//        static T DeepClone<T>(T original)
//        {
//            var options = new JsonSerializerOptions
//            {
//                ReferenceHandler = ReferenceHandler.Preserve,
//                WriteIndented = true
//            };

//            string json = JsonSerializer.Serialize(original, options);
//            return JsonSerializer.Deserialize<T>(json, options);
//        }

//    }
//}


// simpler version


namespace ProblemSolving.Problems.Problem17
{
    internal class DeepObjectCloner
    {
        public class Person
        {
            public string Name;
            public Person Friend;

            public Person DeepClone()
            {
                Person clone = new Person();
                clone.Name = this.Name;

                if (this.Friend != null)
                {
                    clone.Friend = new Person();
                    clone.Friend.Name = this.Friend.Name;
                }

                return clone;
            }
        }

        public static void Run()
        {
            Person original = new Person();
            original.Name = "Ahmad";
            original.Friend = new Person();
            original.Friend.Name = "Sara";

            Person clone = original.DeepClone();

            // Print before change
            Console.WriteLine("Before change:");
            Console.WriteLine($"Original.Name: {original.Name}");
            Console.WriteLine($"Original.Friend.Name: {original.Friend.Name}");
            Console.WriteLine($"Clone.Name: {clone.Name}");
            Console.WriteLine($"Clone.Friend.Name: {clone.Friend.Name}");

            // Change only original.Name
            original.Name = "Ali";

            // Print after change
            Console.WriteLine("\nAfter change:");
            Console.WriteLine($"Original.Name: {original.Name}");
            Console.WriteLine($"Original.Friend.Name: {original.Friend.Name}");
            Console.WriteLine($"Clone.Name: {clone.Name}");
            Console.WriteLine($"Clone.Friend.Name: {clone.Friend.Name}");


        }
    }
}
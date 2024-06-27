using System.Security.Cryptography;

namespace _2._Creating_Own_Delegates
{
    internal class Program
    {

        //defining a delegate type called FilterDelegate that takes
        //a person object and returns bool
        public delegate bool FilterDelegate(Person p);

        static void Main(string[] args)
        {
            //Create 4 Person objects
            Person p1 = new Person() { Name = "Aiden", Age = 41 };
            Person p2 = new Person() { Name = "Sif", Age = 69 };
            Person p3 = new Person() { Name = "Walter", Age = 12 };
            Person p4 = new Person() { Name = "Anatoli", Age =25 };

            //add the objects to a list called people
            List<Person> people = new List<Person>() { p1, p2, p3, p4 };

            //here we created a new variable called filter of type FilterDelegate
            //then we assigned an anonymous method to it instead of an already defined method
            //this is anonymous method because it does not have name
            //but behaves like method
            FilterDelegate filter = delegate (Person p)
            //we must return boolean
            {
                return p.Age >= 20 && p.Age <= 30;
            };//we are pretty much declaring variable and assigning its value like x=3;

            DisplayPeople("Young", people, filter);
            //this will print all people
            DisplayPeople("All: ", people, delegate (Person p) { return true; });


            string searchKeyword = "A";
            DisplayPeople("age > 20 with search keyword: " + searchKeyword,people,
                ( p) => 
                {//check if person contains the search keyword and the age is >20
                    if (p.Name.Contains(searchKeyword) && p.Age > 20)
                    {
                        return true;
                    }
                    else { return false; }
                });

            DisplayPeople("exactly 25:", people, p => p.Age == 25);
            //from that method string title is searchKeyword
            //we then eter people - thats where are we searching
            //our lambda expression is p=>{ }
        }

        // a method to display the list of people that passes the filter condition
        //returns true
        //this mehtod will take a title to be displayed, the list of people,
        //and a filter delegate
        static void DisplayPeople(string title, List<Person> people, FilterDelegate filter)
        {
            //print the title
            Console.WriteLine(title);
            foreach(Person p in people) 
            {
                //check if person passes filter
                if (filter(p))
                {
                    //print the persons name and age
                    Console.WriteLine("{0}, {1} years old", p.Name, p.Age);
                }
            }
        }
    }
}

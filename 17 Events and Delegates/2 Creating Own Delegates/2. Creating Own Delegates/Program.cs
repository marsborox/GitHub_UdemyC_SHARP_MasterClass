namespace _2._Creating_Own_Delegates
{
    internal class Program
    {

        //defining a delegate type called FilterDelegate that takes
        //a person object and returns bool
        //
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

            //we will display kids, we are passing the people list 
            //and filter
            DisplayPeople("Kids", people, IsMinor);
            DisplayPeople("Adult",people, IsAdult);
            DisplayPeople("Senior", people, IsSenior);

            
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
        //------------------FILTERS------------------

        static bool IsMinor(Person p)
        {   //if minor true else false*
            //if we would return "true" we get error in DisplayPeople
            //in main
            return p.Age < 18;
        }
        static bool IsAdult(Person p)
        { 
            return p.Age > 18;
        }
        static bool IsSenior(Person p)
        {
            return p.Age >= 65;
        }



    }
}

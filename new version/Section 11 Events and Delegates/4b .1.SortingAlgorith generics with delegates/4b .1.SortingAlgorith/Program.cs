namespace _4b_._1.SortingAlgorith
{
    //delegate will return int and compare T x to T y
    public delegate int Comparsion<T>(T x, T y);

    public class Person
    {
        public int Age { get; set; }
        public string Name { get; set; }
    }
    public class PersonSorter
    {//We Declare delegate
        //will input array and pass our delegate as parameter
        public void Sort(Person[] people, Comparsion<Person> comparsion)
        { // -1 is here because we will not compare ourselves to ourselves
            //go through all people except the last one

            for (int i = 0; i < people.Length - 1; i++)
            {
                for (int j = i + 1; j < people.Length; j++)
                {//we will compare person i to person j except person 0 (bcs thats our initial i)
                    if (comparsion(people[i], people[j]) > 0)
                    {// we are swapping i with j
                        //if one is bigger than another we will swap them
                        Person temp = people[i];
                        people[i] = people[j];
                        people[j] = temp;

                        //people[0] = Alice
                        //people[1] = Bob
                        //people[2] = Charlie
                        //in first iteration we compare alice to bob, then alice to charlie then bob to charlie
                        //we will compare which has bigger age
                        //the swapping line with temp will then swap alice w bob, alice w charlie,.....
                        //it will keep swapping till they are in right order 
                    }
                }
            }
        }
    }
    internal class Program
    {


        static void Main(string[] args)
        {
            Person[] people =
            {
                new Person {Name = "Alice",Age=30},
                new Person {Name = "Bob",Age=25},
                new Person {Name = "Charlie",Age=35},
                new Person {Name = "Denis",Age = 18}
            };
            //instantiation of delegate
            PersonSorter sorter = new PersonSorter();

            //we are passing method to the method bcs thats what we defined in person sorter delegate
            //we invoke here
            sorter.Sort(people, CompareByAge);

            foreach (Person person in people)
            {
                Console.WriteLine($"{person.Name}, {person.Age}");
            }

            Console.WriteLine();

            sorter.Sort(people, CompareByName);

            foreach (Person person in people)
            {
                Console.WriteLine($"{person.Name}, {person.Age}");
            }
        }
        //this method will instantiate the delegate
        // we have delegate that compares people
        //so now we can use it to compare by age, name or other properties if they have it
        static int CompareByAge(Person x, Person y)
        {
            return x.Age.CompareTo(y.Age);
        }
        static int CompareByName(Person x, Person y)
        {
            return x.Name.CompareTo(y.Name);
        }
    }
}

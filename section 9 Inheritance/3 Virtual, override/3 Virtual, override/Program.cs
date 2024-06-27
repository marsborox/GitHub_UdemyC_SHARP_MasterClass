namespace _3_Virtual__override
{
    internal class Program
    {// class animal properties name, age, is hungry
        //constructor
        //methods make sound,eat, play
        static void Main(string[] args)
        {
            Dog dog = new Dog("Rexo", 4);
            Console.WriteLine($"{dog.Name} is {dog.Age}years old");
            dog.MakeSound();
            dog.Play();
            dog.Eat();
        }
    }
}

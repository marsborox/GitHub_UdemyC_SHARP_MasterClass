namespace _2_Polymorphism
{
    public class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Generic animal sound");
        }
    }
    public class Dog:Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Bark");
        }
    }
    public class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Meow");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {//we can treat dog like animal like this
            //what matters is that second part is it dog,cat,....
            Animal myDog = new Dog();
            Animal myCat = new Cat();

            myDog.MakeSound();

            myCat.MakeSound();

            Console.WriteLine();
        }
    }
}

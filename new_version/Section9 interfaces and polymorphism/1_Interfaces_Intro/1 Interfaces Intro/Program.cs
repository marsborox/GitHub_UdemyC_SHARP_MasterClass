namespace _1_Interfaces_Intro
{
    //interface starts with "I"
    public interface IAnimal
    {//there is not implementation - 
        //but when its implemented, has to be implemented in its own way
        void MakeSound();
        void Eat(string food);
    }

    public class Dog : IAnimal
    {
        public void Eat(string food)
        {
            Console.WriteLine("Dog ate "+food); 
        }

        public void MakeSound()
        {
            Console.WriteLine("Bark");
        }
    }
    public class Leopard : IAnimal
    {
        public void Eat(string food)
        {
            Console.WriteLine("Leopard is eating "+food);
        }

        public void MakeSound()
        {
            Console.WriteLine("Roar");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.MakeSound();
            dog.Eat("Granule dopice");


        }
    }
}

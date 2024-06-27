namespace _4_some_other_stuff
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Post post1 = new Post("Thank oyu for birthday wishes", true, "Maros Dude");
            Console.WriteLine(post1.ToString());
            ImagePost imagePost1 = new ImagePost("Check my new shoes","Maros","https://urlnaimg",true);
            Console.WriteLine(imagePost1.ToString());
        }
    }
}

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
            VideoPost videoPost1 = new VideoPost("Fail Video","Maros" ,"www.failarmy",10,true);
            Console.WriteLine(videoPost1.ToString());
            videoPost1.Play();
            Console.ReadKey();
            videoPost1.Stop();
            Console.ReadLine();
        }
    }
}

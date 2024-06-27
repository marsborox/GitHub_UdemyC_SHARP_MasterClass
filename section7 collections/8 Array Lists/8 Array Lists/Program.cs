using System.Collections;

namespace _8_Array_Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {       //declare it
            ArrayList myArrayList = new ArrayList(); //indefinite
            ArrayList myArrayList2 = new ArrayList(100); // or even define number of objects


            myArrayList.Add(25);  //can add any kind of object
            myArrayList.Add("Hello");
            myArrayList.Add("C");
            myArrayList.Add(13);
            myArrayList.Add(13.27);
            myArrayList.Add(253);
            myArrayList.Add(13);

            myArrayList.Remove(13); // will remove element with specific value from array list
                                    //if same hting is there twice it iwll remove first one
            

            //delete element at specific position (index)
            myArrayList.RemoveAt(0); //will remove at position 0 - first one -- so 25 in our case

            Console.WriteLine(myArrayList.Count);

            double sum =0;

            foreach(object obj in myArrayList) 
            {
                if (obj is int)
                {
                    sum += Convert.ToDouble(obj);   //skonvertuj a zrataj cisla ak su double
                }
                else if (obj is double)
                {
                    sum += (double)obj;             //zrataj cisla ak su double (prirataj)
                }
                else if (obj is string) 
                {
                    Console.WriteLine(obj);     //stringz asi len vzpis
                }

            }
            Console.WriteLine(sum);

        }
    }
}

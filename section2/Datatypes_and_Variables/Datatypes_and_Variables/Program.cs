namespace Datatypes_and_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {

            byte myByte = 25;
            Console.WriteLine(myByte);
            sbyte mySbyte = -15;
            Console.WriteLine(mySbyte);
            int myInt = -132486;
            Console.WriteLine(myInt);
            uint myUint = 12389;
            Console.WriteLine(myUint);
            short myShort = 5465;
            Console.WriteLine(myShort);
            ushort myUshort = 46488;
            Console.WriteLine(myUshort);
            float myFloat = -31.85486f;
            Console.WriteLine(myFloat);
            double myDouble = 12.84868;
            Console.WriteLine(myDouble);
            char myChar = 'A';
            Console.WriteLine(myChar);
            bool myBool = false;
            Console.WriteLine(myBool);
            string myText = "Avanti";
            Console.WriteLine(myText);
            string numtext = "1";
            Console.WriteLine(numtext);

            int myNumFromText = int.Parse(numtext);
            Console.WriteLine(myNumFromText);


            Console.ReadLine();


            const string bday = "29.01.1989";

            Console.WriteLine(bday);












        }
    }
}

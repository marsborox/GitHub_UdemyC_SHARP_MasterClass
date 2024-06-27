using System.Collections;
using System.Runtime.CompilerServices;



namespace _9_Hashtables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable studentsTable = new Hashtable();

            Student stud1 = new Student(1, "Maria",98); //we create hashtable
            Student stud2 = new Student(2, "Jason",76);
            Student stud3 = new Student(3, "Maria",43);
            Student stud4 = new Student(4, "Steve", 55);

            studentsTable.Add(stud1.ID, stud1); // we store hastable
            studentsTable.Add(stud2.ID, stud2); //addne to value, object - which value which value of which object
            studentsTable.Add(stud3.ID, stud3);
            studentsTable.Add(stud4.ID, stud4);

                       //retrieve individual item with known ID                                             //retreive data from hashtable
            Student storedStudent1 = (Student)studentsTable[stud1.ID]; //we are casting object to student 
            Console.WriteLine("Student ID: {0}, Name: {1},GPA: {2}", storedStudent1.ID, storedStudent1.Name, storedStudent1.GPA);


            // retrieve all values from hashtable
            // foreach loop type dictionary entry/ struct,itemname im gonna use "entry", Collection we want vlaues from "studentsTable
            foreach (DictionaryEntry entry in studentsTable) 
            {
                Student value = (Student)entry.Value;// We create temporary value it will be our entry value object of type student
                //we must make sure we cast value of correct type which is temp Student
                Console.WriteLine("Student ID: {0}",value.ID);
                Console.WriteLine("Student Name: {0}",value.Name);
                Console.WriteLine("Student GPA: {0}",value.GPA);
            }
            foreach (Student value in studentsTable.Values) //this allows us tocall it directly
            {
                Console.WriteLine("Student ID: {0}", value.ID);
                Console.WriteLine("Student Name: {0}", value.Name);
                Console.WriteLine("Student GPA: {0}", value.GPA);
            }
            

        }
    }
    class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public float GPA { get; set; }
        public Student(int id, string name, float GPA)
        {
            this.ID = id;
            this.Name = name;
            this. GPA = GPA;
        }
    }
}
    

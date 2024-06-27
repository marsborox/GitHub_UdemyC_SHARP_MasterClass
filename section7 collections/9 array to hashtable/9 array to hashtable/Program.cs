using System.Collections;
namespace _9_Hashtable_challenge__export_from_array_to_hashtable_
{

    //Challenge
    /*
     * Write a program that will iterate through each element of the students array
     * and insert them into a hashtable - only IDs
     * If a student with same ID already exists in the hashtable skip it and 
     * display following error :A student with same ID already exists
     * Hint Use method ContainsKey to check wether a student with
     * same ID already exists
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            Student[] students = new Student[5];
            students[0] = new Student(1, "Denis", 88);
            students[1] = new Student(2, "Olaf", 97);
            students[2] = new Student(6, "Ragner", 65);
            students[3] = new Student(1, "Luise", 73);
            students[4] = new Student(4, "Levi", 58);

            Hashtable studentsTable = new Hashtable();
            foreach (Student s in students)
            {
                if (!studentsTable.ContainsKey(s.Id))//check for duplicate id
                {
                    studentsTable.Add(s.Id, s);
                    Console.WriteLine("Student with ID {0} has been added", s.Id);
                }
                else
                {
                    Console.WriteLine("A student with same ID ({0}) already exists", s.Id);
                }
            }
        }
    }

    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float GPA { get; set; }
        public Student(int id, string name, float GPA)
        {
            this.Id = id;
            this.Name = name;
            this.GPA = GPA;
        }
    }
}
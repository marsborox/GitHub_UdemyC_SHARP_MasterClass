using System.Net.Cache;

namespace _02._Linq_With_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UniversityManager um = new UniversityManager();
            um.MaleStudents();
            um.FemaleStudents();
            um.SortStudentsByAge();
            um.AllStudentsFromBeijingTech();
            um.CalledByUserInput();
            um.StudentAndUniversityNameCollection();

            Console.WriteLine("Insert UniID");
            int enteredId = int.Parse(Console.ReadLine());
            um.CalledByUserUniInput(enteredId);

            int[] someInts = { 15, 2, 25, 3, 5, 8, 18, 4, 19, 6 };

            IEnumerable<int> sortedInts = from i in someInts orderby i select i;
            IEnumerable<int> reversedInt = sortedInts.Reverse();
            foreach(int i in reversedInt) 
            { 
                Console.WriteLine(i); 
            }

            IEnumerable<int> reversedSortedInts = from i in someInts orderby i descending select i;
            foreach (int i in reversedSortedInts)
            {
                Console.WriteLine(i);
            }
        }
    }
    class UniversityManager
    {
        public List<University> universities;
        public List<Student> students;

        public UniversityManager() 
        {   //new list of Universities, students,....
            universities = new List<University>();
            students = new List<Student>();

            universities.Add(new University {Id = 1,Name = "Yale" });
            universities.Add(new University { Id = 2, Name = "Beijing Tech" });

            students.Add(new Student { ID = 1, Name = "Carla", Gender = "female", Age = 17, universityId = 1 });
            students.Add(new Student { ID = 2, Name = "Toni", Gender = "male", Age = 21, universityId = 1 });
            students.Add(new Student { ID = 3, Name = "Leila", Gender = "female", Age = 19, universityId = 2 });
            students.Add(new Student { ID = 4, Name = "James", Gender = "male", Age = 25, universityId = 2 });
            students.Add(new Student { ID = 5, Name = "Linda", Gender = "female", Age = 22, universityId = 2 });
        }
        public void MaleStudents()
        {
            IEnumerable<Student> maleStudents = from student in students where student.Gender == "male" select student;
            Console.WriteLine("Male Students");
            foreach (Student student in maleStudents)
            {
                student.Print();
            }
        }
        public void FemaleStudents()
        {
            IEnumerable<Student> femaleStudents = from asdf in students where asdf.Gender == "female" select asdf;
            Console.WriteLine("female Students");
            foreach (Student student in femaleStudents)
            {
                student.Print();
            }
        }
        public void SortStudentsByAge()
        {//he has student there but this demonstrate it is not refered in elsewhere
            //we used var bcs it automaticly picks data type
            //if we call everything - qaz, qwer student its clear its same thing 
            //from code point of view does not matter
            var sortedStudents = from qwer in students orderby qwer.Age select qwer;
            Console.WriteLine("StudentsSortedByAge");
            foreach (Student qaz in sortedStudents)
            {
                qaz.Print();
            }
        }
        public void AllStudentsFromBeijingTech()
        {//we like combine / search in 2 lists
            IEnumerable<Student> beijingStudents = from beijing in students 
                                                   join universityty in universities on beijing.universityId equals universityty.Id
                                                   where universityty.Name == "Beijing Tech"
                                                   select beijing;
            Console.WriteLine("BeijingStudents");
            foreach (Student bei in beijingStudents)
            {
                bei.Print();
            }
        }

        public void CalledByUserInput()
        {
            Console.WriteLine("Insert ID");
            int enteredId = int.Parse(Console.ReadLine());

            IEnumerable<Student> returnedStudent = from returned in students where returned.ID == enteredId select returned;
            Console.WriteLine("Returning student with Id "+enteredId);
            foreach (Student retstud in returnedStudent)
            {
                retstud.Print();
            }
        }
        public void CalledByUserUniInput(int enteredId)
        {
            IEnumerable<Student> beijingStudents = from beijing in students
                                                   join universityty in universities on beijing.universityId equals universityty.Id
                                                   where universityty.Id == enteredId
                                                   select beijing;
            Console.WriteLine("students with uni of entered value Id ");
            foreach (Student bei in beijingStudents)
            {
                bei.Print();
            }
        }//new collection
        public void StudentAndUniversityNameCollection()
        {//this creates new collection pretty much a list
            var newCollection = from student in students
                                join university in universities on student.universityId equals university.Id
                                orderby student.Name
                                select new { StudentName = student.Name, UniversityName = university.Name };
            Console.WriteLine("New Collection:");

            foreach (var col in newCollection)
            {
                Console.WriteLine("Student {0} from University {1}", col.StudentName, col.UniversityName);
            }
        }

    }
    class University
    {
    
            public int Id { get; set; }
        public string Name { get; set; }

        public void Print()
        {
            Console.WriteLine("University {0} with id {1}", Name, Id);
        }
    }

    class Student
    { 
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }

        // Foreign Key
        public int universityId { get; set; }

        public void Print()
        {
            Console.WriteLine("Student {0} with id {1}, Gender {2}, and Age {3} from University with Id {4}", 
                Name, ID, Gender, Age, universityId) ;
        }
    }
}

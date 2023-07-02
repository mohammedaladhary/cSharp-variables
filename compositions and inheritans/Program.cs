using compositions_and_inheritans;

namespace compositions_and_inheritans
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating students, teachers, and courses
            Student student1 = new Student("Mohammed", 22, "Taamir St", 11234, "Grade 12");
            Student student2 = new Student("Ahmed", 19, "Muscat Seeb", 10202, "Grade 11");
            Console.WriteLine();

            Teacher teacher1 = new Teacher("Salim", 25, "Barka", 21001, new List<string> { "IT", "Physics" });
            Teacher teacher2 = new Teacher("Ammar", 20, "Nakhl", 21002, new List<string> { "Ielts Course" });
            Console.WriteLine();

            Course course1 = new Course(012, "Computer Networks", "basics of the course");
            Course course2 = new Course(022, "Database", "basics and standards");
            Console.WriteLine();

            //students in courses
            course1.enrollStudent(student2);
            course2.enrollStudent(student1);
            Console.WriteLine();

            //teachers to courses
            course1.assignTeacher(teacher1);
            course2.assignTeacher(teacher2);
            // Displaying student, teacher, and course details
            Console.WriteLine("Student Details:");
            student1.StudentDetails();
            Console.WriteLine();
            student2.StudentDetails();

            Console.WriteLine("Teacher Details:");
            teacher1.TeacherDetails();
            Console.WriteLine();
            teacher2.TeacherDetails();

            Console.WriteLine("Course Details:");
            Console.WriteLine();
            course1.CourseDetails();
            Console.WriteLine();
            course2.CourseDetails();
        }
    }
}

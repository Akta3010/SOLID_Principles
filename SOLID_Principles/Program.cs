namespace SOLID_Principles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student(new StudentRepository());
            s.SaveStudent();

            Student onlineS = new Student(new OnlineStudentRepository());
            onlineS.SaveStudent();
        }
    }
}
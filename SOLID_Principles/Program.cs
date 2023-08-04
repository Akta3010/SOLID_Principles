namespace SOLID_Principles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student(AbstractFactory.getInstanceOfStudentRepo());
            s.SaveStudent();

            Student onlineS = new Student(AbstractFactory.getInstanceOfOnlineStudentRepo());
            onlineS.SaveStudent();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles
{
    internal class Student : IPerson,IAddress
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string email { get; set; }
        public string password { get; set; }   
        public string address { get; set; }

        //High-level modules should not depend on low-level modules. Both should depend on abstraction - Dependensy Inversion
        //public StudentRepository repository = new StudentRepository();      
        //public void SaveStudent()
        //{
        //    repository.SaveStudent(this);
        //}

        IStudentRepository studentRepository;
        public Student(IStudentRepository student) {
            studentRepository = student;
        }

        public void SaveStudent()
        {
            studentRepository.SaveStudent(this);
        }
        public bool validateAddress(string address)
        {
            bool isValid = false;
            if (address != null) { isValid = true; }
            return isValid;
        }

        public bool validateAge(int age)
        {
            // Subtypes must be substitutable for their base type. - Liskov Substitution Principle
            //throw new NotImplementedException();

            bool res = false;

            if (age > 0)
            {
                res = true;
            }
            return res;
        }

        public bool validateEmail(string email)
        {
            bool res = false; 
            if (email != null && email.EndsWith(".com")) 
            {
                res = true;
            }

            return res;
        }

        public bool validateName(string name)
        {
            bool res = false;
            if (name != null && (name.GetType() == typeof(string)))
            {
                res = true;
            }

            return res;
        }
    }
}

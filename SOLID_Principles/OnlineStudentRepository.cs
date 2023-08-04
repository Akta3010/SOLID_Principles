using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles
{
    internal class OnlineStudentRepository : IStudentRepository
    {
        public void DeleteStudent(Student s)
        {
            
        }

        public void SaveStudent(Student s)
        {
            Console.WriteLine("OnlineStudentRepository.SaveStudent");
        }

        public void UpdateStudent(Student s)
        {
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles
{
    internal interface IStudentRepository
    {
        public void SaveStudent(Student s);
        public void DeleteStudent(Student s);
        public void UpdateStudent(Student s);
    }
}

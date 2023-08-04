using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles
{
    internal class AbstractFactory
    {
        public static IStudentRepository getInstanceOfStudentRepo()
        {
            return new StudentRepository();
        }

        public static IStudentRepository getInstanceOfOnlineStudentRepo()
        {
            return new OnlineStudentRepository();
        }
    }
}

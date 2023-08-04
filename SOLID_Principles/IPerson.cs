using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles
{
    internal interface IPerson
    {
        //Singal Responsibility
        public bool validateName(string name);
        public bool validateAge(int age);   
        
        //Open for Extention Close for Modification
        public virtual bool validatePassword(string pwd)
        {
            bool result = false;

            if(pwd.Length > 8)
            {
                result = true;
            }

            return result;
        }

        public abstract bool validateEmail(string email);
    }
}

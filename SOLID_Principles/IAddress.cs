using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles
{
    internal interface IAddress
    {
        //Interface Segregation Principle
        public bool validateAddress(string address);
    }
}

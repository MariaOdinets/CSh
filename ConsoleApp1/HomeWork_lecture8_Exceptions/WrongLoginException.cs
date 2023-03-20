using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS_homeworks.HomeWork_lecture8_Exceptions
{
    internal class WrongLoginException : Exception
    {
        public WrongLoginException(string message) : base(message)
        {
            
        }
    }
}

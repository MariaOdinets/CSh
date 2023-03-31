using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS_homeworks.HomeWork_lecture8_Exceptions
{
    internal class WrongPasswordException : Exception
    {
        public WrongPasswordException(string message) : base(message)
        {

        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Form_Login
{
    public static class Exceptions
    {
        public class InvalidPassword : Exception
        {
            public InvalidPassword(string message) : base(message)
            {
            }
        }
        public class InvalidLastName : Exception
        {
            public InvalidLastName(string message) : base(message)
            {
            }
        }
        public class InvalidFirstName : Exception
        {
            public InvalidFirstName(string message) : base(message)
            {
            }
        }
    }
}

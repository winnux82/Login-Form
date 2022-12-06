using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Form_Login
{
    public static class Exceptions
    {
        public class UserInvalidPassword : Exception
        {
            public UserInvalidPassword(string message) : base(message)
            {
            }
        }
    }
}

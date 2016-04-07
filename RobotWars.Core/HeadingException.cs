using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotWars.Core
{
    public class HeadingException: Exception
    {
        public HeadingException(string message) : base(message) { }
    }
}

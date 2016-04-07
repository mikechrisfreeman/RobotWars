using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotWars.Core.Arena
{
    public class ArenaException : Exception
    {
        public ArenaException(string message) : base(message) { }
    }
}

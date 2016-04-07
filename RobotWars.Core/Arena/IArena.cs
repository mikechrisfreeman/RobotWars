using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RobotWars.Core.Location;

namespace RobotWars.Core.Arena
{
    public interface IArena
    {
        bool ValidateLocation(ILocation locaton);
    }
}

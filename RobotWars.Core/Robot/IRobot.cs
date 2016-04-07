using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RobotWars.Core.Location;
using RobotWars.Core.Arena;
using RobotWars.Core;

namespace RobotWars.Core.Robot
{
    public interface IRobot
    {
        ILocation Location { get; }
        void Move(Move move);
        int Penalties { get; }
    }
}

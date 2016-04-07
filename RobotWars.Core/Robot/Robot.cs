using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RobotWars.Core.Location;
using RobotWars.Core.Arena;

namespace RobotWars.Core.Robot
{
    public class Robot : IRobot
    {
        private readonly IArena _arena;
        public Robot(ILocation location, IArena arena)
        {
            Location = location;
            _arena = arena;
            Penalties = 0;
        }  

        public ILocation Location
        {
            get;
            private set;
        }

        public int Penalties
        {
            get;
            private set;
        }

        public void Move(Move move)
        {
            ILocation location = Location.MakeMove(move);
            if (_arena.ValidateLocation(location))
                Location = location;
            else
                Penalties = Penalties + 1;
        }
    }
}

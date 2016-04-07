using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RobotWars.Core.Location;

namespace RobotWars.Core.Arena
{
    public class Arena : IArena
    {
        private int X;
        private int Y;

        //Given Time X and Y co-ords would be Typed
        public Arena(int x, int y)
        {
            if (x < 0 || y < 0)
                throw new ArenaException(string.Format("Bad Co-ords, {0}, {1}", x, y));
            X = x;
            Y = y;
        }
        public bool ValidateLocation(ILocation locaton)
        {
            if (locaton.X >= this.X || locaton.X < 0)
                return false;
            if (locaton.Y >= this.Y || locaton.Y < 0)
                return false;
            return true;
        }
    }
}

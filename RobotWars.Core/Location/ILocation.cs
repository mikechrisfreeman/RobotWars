using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotWars.Core.Location
{
    public interface ILocation
    {
        int X { get;}
        int Y { get;}
        Heading Heading { get;}
        ILocation MakeMove(Move move);
    }
}

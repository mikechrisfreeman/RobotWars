using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotWars.Core.Location
{
    public class Location : ILocation
    {
        public Location(int x, int y, Heading heading)
        {
            X = x;
            Y = y;
            Heading = heading;
        }

        public override string ToString()
        {
            return string.Format("({0},{1},{2})", this.X, this.Y, Enum.GetName(typeof(Heading), this.Heading));
        }

        public Heading Heading
        {
            get;
            private set;
        }

        public int X
        {
            get;
            private set;
        }

        public int Y
        {
            get;
            private set;
        }

        public ILocation MakeMove(Move move)
        {
            ILocation newLocation = null;
            switch(move)
            {
                case Move.L:
                    newLocation = TurnNintyLeft();
                    break;
                case Move.R:
                    newLocation = TurnNintyRight();
                    break;
                case Move.M:
                    newLocation = MoveForward();
                    break;
                default:
                    throw new MoveException("Unknown Move = " + move);
            }
            return newLocation;
        }

        private ILocation MoveForward()
        {
            int newx = this.X;
            int newy = this.Y;
            Heading heading = this.Heading;
            switch(this.Heading)
            {
                case Heading.N:
                    newy = newy + 1;
                    break;
                case Heading.S:
                    newy = newy - 1;
                    break;
                case Heading.W:
                    newx = newx - 1;
                    break;
                case Heading.E:
                    newx = newx + 1;
                    break;
            }
            return new Location(newx, newy, heading);
        }

        private ILocation TurnNintyRight()
        {
            switch (this.Heading)
            {
                case Heading.N:
                    return new Location(X, Y, Heading.E);
                case Heading.S:
                    return new Location(X, Y, Heading.W);
                case Heading.W:
                    return new Location(X, Y, Heading.N);
                case Heading.E:
                    return new Location(X, Y, Heading.S);
                default:
                    throw new HeadingException("Uknown heading encountered = " + this.Heading);
            }
        }

        private ILocation TurnNintyLeft()
        {
            switch (this.Heading)
            {
                case Heading.N:
                    return new Location(X, Y, Heading.W);
                case Heading.S:
                    return new Location(X, Y, Heading.E);
                case Heading.W:
                    return new Location(X, Y, Heading.S);
                case Heading.E:
                    return new Location(X, Y, Heading.N);
                default:
                    throw new HeadingException("Uknown heading encountered = " + this.Heading);
            }
        }
    }
}

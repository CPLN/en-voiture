using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnVoiture
{
    public enum Orientation
    {
        NORTH,
        EAST,
        SOUTH,
        WEST
    }

    public static class OrientationMethods
    {
        public static Orientation getOpposite(this Orientation o)
        {
            switch (o)
            {
                case Orientation.NORTH:
                    return Orientation.SOUTH;
                case Orientation.EAST:
                    return Orientation.WEST;
                case Orientation.SOUTH:
                    return Orientation.NORTH;
                case Orientation.WEST:
                    return Orientation.EAST;
            }
            return Orientation.NORTH;
        }
    }
}

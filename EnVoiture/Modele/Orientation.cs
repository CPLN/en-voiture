using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnVoiture.Modele
{
    public enum Orientation
    {
        NORD,
        EST,
        SUD,
        OUEST
    }

    public static class OrientationMethods
    {
        public static Orientation Oppose(this Orientation o)
        {
            switch (o)
            {
                case Orientation.NORD:
                    return Orientation.SUD;
                case Orientation.EST:
                    return Orientation.OUEST;
                case Orientation.SUD:
                    return Orientation.NORD;
                case Orientation.OUEST:
                    return Orientation.EST;
            }
            return Orientation.NORD;
        }
    }
}

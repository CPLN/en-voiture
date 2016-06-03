using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnVoiture
{
    public class IaVoiture
    {
        private Voiture voiture;
        private bool Active;
        public IaVoiture(Voiture v)
        {
            Active = false;
            voiture = v;
        }

        public void Bouger()
        {
            if(Active)
            {
                Route r = ObtenirPosition();
            }
        }
        public Route ObtenirPosition()
        {
            return voiture.ObtenirPosition();
        }

    }
}

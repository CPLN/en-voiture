using EnVoiture.Modele;
using EnVoiture.Vue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace EnVoiture
{
    class savePrefab
    {
        private Voiture Voiture;
        private List<UsagerWidget> _usagers;
        private float zoomRate;
        private List<RouteWidget> Routes;

        public savePrefab() {}

        public Voiture voiture
        {
            get
            {
                return Voiture;
            }
            set
            {
                Voiture = value;
            }
        }

        public List<UsagerWidget> usagers
        {
            get
            {
                return _usagers;
            }
            set
            {
                _usagers = value;
            }
        }

        public float zoomrate
        {
            get
            {
                return zoomRate;
            }
            set
            {
                zoomRate = value;
            }
        }

        public List<RouteWidget> routes
        {
            get
            {
                return Routes;
            }
            set
            {
                Routes = value;
            }
        }

    }
}

using System.Drawing;

namespace EnVoiture
{
    /// <summary>
    /// Classe représentant un élément mobile de l'application, comme une voiture ou un piéton, par exemple.
    /// </summary>
    public abstract class Usager
    {
        private Rectangle bornes;
        private double dblVitesse;
        private double dblVitesseMax;

        /// <summary>
        /// propriété règlant la vitesse
        /// </summary>
        public double Vitesse
        {
            get
            {
                return dblVitesse;
            }
            set
            {
                if (value <= dblVitesseMax)
                {
                    dblVitesse = value;
                }
            }
        }

        /// <summary>
        /// propriété règéant la vitesse maximum 
        /// </summary>
        public double VitesseMax
        {
            get
            {
                return dblVitesseMax;
            }
            set
            {
                dblVitesseMax = value;
            }
        }
        public Rectangle Bornes
        {
            get
            {
                return bornes;
            }
            set
            {
                bornes = value;
            }
        }

        /// <summary>
        /// Emplacement de l'usager
        /// </summary>
        public Point Localisation
        {
            get
            {
                return bornes.Location;
            }
            set
            {
                bornes.Location = value;
            }
        }
        public Size Taille
        {
            get
            {
                return bornes.Size;
            }
            set
            {
                bornes.Size = value;
            }
        }

        /// <summary>
        /// Largeur de l'usager
        /// </summary>
        public int Largeur
        {
            get
            {
                return bornes.Width;
            }
            set
            {
                bornes.Width = value;
            }
        }

        /// <summary>
        /// Hauteur de l'usager
        /// </summary>
        public int Hauteur
        {
            get
            {
                return bornes.Height;
            }
            set
            {
                bornes.Height = value;
            }
        }

        /// <summary>
        /// Position x de la gauche de l'usager
        /// </summary>
        public int Gauche
        {
            get
            {
                return bornes.Left;
            }
        }

        /// <summary>
        /// Position x de la droite de l'usager
        /// </summary>
        public int Droite
        {
            get
            {
                return bornes.Right;
            }
        }

        /// <summary>
        /// Position y du haut de l'usager
        /// </summary>
        public int Haut
        {
            get
            {
                return bornes.Top;
            }
        }

        /// <summary>
        /// Position y du bas de l'usager
        /// </summary>
        public int Bas
        {
            get
            {
                return bornes.Bottom;
            }
        }

        /// <summary>
        /// Angle de rotation de l'usager.
        /// </summary>
        public double Angle { get; set; }

        /// <summary>
        /// Constructeur permettant de définir la position et la taille d'un usager d'après un rectangle.
        /// </summary>
        /// <param name="bounds">Rectangle sur lequel baser la géométrie de l'usager</param>
        public Usager(Rectangle bounds,double v,double vMax)
        {
            this.bornes = bounds;
            VitesseMax = vMax;
            Vitesse = v;
        }

        /// <summary>
        /// Constructeur permettant de définir la position et la taille d'un usager en donnant directement les valeurs.
        /// </summary>
        /// <param name="x">Position x du côté gauche</param>
        /// <param name="y">Position y du haut</param>
        /// <param name="width">Largeur</param>
        /// <param name="height">Hauteur</param>
        /// <param name="v"> vitesse de base </param>
        /// <param name="vMax">vitesse Max</param>
        public Usager(int x, int y, int width, int height, double v, double vMax)
            : this(new Rectangle(x, y, width, height),v,vMax)
        {
           
        }

        /// <summary>
        /// Vérifie si cet usager et un second sont en contact.
        /// </summary>
        /// <param name="other">L'autre usager</param>
        /// <returns>Si cet usager et l'autre se touchent</returns>
        public bool Heurte(Usager other)
        {
            return bornes.IntersectsWith(other.bornes);
        }
        /// <summary>
        /// Vérifie si le clique de souris est en contact avec un usager.
        /// </summary>
        /// <param name="other"></param>
        /// <returns>Si le clique de souris à la même position que l'usager</returns>
        public bool estClique(Point cursorPosition)
        {
            return bornes.IntersectsWith(new Rectangle(cursorPosition, new Size(1, 1)));
        }

        public void Avancer()
        {
            Localisation = new Point(Localisation.X, Localisation.Y - 1);
        }
        public void Gauche()
        {
            Localisation = new Point(Localisation.X - 1, Localisation.Y);
        }
        public void Droite()
        {
            Localisation = new Point(Localisation.X + 1, Localisation.Y);
        }
        public void Reculer()
        {
            Localisation = new Point(Localisation.X, Localisation.Y + 1);
        }
        public void StopDeplacement()
        {
            Localisation = new Point(Localisation.X, Localisation.Y);
        }
    }
}

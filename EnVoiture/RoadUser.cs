using System.Drawing;

namespace EnVoiture
{
    /// <summary>
    /// Classe représentant un élément mobile de l'application, comme une voiture ou un piéton, par exemple.
    /// </summary>
    public abstract class RoadUser
    {
        private Rectangle bounds;

        public Rectangle Bounds
        {
            get
            {
                return bounds;
            }
            set
            {
                bounds = value;
            }
        }

        /// <summary>
        /// Emplacement de l'usager
        /// </summary>
        public Point Location
        {
            get
            {
                return bounds.Location;
            }
            set
            {
                bounds.Location = value;
            }
        }
        public Size Size
        {
            get
            {
                return bounds.Size;
            }
            set
            {
                bounds.Size = value;
            }
        }

        /// <summary>
        /// Largeur de l'usager
        /// </summary>
        public int Width
        {
            get
            {
                return bounds.Width;
            }
            set
            {
                bounds.Width = value;
            }
        }

        /// <summary>
        /// Hauteur de l'usager
        /// </summary>
        public int Height
        {
            get
            {
                return bounds.Height;
            }
            set
            {
                bounds.Height = value;
            }
        }

        /// <summary>
        /// Position x de la gauche de l'usager
        /// </summary>
        public int Left
        {
            get
            {
                return bounds.Left;
            }
        }

        /// <summary>
        /// Position x de la droite de l'usager
        /// </summary>
        public int Right
        {
            get
            {
                return bounds.Right;
            }
        }

        /// <summary>
        /// Position y du haut de l'usager
        /// </summary>
        public int Top
        {
            get
            {
                return bounds.Top;
            }
        }

        /// <summary>
        /// Position y du bas de l'usager
        /// </summary>
        public int Bottom
        {
            get
            {
                return bounds.Bottom;
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
        public RoadUser(Rectangle bounds)
        {
            this.bounds = bounds;
        }

        /// <summary>
        /// Constructeur permettant de définir la position et la taille d'un usager en donnant directement les valeurs.
        /// </summary>
        /// <param name="x">Position x du côté gauche</param>
        /// <param name="y">Position y du haut</param>
        /// <param name="width">Largeur</param>
        /// <param name="height">Hauteur</param>
        public RoadUser(int x, int y, int width, int height)
            : this(new Rectangle(x, y, width, height))
        {
        }

        /// <summary>
        /// Vérifie si cet usager et un second sont en contact.
        /// </summary>
        /// <param name="other">L'autre usager</param>
        /// <returns>Si cet usager et l'autre se touchent</returns>
        public bool Collide(RoadUser other)
        {
            return bounds.IntersectsWith(other.bounds);
        }

        public void Avancer()
        {
            Location = new Point(Location.X, Location.Y + 1);
        }
        public void Gauche()
        {
            Location = new Point(Location.X - 1, Location.Y);
        }
        public void Droite()
        {
            Location = new Point(Location.X + 1, Location.Y);
        }
        public void Reculer()
        {
            Location = new Point(Location.X, Location.Y - 1);
        }
        public void StopDeplacement()
        {
            Location = new Point(Location.X, Location.Y);
        }
    }
}

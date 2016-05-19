using System;
using System.Drawing;

namespace EnVoiture
{
    /// <summary>
    /// Classe représentant un élément mobile de l'application, comme une voiture ou un piéton, par exemple.
    /// </summary>
    public abstract class RoadUser
    {
        private RectangleF bounds;
        private float dblVitesse;
        private float dblVitesseMax;
        private const float ACCELERATION = 10;
        private const float DECCELERATION = 2;
        private const float FREINAGE = 15;

        /// <summary>
        /// propriété règlant la vitesse
        /// </summary>
        public float Vitesse
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
                else
                {
                    dblVitesse = dblVitesseMax;
                }
            }
        }

        /// <summary>
        /// propriété règéant la vitesse maximum 
        /// </summary>
        public float VitesseMax
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
        public RectangleF Bounds
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
        public PointF Location
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
        public SizeF Size
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
        public float Width
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
        public float Height
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
        public float Left
        {
            get
            {
                return bounds.Left;
            }
        }

        /// <summary>
        /// Position x de la droite de l'usager
        /// </summary>
        public float Right
        {
            get
            {
                return bounds.Right;
            }
        }

        /// <summary>
        /// Position y du haut de l'usager
        /// </summary>
        public float Top
        {
            get
            {
                return bounds.Top;
            }
        }

        /// <summary>
        /// Position y du bas de l'usager
        /// </summary>
        public float Bottom
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
        public RoadUser(Rectangle bounds, float v, float vMax)
        {
            this.bounds = bounds;
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
        public RoadUser(int x, int y, int width, int height, float v, float vMax)
            : this(new Rectangle(x, y, width, height),v,vMax)
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
        /// <summary>
        /// Vérifie si le clique de souris est en contact avec un usager.
        /// </summary>
        /// <param name="other"></param>
        /// <returns>Si le clique de souris à la même position que l'usager</returns>
        public bool IsClicked(Point cursorPosition)
        {
            return bounds.IntersectsWith(new Rectangle(cursorPosition, new Size(1, 1)));
        }

        public void Avancer()
        {
            Location = new PointF(Location.X, Location.Y - dblVitesse);
        }
        public void Gauche()
        {
            Location = new PointF(Location.X - 1, Location.Y);
        }
        public void Droite()
        {
            Location = new PointF(Location.X + 1, Location.Y);
        }
        public void Reculer()
        {
            dblVitesse -= ACCELERATION;
            Location = new PointF(Location.X, Location.Y - dblVitesse);
        }
        public void Ralentir()
        {
            if (Vitesse > 0)
            {
                dblVitesse -= DECCELERATION;
            }
            else if(Vitesse<0)
            {
                dblVitesse += DECCELERATION;
            }
        }

        public void Accelerer()
        {
            dblVitesse += ACCELERATION;
        }
        public void Freiner()
        {
            dblVitesse -= FREINAGE;
        }
        public void FreinageUrgence()
        {

        }
    }
}

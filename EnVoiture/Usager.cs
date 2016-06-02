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
        private const float ACCELERATION = 0.10F;
        private const float DECCELERATION = 0.02F;
        private const float FREINAGE = 0.15F;

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
        /// <summary>
        /// propriétét automatique défini la taille en float
        /// </summary>
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
        public float Angle { get; set; }

        /// <summary>
        /// Constructeur permettant de définir la position et la taille d'un usager d'après un rectangle.
        /// </summary>
        /// <param name="bounds">Rectangle sur lequel baser la géométrie de l'usager</param>
<<<<<<< HEAD
        public RoadUser(RectangleF bounds, float v, float vMax)
=======
        public Usager(RectangleF bounds, float v, float vMax)
>>>>>>> Joao/master
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
<<<<<<< HEAD
        public RoadUser(int x, int y, int width, int height, float v, float vMax)
            : this(new Rectangle(x, y, width, height), v, vMax)
=======
        public Usager(float x, float y, float width, float height, float v, float vMax)
            : this(new RectangleF(x, y, width, height), v, vMax)
>>>>>>> Joao/master
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

        /// <summary>
        /// modifie la location en créant un nouveau point et nous permet d'avancer
        /// </summary>
        public void Avancer()
        {
<<<<<<< HEAD
            Location = new PointF((float)(Location.X + Vitesse * Math.Cos(Angle)), (float)(Location.Y + Vitesse * Math.Sin(Angle)));
        }
        /// <summary>
        /// décrémente l'angle de la voiture et nous sert donc a tourner a gauche
        /// </summary>
        public void Gauche()
=======
            Localisation = new PointF((float)(Localisation.X + dblVitesse * Math.Sin(Angle)), (float)(Localisation.Y - dblVitesse * Math.Cos(Angle)));
        }
        public void TournerGauche()
>>>>>>> Joao/master
        {
            Angle -= Vitesse / 100.0F;
        }
        public void TournerDroite()
        {//ACCELERATION = 10F;DECCELERATION = 2F;FREINAGE = 15F;
            Angle += Vitesse / 100.0F;
        }
        /// <summary>
        /// décrémente la vitesse 
        /// </summary>
        public void Reculer()
        {
<<<<<<< HEAD
            Vitesse -= ACCELERATION;
=======
            dblVitesse -= ACCELERATION;
            Localisation = new PointF((float)(Localisation.X + dblVitesse * Math.Sin(Angle)), (float)(Localisation.Y - dblVitesse * Math.Cos(Angle)));
>>>>>>> Joao/master
        }
        /// <summary>
        /// si on ne presse plus rien et que la voiture avance, on ralenti 
        /// </summary>
        public void Ralentir()
        {
            if (Vitesse > 0)
            {
                Vitesse -= DECCELERATION;
            }
            else if (Vitesse < 0)
            {
                Vitesse += DECCELERATION;
            }
        }

        /// <summary>
        /// incrémente la vitesse 
        /// </summary>
        public void Accelerer()
        {
<<<<<<< HEAD
            Vitesse += ACCELERATION;
=======
            dblVitesse += ACCELERATION;
            Avancer();
>>>>>>> Joao/master
        }
        /// <summary>
        /// décrémente la vitesse 
        /// </summary>

        public void Freiner()
        {
            Vitesse -= FREINAGE;
        }
        /// <summary>
        /// pas encore implémenter, décrémentera la vitessse en fonction du freinage d'urgence (gros freinage)
        /// </summary>
        public void FreinageUrgence()
        {

        }
    }
}

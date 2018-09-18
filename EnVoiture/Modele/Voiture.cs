
using System.Drawing;

namespace EnVoiture.Modele
{
    /// <summary>
    /// Représentation d'une voiture dans l'application.
    /// </summary>
    public class Voiture : Usager
    {
        /// <summary>
        /// Constructeur permettant de définir la position et la taille d'une voiture d'après un rectangle.
        /// </summary>
        /// <param name="rectangle">Rectangle sur lequel baser la géométrie de la voiture</param>
        public Voiture(Rectangle rectangle, float vMax) : base(rectangle,0.0F,vMax) { }

        /// <summary>
        /// Constructeur permettant de définir la position et la taille d'une voiture en donnant directement les valeurs.
        /// </summary>
        /// <param name="x">Position x du côté gauche</param>
        /// <param name="y">Position y du haut</param>
        /// <param name="width">Largeur</param>
        /// <param name="height">Hauteur</param>
        public Voiture(int x, int y, int width, int height,float vMax) 
            : base(x, y, width, height,0.0F,vMax)
        {
        }

    }
}


using System.Drawing;
namespace EnVoiture
{
    /// <summary>
    /// Représentation visuelle d'une voiture dans l'application.
    /// </summary>
    public class VoitureWidget : UsagerWidget
    {
        /// <summary>
        /// La voiture liée à cet afficheur.
        /// </summary>
        public Voiture Voiture { get; private set; }

        /// <summary>
        /// Constructeur permettant de définir la position et la taille d'une voiture d'après un rectangle.
        /// </summary>
        /// <param name="rectangle">Rectangle sur lequel baser la géométrie de la voiture</param>
        public VoitureWidget(Rectangle rectangle)
        {
            this.Voiture = new Voiture(rectangle,0.0F);
        }

        /// <summary>
        /// Constructeur permettant de définir la position et la taille d'une voiture en donnant directement les valeurs.
        /// </summary>
        /// <param name="x">Position x du côté gauche</param>
        /// <param name="y">Position y du haut</param>
        /// <param name="width">Largeur</param>
        /// <param name="height">Hauteur</param>
        public VoitureWidget(int x, int y, int width, int height, float vMax)
        {
            this.Voiture = new Voiture(x, y, width, height,vMax);
        }

        public override void Dessiner(Graphics g)
        {
            //g.FillRectangle(Brushes.Red, Voiture.Bornes);
            g.DrawImage(Properties.Resources.voiture, Voiture.Position);
        }
    }
}

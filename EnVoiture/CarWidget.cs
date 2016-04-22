
using System.Drawing;
namespace EnVoiture
{
    /// <summary>
    /// Représentation visuelle d'une voiture dans l'application.
    /// </summary>
    public class CarWidget : RoadUserWidget
    {
        private Car car;

        /// <summary>
        /// La voiture liée à cet afficheur.
        /// </summary>
        public Car Car { get; private set; }

        /// <summary>
        /// Constructeur permettant de définir la position et la taille d'une voiture d'après un rectangle.
        /// </summary>
        /// <param name="rectangle">Rectangle sur lequel baser la géométrie de la voiture</param>
        public CarWidget(Rectangle rectangle)
        {
            this.car = new Car(rectangle,0.0);
        }

        /// <summary>
        /// Constructeur permettant de définir la position et la taille d'une voiture en donnant directement les valeurs.
        /// </summary>
        /// <param name="x">Position x du côté gauche</param>
        /// <param name="y">Position y du haut</param>
        /// <param name="width">Largeur</param>
        /// <param name="height">Hauteur</param>
        public CarWidget(int x, int y, int width, int height, double vMax)
        {
            this.car = new Car(x, y, width, height,vMax);
        }

        public override void Paint(Graphics g)
        {
            g.FillRectangle(Brushes.Red, car.Bounds);
        }
    }
}

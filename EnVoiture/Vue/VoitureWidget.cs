
using System;
using System.Threading;
using System.Drawing;
using EnVoiture.Modele;

namespace EnVoiture.Vue
{
    /// <summary>
    /// Représentation visuelle d'une voiture dans l'application.
    /// </summary>
    public class VoitureWidget : UsagerWidget
    {
        private static Random _random = new Random();
        private Bitmap _textureVoiture;

        /// <summary>
        /// La voiture liée à cet afficheur.
        /// </summary>
        public Voiture Voiture { get; private set; }

        /// <summary>
        /// Constructeur définissant la texture de la voiture.
        /// </summary>
        private VoitureWidget()
        {
            switch (_random.Next(4))
            {
                case 0:
                    this._textureVoiture = Properties.Resources.voiture_bleue;
                    break;
                case 1:
                    this._textureVoiture = Properties.Resources.voiture_jaune;
                    break;
                case 2:
                    this._textureVoiture = Properties.Resources.voiture_rouge;
                    break;
                case 3:
                    this._textureVoiture = Properties.Resources.voiture_violette;
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Constructeur permettant de définir la position et la taille d'une voiture d'après un rectangle.
        /// </summary>
        /// <param name="rectangle">Rectangle sur lequel baser la géométrie de la voiture</param>
        public VoitureWidget(Rectangle rectangle) : this()
        {
            this.Voiture = new Voiture(rectangle, 0.0F);
        }

        /// <summary>
        /// Constructeur permettant de définir la position et la taille d'une voiture en donnant directement les valeurs.
        /// </summary>
        /// <param name="x">Position x du côté gauche</param>
        /// <param name="y">Position y du haut</param>
        /// <param name="largeur">Largeur</param>
        /// <param name="hauteur">Hauteur</param>
        public VoitureWidget(int x, int y, int largeur, int hauteur, float vMax) : this()
        {
            this.Voiture = new Voiture(x, y, largeur, hauteur, vMax);
        }

        public override void Dessiner(Graphics g)
        {
            g.DrawImage(_textureVoiture, Voiture.Position);
        }
    }
}

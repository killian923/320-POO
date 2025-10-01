using Drones.Helpers;

namespace Drones
{
    // Cette partie de la classe Drone définit ce qu'est un drone par un modèle numérique
    public partial class Drone : IExpellable
    {
        private const int FULLCHARGE = 1000;
        private int _charge;                     // La charge actuelle de la batterie
        private string _name;                           // Un nom
        private int _x;                                // Position en X depuis la gauche de l'espace aérien
        private int _y;                                 // Position en Y depuis le haut de l'espace aérien

     


        public int X { get => _x; set => _x = value; }
        public int Y { get => _y; set => _y = value; }
        public string name { get => _name; set => _name = value; }

        public Drone(string name, int x, int y)
        {
            _charge = nbrRandom.rnd.Next(FULLCHARGE);
            _name = name;
            _x = x;
            _y = y;
        }

        // Cette méthode calcule le nouvel état dans lequel le drone se trouve après
        // que 'interval' millisecondes se sont écoulées
        public void Update(int interval)
        {
           
                X += 2;                                    // Il s'est déplacé de 2 pixels vers la droite
                Y += nbrRandom.rnd.Next(-3, 4);                     // Il s'est déplacé d'une valeur aléatoire vers le haut ou le bas
                _charge--;
      
        }

        public bool Evacuate(Rectangle zone)
        {
            throw new NotImplementedException();
        }

        public void FreeFlight()
        {
            throw new NotImplementedException();
        }

        public EvacuationState GetEvacuationState()
        {
            throw new NotImplementedException();
        }
    }
}

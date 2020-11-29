using System;
using System.Collections.Generic;
using System.Text;

namespace FabriqueDeVehicules
{
    public class VoitureEssence : Vehicule, Voiture
    {
        public String Nom { get; set; }

        public void arreterVoiture()
        {
            Console.WriteLine("Arrêt de la voitue essence");
        }

        public void demarrerVoiture()
        {
            Console.WriteLine("Démarrage de la voitue essence");
        }
    }
}

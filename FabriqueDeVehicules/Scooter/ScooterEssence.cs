using System;
using System.Collections.Generic;
using System.Text;

namespace FabriqueDeVehicules.Scooter
{
    public class ScooterEssence : Vehicule, Scooter
    {
        public String Nom { get; set; }

        public void arreterScooter()
        {
            Console.WriteLine("Arrêt du scooter essence");
        }

        public void demarrerScooter()
        {
            Console.WriteLine("Démarrage du scooter essence");
        }
    }
}

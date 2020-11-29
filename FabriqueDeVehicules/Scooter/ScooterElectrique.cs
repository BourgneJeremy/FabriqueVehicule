using System;
using System.Collections.Generic;
using System.Text;

namespace FabriqueDeVehicules.Scooter
{
    public class ScooterElectrique : Vehicule, Scooter
    {
        public String Nom { get; set; }

        public void arreterScooter()
        {
            Console.WriteLine("Arrêt du scooter électrique");
        }

        public void demarrerScooter()
        {
            Console.WriteLine("Démarrage du scooter électrique");
        }
    }
}

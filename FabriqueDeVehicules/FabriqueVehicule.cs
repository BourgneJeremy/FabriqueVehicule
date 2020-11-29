using FabriqueDeVehicules.Scooter;
using System;
using System.Collections.Generic;
using System.Text;

namespace FabriqueDeVehicules
{
    public class FabriqueVehicule
    {
        public void creerVehicule(Enum carburant, Enum typeVehicule)
        {
            switch (carburant)
            {
                case Carburant.ELECTRIQUE:
                    Console.WriteLine("Choix vehicule électrique");

                    switch (typeVehicule)
                    {
                        case TypeVehicule.VOITURE:
                            VoitureElectrique voitureElectrique = new VoitureElectrique();
                            Console.WriteLine("Choix voiture électrique");
                            voitureElectrique.demarrerVoiture();
                            break;
                        case TypeVehicule.SCOOTER:
                            ScooterElectrique scooterElectrique = new ScooterElectrique();
                            Console.WriteLine("Choix scooter électrique");
                            scooterElectrique.demarrerScooter();
                            break;
                        default:
                            Console.WriteLine("Le type du véhicule n'a pas été choisi");
                            break;
                    }

                    break;
                case Carburant.ESSENCE:
                    Console.WriteLine("Choix vehicule essence");

                    switch (typeVehicule)
                    {
                        case TypeVehicule.VOITURE:
                            VoitureEssence voitureEssence = new VoitureEssence();
                            Console.WriteLine("Choix voiture essence");
                            voitureEssence.demarrerVoiture();
                            break;
                        case TypeVehicule.SCOOTER:
                            ScooterEssence scooterEssence = new ScooterEssence();
                            Console.WriteLine("Choix scooter essence");
                            scooterEssence.demarrerScooter();
                            break;
                        default:
                            Console.WriteLine("Le type du véhicule n'a pas été choisi");
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("Une erreur s'est produite");
                    break;
            }
        }
    }
}

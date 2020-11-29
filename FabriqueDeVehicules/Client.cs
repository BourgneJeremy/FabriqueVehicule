using System;
using System.Collections.Generic;
using System.Text;

namespace FabriqueDeVehicules
{
    public enum Carburant
    {
        ESSENCE,
        ELECTRIQUE
    }

    public enum TypeVehicule
    {
        VOITURE,
        SCOOTER
    }

    public class Client
    {
        private int id;
        private String name;

        FabriqueVehicule fabrique;

        public Client() {
            fabrique = new FabriqueVehicule();
        }

        public void creerVehicule(Carburant carburant, TypeVehicule typeVehicule)
        {
            fabrique.creerVehicule(carburant, typeVehicule);
        }
    }
}

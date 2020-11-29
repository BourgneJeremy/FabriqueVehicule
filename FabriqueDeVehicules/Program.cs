using System;

namespace FabriqueDeVehicules
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();
            client.creerVehicule(Carburant.ELECTRIQUE, TypeVehicule.SCOOTER);
        }
    }
}

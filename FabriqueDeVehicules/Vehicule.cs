using System;
using System.Collections.Generic;
using System.Text;

namespace FabriqueDeVehicules
{
    public class Vehicule
    {
        public int NbRoues { get; set; }
        public string PlaqueImmatriculation { get; set; }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}

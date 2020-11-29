using System;
using System.Collections.Generic;
using System.Text;

namespace FabriqueDeVehicules
{
    public sealed class FabriqueVoiture : FabriqueVehicule
    {
        private static FabriqueVoiture instance = null;
        // thread-safe, met un verrou sur l'objet partagé
        private static readonly object padlock = new object();
        FabriqueVoiture()
        {
        }

        public static FabriqueVoiture Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new FabriqueVoiture();
                    }
                    return instance;
                }
            }
        }
    }
}

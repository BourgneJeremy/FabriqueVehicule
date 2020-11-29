using System;
using System.Collections.Generic;
using System.Text;

namespace FabriqueDeVehicules
{
    public sealed class FabriqueScooter : FabriqueVehicule
    {
        private static FabriqueScooter instance = null;
        // thread-safe, met un verrou sur l'objet partagé
        private static readonly object padlock = new object();
        FabriqueScooter()
        {
        }

        public static FabriqueScooter Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new FabriqueScooter();
                    }
                    return instance;
                }
            }
        }
    }
}

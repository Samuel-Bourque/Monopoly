using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboMonopoly_Affaires
{
    public class ServicePublic : Propriete
    {
        public enum TypeServicePublic { Aqueducs, Electricite };
        public TypeServicePublic Service {get; set;}

        public ServicePublic(string nm) : base(nm, 150m)
        {
            if (nm.Equals("Aqueducs"))
                Service = TypeServicePublic.Aqueducs;
            else
                Service = TypeServicePublic.Electricite;
        }

        public override decimal calculerCoutLocation()
        {
            Random r = new Random();
            return 4 * r.Next(1, 6);
        }
    }
}

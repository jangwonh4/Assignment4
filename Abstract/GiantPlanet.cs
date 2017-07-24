using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    class GiantPlanet : Planet, IHasMoons, IHasRings
    {
        private string _type;
        
        public GiantPlanet(string name, double diameter, double mass, string type) : base(name,diameter,mass)
        {
            if (type == "Gas".ToLower())
                Console.WriteLine("Type = Gas");
            else
                Console.WriteLine("Type = Ice");
            this._type = type;

            
        }
        public bool HasMoons()
        {
            if (MoonCount > 0)
            {
                return true;
            }
            else
                return false;

        }
        public bool HasRings()
        {
            if (RingCount > 0)
            {
                return true;
            }
            else
                return false;
        }



    }
}

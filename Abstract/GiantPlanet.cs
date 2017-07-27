using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Name: Mingi Jang
 * Date: July 27, 2017
 * Description: Assignment4
 * Version: 0.7 - Add GiantPlanet Class
 */

namespace Abstract
{
    class GiantPlanet : Planet, IHasMoons, IHasRings
    {
        private string _type;
        
        public GiantPlanet(string name, double diameter, double mass, string type) : base(name,diameter,mass)
        {
            if (type == "Gas".ToLower() || type == "Ice".ToLower())
            {
                if (type == "Gas".ToLower())
                {
                    this._type = type;
                    Console.WriteLine("Type = {0}", type);
                }
            }
            else
            { Console.WriteLine("Invalid type"); }

            

            
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

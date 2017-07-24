using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            GiantPlanet giantplanet1 = new GiantPlanet("Mika planet",10,100,"Ice");
            Console.WriteLine(giantplanet1.ToString());
            Console.WriteLine("\n");
            GiantPlanet giantplanet2 = new GiantPlanet("Jongwan planet", 125, 400, "gas");
            Console.WriteLine(giantplanet2.ToString());
            Console.WriteLine("\n");
            TerrestrialPlanet Terrestrial1 = new TerrestrialPlanet("Mingi Planet",10,10,true);
            Console.WriteLine(Terrestrial1.ToString());
            Console.WriteLine("\n");
            TerrestrialPlanet Terrestrial2 = new TerrestrialPlanet("Donwan Planet", 12, 14, false);
            Console.WriteLine(Terrestrial2.ToString());

        }
    }
}

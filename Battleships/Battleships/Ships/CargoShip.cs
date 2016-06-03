using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Battleships.Ships
{
   public class CargoShip : Ship
    {
       
        public CargoShip(string name, double lengthInMeters, double volume)
            :base(name,lengthInMeters,volume)
        {
            
        }

    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Battleships.Ships
{
     public class Warship : BattlesShip
    {
       

        public Warship(string name, double lengthInMeters, double volume)
            :base(name,lengthInMeters,volume)
        {
            
        }

        public override string Attak(Ship targetShip)
        {
            base.Attak(targetShip);
            return "Victory is ours!";
        }
       
    }
}


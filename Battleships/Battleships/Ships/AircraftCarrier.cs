using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Battleships.Ships
{
    public class AircraftCarrier : BattlesShip
    {
        
        private int fighterCapacity;

        public AircraftCarrier(string name, double lengthInMeters, double volume, int fighterCapacity)
            :base(name,lengthInMeters,volume)
        {
            
            this.FighterCapacity = fighterCapacity;
          
        }

        public int FighterCapacity
        {
            get
            {
                return this.fighterCapacity;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("value", "The fighter capacity of an aircraft carrier cannot be negative.");
                }

                this.fighterCapacity = value;
            }
        }
        public override string Attak(Ship targetShip)
        {
            base.Attak(targetShip);
            return "We bombed them from the sky!";
        }
        
    }
}


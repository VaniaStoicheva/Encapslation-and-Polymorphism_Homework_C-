using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Battleships.Contracts;

namespace Battleships.Ships
{
    public abstract class BattlesShip:Ship,IAttak
    {
        protected BattlesShip(string name, double lengthInMeters, double volume)
            :base(name,lengthInMeters,volume)
        {
        }
        public void DestroyShip(Ship targetShip)
        {
            targetShip.IsDestroyed = true;
        }
        public virtual string Attak(Ship targetShip)
        {
            this.DestroyShip(targetShip);
            return "";
        }
    }
}

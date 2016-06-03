using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameEngine.Chatacters
{
   public abstract class AdvancedCharacters:Character
    {
       protected AdvancedCharacters(string id, int x, int y, int healthPoints, int defensePoints, Team team, int range)
           : base(id,x,y,healthPoints,defensePoints,team,range)
       {
       }
     public override void AddToInventory(Item item)
        {
            this.ApplyItemEffects(item);
            this.Inventory.Add(item);
        }

        public override void RemoveFromInventory(Item item)
        {
            this.RemoveItemEffects(item);
            this.Inventory.Remove(item);
        }
    }
}

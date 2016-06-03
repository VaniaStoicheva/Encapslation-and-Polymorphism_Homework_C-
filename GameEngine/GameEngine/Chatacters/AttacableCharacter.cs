﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GameEngine.Interfaces;

namespace GameEngine.Chatacters
{
    public abstract class AttacableCharacter:AdvancedCharacters,IAttack
    {
        protected AttacableCharacter(string id, int x, int y, int healthPoints, int defensePoints, Team team, int range)
            :base(id,x,y,healthPoints,defensePoints,team,range)
        {
        }
        protected override void ApplyItemEffects(Item item)
        {
            base.ApplyItemEffects(item);
            this.AttackPoints += item.AttackEffect;
        }
        protected override void RemoveItemEffects(Item item)
        {
            base.RemoveItemEffects(item);
            this.AttackPoints -= item.AttackEffect;
        }
        public override string ToString()
        {
            return base.ToString()+ ", Attack:"+this.AttackPoints;
        }
        public int AttackPoints { get; set;}
    }
}

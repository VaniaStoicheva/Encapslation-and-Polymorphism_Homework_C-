using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GameEngine.Interfaces;

namespace GameEngine.Chatacters
{

   public class Warrior:AttacableCharacter,IAttack
    {
        private const int AttackPointsDefault = 150;
        private const int DefencePointsDefault = 100;
        private const int HealthPointsDefault = 200;
        private const int RangeDefault =2;

        public Warrior(
            string id,
            int x,
            int y, 
            Team team)
            : base(id, x, y, HealthPointsDefault, DefencePointsDefault, team, RangeDefault)
        {
            this.AttackPoints = AttackPointsDefault;
        }

        public override Character GetTarget(IEnumerable<Character> targetsList)
        {
            
            return targetsList.FirstOrDefault(c=>c.IsAlive && c.Team!=this.Team);
        }

        public int AttackPoints {get; set;}
        
    }
}

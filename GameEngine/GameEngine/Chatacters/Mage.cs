using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GameEngine.Interfaces;

namespace GameEngine.Chatacters
{
 public   class Mage : AttacableCharacter, IAttack
    {
        private const int AttackPointsDefault = 3000;
        private const int DefencePointsDefault = 50;
        private const int HealthPointsDefault = 150;
        private const int RangeDefault = 5;

        public Mage(
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

            return targetsList.LastOrDefault(c=>c.IsAlive && c.Team!=this.Team);
        }

        public int AttackPoints { get; set; }

    }
}

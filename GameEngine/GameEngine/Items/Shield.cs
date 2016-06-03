using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameEngine.Items
{
    public class Shield : Item
    {
        private const int HealthEffectDefault = 0;
        private const int DefenceEffectDefault = 50;
        private const int AttackEffectDefault = 0;

        public Shield(string id)
            : base(id, HealthEffectDefault, DefenceEffectDefault, AttackEffectDefault)
        {
        }
    }
}

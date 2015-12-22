using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSlum.Items
{
    public class Pill : Bonus
    {
        private const int DefaultAttackEffect = 100;
        private const int DefaultCountDown = 1;

        public Pill(string id, int defenseEffect, int healthEffect, int attackEffect = DefaultAttackEffect)
            : base(id, healthEffect, defenseEffect, attackEffect)
        {
            this.Countdown = DefaultCountDown;
        }
    }
}

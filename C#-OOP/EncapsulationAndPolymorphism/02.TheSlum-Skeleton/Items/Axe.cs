﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSlum.Items
{
    public class Axe : Item
    {
        private const int DefaultHealthEffect = 0;
        private const int DefaultDefenseEffect = 0;
        private const int DefaultAttackEffect = 75;

        public Axe(string id, int healthEffect = DefaultHealthEffect,
            int defenseEffect = DefaultDefenseEffect, int attackEffect = DefaultAttackEffect)
            : base(id, healthEffect, defenseEffect, attackEffect)
        {

        }
    }
}

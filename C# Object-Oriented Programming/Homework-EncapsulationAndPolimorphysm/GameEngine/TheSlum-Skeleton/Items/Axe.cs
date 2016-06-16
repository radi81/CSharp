using System;

namespace TheSlum.Items
{
    class Axe : Item
    {
        private const int AxeHealthEffect = 0;
        private const int AxeDefenseEffect = 0;
        private const int AxeAttackEffect = 75;

        protected Axe (string id, int healthEffect, int defenseEffect, int attackEffect)
            : base(id, AxeHealthEffect, AxeDefenseEffect, AxeAttackEffect)
        {
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSlum.Items
{
    class Shield : Item
    {
        private const int ShieldHealthEffect = 0;
        private const int ShieldDefenseEffect = 50;
        private const int ShieldAttackEffect = 0;

        protected Shield(string id, int healthEffect, int defenseEffect, int attackEffect)
            : base(id, ShieldHealthEffect, ShieldDefenseEffect, ShieldAttackEffect)
        {
        }
    }
}

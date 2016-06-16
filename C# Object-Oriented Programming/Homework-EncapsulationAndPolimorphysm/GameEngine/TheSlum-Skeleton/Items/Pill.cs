using System;

namespace TheSlum.Items
{
    class Pill : Bonus
    {
        private const int PillHealthEffect = 0;
        private const int PillAttackEffect = 100;
        private const int PillDefenceEffect = 0;
        private const int PillTimeout = 1;

        protected Pill(string id, int healthEffect, int defenseEffect, int attackEffect)
            : base(id, PillHealthEffect, PillDefenceEffect, PillAttackEffect)
        {
            this.Timeout = PillTimeout;
            this.Countdown = 1;
            this.HasTimedOut = false;
        }
    }
}

using System;

namespace TheSlum.Items
{
    class Injection : Bonus
    {
        private const int InjectionHealthEffect= 200;
        private const int InjectionAttackEffect = 0;
        private const int InjectionDefenseEffect = 0;
        private const int InjectionCountdown = 3;

        protected Injection(string id, int healthEffect, int defenseEffect, int attackEffect)
            : base(id, InjectionHealthEffect, InjectionDefenseEffect, InjectionAttackEffect)
        {
            this.Timeout = 3;
            this.Countdown = InjectionCountdown;
            this.HasTimedOut = false;
        }
    }
}


using System;
using System.Linq;
using System.Collections.Generic;
using TheSlum.Interfaces;
using TheSlum.Items;

namespace TheSlum
{
    class Healer : Character, IHeal
    {
        private const int DefaultHealerHealthPoints = 75;
        private const int DefaultHealerDefensePoints = 50;
        private const int DefaultHealerHealingPoints = 60;
        private const int DefaultHealerRange = 6;

        private Healer(string id, int x, int y, int healthPoints, int defensePoints, Team team, int range)
            : base(id, x, y, DefaultHealerHealthPoints, DefaultHealerDefensePoints, team, DefaultHealerRange)
        {
            this.HealingPoints = DefaultHealerHealingPoints;
        }
        
        public int HealingPoints { get; set; }

        public override Character GetTarget(IEnumerable<Character> targetsList)
        {
            Character target = targetsList
                .Where(a => a.IsAlive && a.Id != this.Id && a.Team != this.Team)
                .OrderBy(a => a.HealthPoints)
                .First();
            return target;
        }

        public override void AddToInventory(Item item)
        {
            this.Inventory.Add(item);
            this.ApplyItemEffects(item);
        }

        public override void RemoveFromInventory(Item item)
        {
            this.Inventory.Remove(item);
            this.RemoveItemEffects(item);
        }

        protected override void ApplyItemEffects(Item item)
        {
            base.ApplyItemEffects(item);
        }

        protected override void RemoveItemEffects(Item item)
        {
            base.RemoveItemEffects(item); 
        }

        public override string ToString()
        {
            return base.ToString() + ", Healing: " + this.HealingPoints;
        }
    }
}

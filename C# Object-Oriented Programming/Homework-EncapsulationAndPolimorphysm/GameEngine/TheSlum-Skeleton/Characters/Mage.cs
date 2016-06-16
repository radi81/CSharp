using System;
using System.Linq;
using System.Collections.Generic;
using TheSlum.Interfaces;

namespace TheSlum.Characters
{
    class Mage : Character, IAttack
    {
        private const int DefaultMageHealthPoints = 150;
        private const int DefaultMageDefensePoints = 50;
        private const int DefaultMageAttackPoints = 300;
        private const int DefaultMageRange = 5;

        private Mage(string id, int x, int y, int healthPoints, int defensePoints, Team team, int range)
            : base(id, x, y, DefaultMageHealthPoints, DefaultMageDefensePoints, team, DefaultMageRange)
        {
            this.AttackPoints = DefaultMageAttackPoints;
        }

        public int AttackPoints { get; set; }

        public override Character GetTarget(IEnumerable<Character> targetsList)
        {
            Character target = targetsList
                .LastOrDefault(a => a.IsAlive && a.Team != this.Team);
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
            this.AttackPoints += item.AttackEffect;
        }

        protected override void RemoveItemEffects(Item item)
        {
            base.RemoveItemEffects(item);
            this.AttackPoints -= item.AttackEffect;
        }

        public override string ToString()
        {
            return base.ToString() + ", Attack: " + this.AttackPoints;
        }
    }
}



using System;
using System.Linq;
using System.Collections.Generic;
using TheSlum.Interfaces;
using TheSlum.Items;


namespace TheSlum.Characters
{
    class Warrior : Character, IAttack
    {
        private const int DefaultWarriorHealthPoints = 200;
        private const int DefaultWarriorDefensePoints = 100;
        private const int DefaultWarriorAttackPoints = 100;
        private const int DefaultWarriorRange = 2;

        private Warrior(string id, int x, int y, int healthPoints, int defensePoints, Team team, int range)
            : base(id, x, y, DefaultWarriorHealthPoints, DefaultWarriorDefensePoints, team, DefaultWarriorRange)
        {
            this.AttackPoints = DefaultWarriorAttackPoints;
        }

        public int AttackPoints { get; set; }

        public override Character GetTarget(IEnumerable<Character> targetsList)
        {
            Character target = targetsList
                .FirstOrDefault(a => a.IsAlive && (a.Team != this.Team) && (a.Id != this.Id));
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

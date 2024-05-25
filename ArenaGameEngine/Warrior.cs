using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGameEngine
{
    public class Warrior : Hero
    {
        public Warrior() : base("Warrior")
        {
        }
        public Warrior(string name) : base(name)
        {
        }



        public override int Attack()
        {
            int baseAttack = base.Attack();

            if (Health <= 200)
            {
                baseAttack = Strength * 5;
            }
            return baseAttack;
        }
        public override void TakeDamage(int incomingDamage)
        {
            int dice = Random.Shared.Next(0, 100);
            if (dice <= 20)
            {
                incomingDamage = 0;
            }
            base.TakeDamage(incomingDamage);
        }
    }
}
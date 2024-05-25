using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGameEngine
{
    public class Necromancer : Hero
    {
        public bool Imune { get; set; }

        public Necromancer() : base("Necromancer")
        {
        }
        public Necromancer(string name) : base(name)
        {
        }
        public override void TakeDamage(int incomingDamage)
        {
            int n = Random.Shared.Next(0, 100);
            if (n <= 50 || Imune == true)
            {
                incomingDamage = 0;
            }
            base.TakeDamage(incomingDamage);
        }

        public override int Attack()
        {
            int drainLife = base.Attack();


            int dice = Random.Shared.Next(0, 100);
            if (dice <= 20)
            {
                drainLife = Strength * 3;

            }
            return drainLife;
        }


        public override int GainHealth()
        {
            int gainLife = base.GainHealth();
            int dice2 = Random.Shared.Next(0, 100);
            if (dice2 <= 10)
            {
                gainLife = Health + 100;
            }
            return gainLife;
        }
    }
}

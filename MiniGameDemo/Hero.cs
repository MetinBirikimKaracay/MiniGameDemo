using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniGameDemo
{
    class Hero
    {

        public Hero(int id,int heroHp, string heroName, int heroAttack)
        {
            this.Id = id;
            this.HeroAttack = heroAttack;
            this.HeroHp = heroHp;
            this.HeroName = heroName;
        }

        public int Id { get; set; }

        public int HeroHp { get; set; }

        public string HeroName { get; set; }

        public int HeroAttack { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniGameDemo
{
    class Enemy
    {
        public Enemy(int id, int enemyHp, string enemyName, int enemyAttack)
        {
            this.Id = id;
            this.EnemyAttack = enemyAttack;
            this.EnemyHp = enemyHp;
            this.EnemyName = enemyName;
        }

        public int Id { get; set; }

        public int EnemyHp { get; set; }

        public string EnemyName { get; set; }

        public int EnemyAttack { get; set; }
    }
}

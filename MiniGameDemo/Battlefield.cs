using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniGameDemo
{
    public partial class Battlefield : Form
    {
        public Battlefield()
        {
            InitializeComponent();
        }
        Hero hero;
        Enemy enemy;
        Random bonus = new Random();

        int answer,sayac = 4,tempAttack;
        string x, y;
        private void BtnSend_Click(object sender, EventArgs e)
        {
            
            answer = Int32.Parse(x) + Int32.Parse(y);

            if (txtAnswer.Text == answer.ToString())
            {
                Attack(hero);
                
                lstbxActions.Items.Add(hero.HeroName+" isimli Oyuncu " + tempAttack + " vurdu");
            }
            else if (sayac == 0)
            {
                pbEnemyHealth.Value -= hero.HeroAttack;
                lstbxActions.Items.Add(hero.HeroName + " isimli Oyuncu " + hero.HeroAttack + " vurdu");
            }
            Result();
        }

        public void Result()
        {
            WarResult result = new WarResult();

            if (pbEnemyHealth.Value <= 0)
            {
                result.header = "Win!";
                result.image = @"C:\Users\birik\Desktop\savas\hero.png";
                result.Show();
            }
            else if (pbHeroHealth.Value <= 0)
            {
                result.header = "Lose!";
                result.image = @"C:\Users\birik\Desktop\savas\enemy1.png";
                result.Show();
            }
            else
            {
                lblQuestion.Text = QuestionGenerator();
                pbEnemyHealth.BackColor = Color.Red;
                this.Refresh();
            }
        }

        private void Battlefield_Load(object sender, EventArgs e)
        {
            lblQuestion.Text = QuestionGenerator();

            hero = new Hero(1,100,"Kahraman",10);
            enemy = new Enemy(1, 100, "Düşman", 20);

            lblEnemyHP.Text = enemy.EnemyHp.ToString();
            lblHeroHP.Text = hero.HeroHp.ToString();

            timer1.Start();
        }

        private void Attack(Hero hero)
        {
            tempAttack = (hero.HeroAttack + bonus.Next(0, 15));
            
            if (tempAttack > pbEnemyHealth.Value)
            {
                pbEnemyHealth.Value = 0;
                timer1.Stop();

            }
            else
            {
                pbEnemyHealth.Value = pbEnemyHealth.Value - tempAttack;
            }

            lblEnemyHP.Text = pbEnemyHealth.Value.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac--;
            lblTime.Text = sayac.ToString();
            if(sayac == 0)
            {
                timer1.Stop();
                pbEnemyHealth.Value -= hero.HeroAttack;
                lblEnemyHP.Text = pbEnemyHealth.Value.ToString();
                BtnSend.Enabled = false;
            }

        }

        private string QuestionGenerator()
        {
            Random r = new Random();

            x = r.Next(1,10).ToString();
            y = r.Next(1,10).ToString();

            sayac = 4;
            timer1.Start();

            return x + " + " + y;
        }
    }
}

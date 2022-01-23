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


        int answer;
        string x, y;
        private void BtnSend_Click(object sender, EventArgs e)
        {
            WarResult result = new WarResult();
            answer = Int32.Parse(x) + Int32.Parse(y);

            if (txtAnswer.Text == answer.ToString())
            {
                pbEnemyHealth.Value = pbEnemyHealth.Value - 10;
                lstbxActions.Items.Add("Hero isimli Oyuncu " + answer + " vurdu");

                if (pbEnemyHealth.Value == 0)
                {
                    result.header = "Win!";
                    result.image = @"C:\Users\birik\Desktop\savas\hero.png";
                    result.Show();
                }
                else if (pbHeroHealth.Value == 0)
                {
                    result.header = "Win!";
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
            else
            {
                // yanlış girdin bonus kaçtı
            }
        }

        private void Battlefield_Load(object sender, EventArgs e)
        {
            lblQuestion.Text = QuestionGenerator();
        }

        private void Battlefield_Paint(object sender, PaintEventArgs e)
        {
            /*
            System.Drawing.Graphics grafik;
            grafik = this.CreateGraphics();
            Brush doldur = new SolidBrush(System.Drawing.Color.DarkBlue);
            grafik.FillRectangle(doldur, 150, 50, 300, 20);
        */
        }

        private string QuestionGenerator()
        {
            Random r = new Random();

            x = r.Next(1,10).ToString();
            y = r.Next(1,10).ToString();

            return x + " + " + y;
        }
    }
}

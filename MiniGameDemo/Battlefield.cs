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
            answer = Int32.Parse(x) + Int32.Parse(y);

            if (txtAnswer.Text == answer.ToString())
            {
                pbEnemyHealth.Value = pbEnemyHealth.Value - 10;
                lblQuestion.Text = QuestionGenerator();
                this.Refresh();
            }
        }

        private void Battlefield_Load(object sender, EventArgs e)
        {
            lblQuestion.Text = QuestionGenerator();
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

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
    public partial class WarResult : Form
    {
        public WarResult()
        {
            InitializeComponent();
        }
        public string header,heroName,image;
        private void btnAccept_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void WarResult_Load(object sender, EventArgs e)
        {
            lblHeader.Text = heroName + " " + header;
            pbWinner.ImageLocation = image;
        }
    }
}

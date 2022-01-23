
namespace MiniGameDemo
{
    partial class Battlefield
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Battlefield));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pbHeroHealth = new System.Windows.Forms.ProgressBar();
            this.pbEnemyHealth = new System.Windows.Forms.ProgressBar();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.lstbxActions = new System.Windows.Forms.ListBox();
            this.BtnSend = new System.Windows.Forms.Button();
            this.lblHeroHP = new System.Windows.Forms.Label();
            this.lblEnemyHP = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblTime = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(102, 66);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(232, 268);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(667, 66);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(224, 268);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pbHeroHealth
            // 
            this.pbHeroHealth.BackColor = System.Drawing.Color.LimeGreen;
            this.pbHeroHealth.Enabled = false;
            this.pbHeroHealth.Location = new System.Drawing.Point(102, 24);
            this.pbHeroHealth.Name = "pbHeroHealth";
            this.pbHeroHealth.Size = new System.Drawing.Size(232, 23);
            this.pbHeroHealth.TabIndex = 2;
            this.pbHeroHealth.Value = 100;
            // 
            // pbEnemyHealth
            // 
            this.pbEnemyHealth.BackColor = System.Drawing.Color.Red;
            this.pbEnemyHealth.Enabled = false;
            this.pbEnemyHealth.ForeColor = System.Drawing.Color.Red;
            this.pbEnemyHealth.Location = new System.Drawing.Point(667, 24);
            this.pbEnemyHealth.Name = "pbEnemyHealth";
            this.pbEnemyHealth.Size = new System.Drawing.Size(224, 23);
            this.pbEnemyHealth.TabIndex = 3;
            this.pbEnemyHealth.Value = 100;
            // 
            // txtAnswer
            // 
            this.txtAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAnswer.Location = new System.Drawing.Point(396, 285);
            this.txtAnswer.Multiline = true;
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(201, 32);
            this.txtAnswer.TabIndex = 4;
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblQuestion.Location = new System.Drawing.Point(466, 241);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(56, 24);
            this.lblQuestion.TabIndex = 5;
            this.lblQuestion.Text = "2 + 3";
            // 
            // lstbxActions
            // 
            this.lstbxActions.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstbxActions.FormattingEnabled = true;
            this.lstbxActions.ItemHeight = 19;
            this.lstbxActions.Location = new System.Drawing.Point(102, 388);
            this.lstbxActions.Name = "lstbxActions";
            this.lstbxActions.Size = new System.Drawing.Size(789, 213);
            this.lstbxActions.TabIndex = 6;
            // 
            // BtnSend
            // 
            this.BtnSend.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSend.Location = new System.Drawing.Point(448, 339);
            this.BtnSend.Name = "BtnSend";
            this.BtnSend.Size = new System.Drawing.Size(90, 27);
            this.BtnSend.TabIndex = 7;
            this.BtnSend.Text = "Send";
            this.BtnSend.UseVisualStyleBackColor = true;
            this.BtnSend.Click += new System.EventHandler(this.BtnSend_Click);
            // 
            // lblHeroHP
            // 
            this.lblHeroHP.AutoSize = true;
            this.lblHeroHP.BackColor = System.Drawing.Color.Transparent;
            this.lblHeroHP.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeroHP.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblHeroHP.Location = new System.Drawing.Point(340, 24);
            this.lblHeroHP.Name = "lblHeroHP";
            this.lblHeroHP.Size = new System.Drawing.Size(43, 22);
            this.lblHeroHP.TabIndex = 8;
            this.lblHeroHP.Text = "100";
            // 
            // lblEnemyHP
            // 
            this.lblEnemyHP.AutoSize = true;
            this.lblEnemyHP.BackColor = System.Drawing.Color.Transparent;
            this.lblEnemyHP.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnemyHP.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblEnemyHP.Location = new System.Drawing.Point(618, 24);
            this.lblEnemyHP.Name = "lblEnemyHP";
            this.lblEnemyHP.Size = new System.Drawing.Size(43, 22);
            this.lblEnemyHP.TabIndex = 9;
            this.lblEnemyHP.Text = "100";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(475, 185);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(0, 24);
            this.lblTime.TabIndex = 10;
            // 
            // Battlefield
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 627);
            this.ControlBox = false;
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblEnemyHP);
            this.Controls.Add(this.lblHeroHP);
            this.Controls.Add(this.BtnSend);
            this.Controls.Add(this.lstbxActions);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.pbEnemyHealth);
            this.Controls.Add(this.pbHeroHealth);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Battlefield";
            this.Text = "Battlefield";
            this.Load += new System.EventHandler(this.Battlefield_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ProgressBar pbHeroHealth;
        private System.Windows.Forms.ProgressBar pbEnemyHealth;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.ListBox lstbxActions;
        private System.Windows.Forms.Button BtnSend;
        private System.Windows.Forms.Label lblHeroHP;
        private System.Windows.Forms.Label lblEnemyHP;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblTime;
    }
}
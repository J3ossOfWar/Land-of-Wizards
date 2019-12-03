namespace Game
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lvlLabel = new System.Windows.Forms.Label();
            this.ExperienceBar = new System.Windows.Forms.ProgressBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Hitpoint = new System.Windows.Forms.ProgressBar();
            this.SendBtn = new System.Windows.Forms.Button();
            this.StatusBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lvlLabel
            // 
            this.lvlLabel.AutoSize = true;
            this.lvlLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlLabel.Location = new System.Drawing.Point(2, 1027);
            this.lvlLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lvlLabel.Name = "lvlLabel";
            this.lvlLabel.Size = new System.Drawing.Size(117, 24);
            this.lvlLabel.TabIndex = 0;
            this.lvlLabel.Text = "Level :  100";
            // 
            // ExperienceBar
            // 
            this.ExperienceBar.Location = new System.Drawing.Point(123, 1027);
            this.ExperienceBar.Margin = new System.Windows.Forms.Padding(2);
            this.ExperienceBar.Name = "ExperienceBar";
            this.ExperienceBar.Size = new System.Drawing.Size(1301, 19);
            this.ExperienceBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.ExperienceBar.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Game.Properties.Resources.map1;
            this.pictureBox1.Location = new System.Drawing.Point(1428, 877);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(252, 171);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Hitpoint
            // 
            this.Hitpoint.Enabled = false;
            this.Hitpoint.ForeColor = System.Drawing.Color.Red;
            this.Hitpoint.Location = new System.Drawing.Point(6, 877);
            this.Hitpoint.Margin = new System.Windows.Forms.Padding(2);
            this.Hitpoint.Maximum = 10;
            this.Hitpoint.Name = "Hitpoint";
            this.Hitpoint.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Hitpoint.Size = new System.Drawing.Size(100, 148);
            this.Hitpoint.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.Hitpoint.TabIndex = 4;
            this.Hitpoint.Value = 10;
            // 
            // SendBtn
            // 
            this.SendBtn.Location = new System.Drawing.Point(1288, 877);
            this.SendBtn.Margin = new System.Windows.Forms.Padding(2);
            this.SendBtn.Name = "SendBtn";
            this.SendBtn.Size = new System.Drawing.Size(136, 46);
            this.SendBtn.TabIndex = 6;
            this.SendBtn.Text = "Send";
            this.SendBtn.UseVisualStyleBackColor = true;
            // 
            // StatusBtn
            // 
            this.StatusBtn.Location = new System.Drawing.Point(1288, 927);
            this.StatusBtn.Margin = new System.Windows.Forms.Padding(2);
            this.StatusBtn.Name = "StatusBtn";
            this.StatusBtn.Size = new System.Drawing.Size(136, 46);
            this.StatusBtn.TabIndex = 7;
            this.StatusBtn.Text = "Status";
            this.StatusBtn.UseVisualStyleBackColor = true;
            // 
            // ExitBtn
            // 
            this.ExitBtn.Location = new System.Drawing.Point(1288, 977);
            this.ExitBtn.Margin = new System.Windows.Forms.Padding(2);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(136, 46);
            this.ExitBtn.TabIndex = 8;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(123, 877);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1160, 145);
            this.textBox1.TabIndex = 9;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.StatusBtn);
            this.Controls.Add(this.SendBtn);
            this.Controls.Add(this.Hitpoint);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ExperienceBar);
            this.Controls.Add(this.lvlLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(1680, 1050);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lvlLabel;
        public System.Windows.Forms.ProgressBar ExperienceBar;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.ProgressBar Hitpoint;
        private System.Windows.Forms.Button SendBtn;
        private System.Windows.Forms.Button StatusBtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.TextBox textBox1;
    }
}

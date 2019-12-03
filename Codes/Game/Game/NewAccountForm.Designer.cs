namespace Game
{
    partial class NewAccountForm
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
            this.titleLbl = new System.Windows.Forms.Label();
            this.usernameLbl = new System.Windows.Forms.Label();
            this.passwordLbl = new System.Windows.Forms.Label();
            this.usernameTxt = new System.Windows.Forms.TextBox();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.discriptionlbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.createLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.Location = new System.Drawing.Point(12, 9);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(544, 76);
            this.titleLbl.TabIndex = 0;
            this.titleLbl.Text = "Land Of Wizards";
            // 
            // usernameLbl
            // 
            this.usernameLbl.AutoSize = true;
            this.usernameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLbl.Location = new System.Drawing.Point(19, 110);
            this.usernameLbl.Name = "usernameLbl";
            this.usernameLbl.Size = new System.Drawing.Size(154, 31);
            this.usernameLbl.TabIndex = 1;
            this.usernameLbl.Text = "Username :";
            // 
            // passwordLbl
            // 
            this.passwordLbl.AutoSize = true;
            this.passwordLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLbl.Location = new System.Drawing.Point(19, 201);
            this.passwordLbl.Name = "passwordLbl";
            this.passwordLbl.Size = new System.Drawing.Size(149, 31);
            this.passwordLbl.TabIndex = 2;
            this.passwordLbl.Text = "Password :";
            // 
            // usernameTxt
            // 
            this.usernameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTxt.Location = new System.Drawing.Point(257, 107);
            this.usernameTxt.Name = "usernameTxt";
            this.usernameTxt.Size = new System.Drawing.Size(383, 38);
            this.usernameTxt.TabIndex = 3;
            // 
            // passwordTxt
            // 
            this.passwordTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTxt.Location = new System.Drawing.Point(257, 194);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.Size = new System.Drawing.Size(383, 38);
            this.passwordTxt.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 271);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(471, 46);
            this.label1.TabIndex = 5;
            this.label1.Text = "Choose your charecter :";
            // 
            // discriptionlbl
            // 
            this.discriptionlbl.AutoSize = true;
            this.discriptionlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discriptionlbl.Location = new System.Drawing.Point(400, 320);
            this.discriptionlbl.Name = "discriptionlbl";
            this.discriptionlbl.Size = new System.Drawing.Size(142, 31);
            this.discriptionlbl.TabIndex = 6;
            this.discriptionlbl.Text = "Discription";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(25, 347);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(370, 186);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Youssef",
            "Moataz",
            "Hoda"});
            this.comboBox1.Location = new System.Drawing.Point(25, 320);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(370, 21);
            this.comboBox1.TabIndex = 9;
            // 
            // createLbl
            // 
            this.createLbl.AutoSize = true;
            this.createLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createLbl.Location = new System.Drawing.Point(676, 521);
            this.createLbl.Name = "createLbl";
            this.createLbl.Size = new System.Drawing.Size(96, 31);
            this.createLbl.TabIndex = 10;
            this.createLbl.Text = "Create";
            this.createLbl.Click += new System.EventHandler(this.createLbl_Click);
            // 
            // NewAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.createLbl);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.discriptionlbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passwordTxt);
            this.Controls.Add(this.usernameTxt);
            this.Controls.Add(this.passwordLbl);
            this.Controls.Add(this.usernameLbl);
            this.Controls.Add(this.titleLbl);
            this.Name = "NewAccountForm";
            this.Text = "NewAccountForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Label usernameLbl;
        private System.Windows.Forms.Label passwordLbl;
        private System.Windows.Forms.TextBox usernameTxt;
        private System.Windows.Forms.TextBox passwordTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label discriptionlbl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label createLbl;
    }
}
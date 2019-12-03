namespace Game
{
    partial class DeleteForm
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
            this.passwordTxtBox = new System.Windows.Forms.TextBox();
            this.passwordLbl = new System.Windows.Forms.Label();
            this.usernameTxtBox = new System.Windows.Forms.TextBox();
            this.usernameLbl = new System.Windows.Forms.Label();
            this.deleteLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.BackColor = System.Drawing.Color.Transparent;
            this.titleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.Location = new System.Drawing.Point(12, 9);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(626, 91);
            this.titleLbl.TabIndex = 1;
            this.titleLbl.Text = "Land of Wizards";
            this.titleLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // passwordTxtBox
            // 
            this.passwordTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTxtBox.Location = new System.Drawing.Point(296, 296);
            this.passwordTxtBox.Name = "passwordTxtBox";
            this.passwordTxtBox.Size = new System.Drawing.Size(393, 38);
            this.passwordTxtBox.TabIndex = 8;
            // 
            // passwordLbl
            // 
            this.passwordLbl.AutoSize = true;
            this.passwordLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLbl.Location = new System.Drawing.Point(94, 299);
            this.passwordLbl.Name = "passwordLbl";
            this.passwordLbl.Size = new System.Drawing.Size(149, 31);
            this.passwordLbl.TabIndex = 7;
            this.passwordLbl.Text = "Password :";
            // 
            // usernameTxtBox
            // 
            this.usernameTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTxtBox.Location = new System.Drawing.Point(296, 223);
            this.usernameTxtBox.Name = "usernameTxtBox";
            this.usernameTxtBox.Size = new System.Drawing.Size(393, 38);
            this.usernameTxtBox.TabIndex = 6;
            // 
            // usernameLbl
            // 
            this.usernameLbl.AutoSize = true;
            this.usernameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLbl.Location = new System.Drawing.Point(94, 226);
            this.usernameLbl.Name = "usernameLbl";
            this.usernameLbl.Size = new System.Drawing.Size(166, 31);
            this.usernameLbl.TabIndex = 5;
            this.usernameLbl.Text = "User Name :";
            this.usernameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // deleteLbl
            // 
            this.deleteLbl.AutoSize = true;
            this.deleteLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteLbl.Location = new System.Drawing.Point(588, 489);
            this.deleteLbl.Name = "deleteLbl";
            this.deleteLbl.Size = new System.Drawing.Size(184, 63);
            this.deleteLbl.TabIndex = 9;
            this.deleteLbl.Text = "Delete";
            this.deleteLbl.Click += new System.EventHandler(this.deleteLbl_Click);
            // 
            // DeleteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.deleteLbl);
            this.Controls.Add(this.passwordTxtBox);
            this.Controls.Add(this.passwordLbl);
            this.Controls.Add(this.usernameTxtBox);
            this.Controls.Add(this.usernameLbl);
            this.Controls.Add(this.titleLbl);
            this.Name = "DeleteForm";
            this.Text = "DeleteForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.TextBox passwordTxtBox;
        private System.Windows.Forms.Label passwordLbl;
        private System.Windows.Forms.TextBox usernameTxtBox;
        private System.Windows.Forms.Label usernameLbl;
        private System.Windows.Forms.Label deleteLbl;
    }
}
using System;
using System.Windows.Forms;
using System.Net.Sockets;
using System.IO;
using otherplayer;
using System.Runtime.Serialization.Formatters.Binary;
using myplayer;

namespace Game
{
    class StartForm : Form
    {
        public OtherPlayer me;
        public string username;
        private string response;

        //FORMS
        public GameForm Game;
        public NewAccountForm NewAccountForm;
        public DeleteForm deleteForm;

        //GUI
        public TextBox serveripTxtBox;
        private Label usernameLbl;
        private TextBox usernameTxtBox;
        private Label passwordLbl;
        private TextBox passwordTxtBox;
        private Label serveripLbl;
        private Label settingsLbl;
        private Label exitLbl;
        private Label newaccountLbl;
        private Label connectLbl;
        private Label errorLbl;
        private Label titleLbl;
        private Label deleteLbl;

        //NETWORKS
        public StreamWriter streamWriter;
        private TcpClient client;
        private NetworkStream networkStream;
        private BinaryFormatter bfTCP;
        private StreamReader streamReader;

        public StartForm()
        {
            //GUI
            InitializeComponent();
            //NETWORK
            bfTCP = new BinaryFormatter();
        }

        private void InitializeComponent()
        {
            this.titleLbl = new System.Windows.Forms.Label();
            this.usernameLbl = new System.Windows.Forms.Label();
            this.usernameTxtBox = new System.Windows.Forms.TextBox();
            this.passwordLbl = new System.Windows.Forms.Label();
            this.passwordTxtBox = new System.Windows.Forms.TextBox();
            this.serveripLbl = new System.Windows.Forms.Label();
            this.serveripTxtBox = new System.Windows.Forms.TextBox();
            this.settingsLbl = new System.Windows.Forms.Label();
            this.exitLbl = new System.Windows.Forms.Label();
            this.newaccountLbl = new System.Windows.Forms.Label();
            this.connectLbl = new System.Windows.Forms.Label();
            this.errorLbl = new System.Windows.Forms.Label();
            this.deleteLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.BackColor = System.Drawing.Color.Transparent;
            this.titleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.Location = new System.Drawing.Point(12, 3);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(529, 76);
            this.titleLbl.TabIndex = 0;
            this.titleLbl.Text = "Land of Wizards";
            this.titleLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // usernameLbl
            // 
            this.usernameLbl.AutoSize = true;
            this.usernameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLbl.Location = new System.Drawing.Point(26, 93);
            this.usernameLbl.Name = "usernameLbl";
            this.usernameLbl.Size = new System.Drawing.Size(166, 31);
            this.usernameLbl.TabIndex = 1;
            this.usernameLbl.Text = "User Name :";
            this.usernameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // usernameTxtBox
            // 
            this.usernameTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTxtBox.Location = new System.Drawing.Point(228, 90);
            this.usernameTxtBox.Name = "usernameTxtBox";
            this.usernameTxtBox.Size = new System.Drawing.Size(393, 38);
            this.usernameTxtBox.TabIndex = 2;
            // 
            // passwordLbl
            // 
            this.passwordLbl.AutoSize = true;
            this.passwordLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLbl.Location = new System.Drawing.Point(26, 169);
            this.passwordLbl.Name = "passwordLbl";
            this.passwordLbl.Size = new System.Drawing.Size(149, 31);
            this.passwordLbl.TabIndex = 3;
            this.passwordLbl.Text = "Password :";
            // 
            // passwordTxtBox
            // 
            this.passwordTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTxtBox.Location = new System.Drawing.Point(228, 166);
            this.passwordTxtBox.Name = "passwordTxtBox";
            this.passwordTxtBox.Size = new System.Drawing.Size(393, 38);
            this.passwordTxtBox.TabIndex = 4;
            // 
            // serveripLbl
            // 
            this.serveripLbl.AutoSize = true;
            this.serveripLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serveripLbl.Location = new System.Drawing.Point(26, 247);
            this.serveripLbl.Name = "serveripLbl";
            this.serveripLbl.Size = new System.Drawing.Size(142, 31);
            this.serveripLbl.TabIndex = 5;
            this.serveripLbl.Text = "Server IP :";
            // 
            // serveripTxtBox
            // 
            this.serveripTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serveripTxtBox.Location = new System.Drawing.Point(228, 244);
            this.serveripTxtBox.Name = "serveripTxtBox";
            this.serveripTxtBox.Size = new System.Drawing.Size(393, 38);
            this.serveripTxtBox.TabIndex = 6;
            // 
            // settingsLbl
            // 
            this.settingsLbl.AutoSize = true;
            this.settingsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsLbl.Location = new System.Drawing.Point(559, 453);
            this.settingsLbl.Name = "settingsLbl";
            this.settingsLbl.Size = new System.Drawing.Size(164, 46);
            this.settingsLbl.TabIndex = 7;
            this.settingsLbl.Text = "Settings";
            // 
            // exitLbl
            // 
            this.exitLbl.AutoSize = true;
            this.exitLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitLbl.Location = new System.Drawing.Point(592, 499);
            this.exitLbl.Name = "exitLbl";
            this.exitLbl.Size = new System.Drawing.Size(88, 46);
            this.exitLbl.TabIndex = 8;
            this.exitLbl.Text = "Exit";
            this.exitLbl.Click += new System.EventHandler(this.exitLbl_Click);
            // 
            // newaccountLbl
            // 
            this.newaccountLbl.AutoSize = true;
            this.newaccountLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newaccountLbl.Location = new System.Drawing.Point(509, 407);
            this.newaccountLbl.Name = "newaccountLbl";
            this.newaccountLbl.Size = new System.Drawing.Size(258, 46);
            this.newaccountLbl.TabIndex = 9;
            this.newaccountLbl.Text = "New Account";
            this.newaccountLbl.Click += new System.EventHandler(this.newaccountLbl_Click);
            // 
            // connectLbl
            // 
            this.connectLbl.AutoSize = true;
            this.connectLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectLbl.Location = new System.Drawing.Point(21, 307);
            this.connectLbl.Name = "connectLbl";
            this.connectLbl.Size = new System.Drawing.Size(228, 63);
            this.connectLbl.TabIndex = 10;
            this.connectLbl.Text = "Connect";
            this.connectLbl.Click += new System.EventHandler(this.connectLbl_Click);
            // 
            // errorLbl
            // 
            this.errorLbl.AutoSize = true;
            this.errorLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLbl.ForeColor = System.Drawing.Color.Red;
            this.errorLbl.Location = new System.Drawing.Point(273, 330);
            this.errorLbl.Name = "errorLbl";
            this.errorLbl.Size = new System.Drawing.Size(0, 31);
            this.errorLbl.TabIndex = 11;
            // 
            // deleteLbl
            // 
            this.deleteLbl.AutoSize = true;
            this.deleteLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteLbl.Location = new System.Drawing.Point(495, 545);
            this.deleteLbl.Name = "deleteLbl";
            this.deleteLbl.Size = new System.Drawing.Size(293, 46);
            this.deleteLbl.TabIndex = 12;
            this.deleteLbl.Text = "Delete Account";
            this.deleteLbl.Click += new System.EventHandler(this.deleteLbl_Click);
            // 
            // StartForm
            // 
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.deleteLbl);
            this.Controls.Add(this.errorLbl);
            this.Controls.Add(this.connectLbl);
            this.Controls.Add(this.newaccountLbl);
            this.Controls.Add(this.exitLbl);
            this.Controls.Add(this.settingsLbl);
            this.Controls.Add(this.serveripTxtBox);
            this.Controls.Add(this.serveripLbl);
            this.Controls.Add(this.passwordTxtBox);
            this.Controls.Add(this.passwordLbl);
            this.Controls.Add(this.usernameTxtBox);
            this.Controls.Add(this.usernameLbl);
            this.Controls.Add(this.titleLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StartForm";
            this.Text = "Game v.1.0.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void connectLbl_Click(object sender, EventArgs e)
        {
            client = new TcpClient(serveripTxtBox.Text, 8080);
            streamReader = new StreamReader(client.GetStream());
            streamWriter = new StreamWriter(client.GetStream());
            networkStream = client.GetStream();

            streamWriter.WriteLine(1); streamWriter.Flush();
            streamWriter.WriteLine(usernameTxtBox.Text); streamWriter.Flush();
            streamWriter.WriteLine(passwordTxtBox.Text); streamWriter.Flush();

            response = streamReader.ReadLine();

            if (response.Equals("true"))
            {
                username = usernameTxtBox.Text;

                me = (OtherPlayer)bfTCP.Deserialize(networkStream);
                MyPlayer.worldX = me.worldX;
                MyPlayer.worldY = me.worldY;
                MyPlayer.moveX = me.moveX;
                MyPlayer.moveY = me.moveY;
                MyPlayer.experience = me.experience;
                MyPlayer.accountType = me.accountType;

                Game = new GameForm();
                Game.Show();
                Luncher.StartGame.Hide();
            }
            else
            {
                errorLbl.Text = response;
                streamReader.Close();
                streamWriter.Close();
                networkStream.Close();
                client.Close();
            }
        }

        private void newaccountLbl_Click(object sender, EventArgs e)
        {
            if (serveripTxtBox.Text.Equals(""))
            {
                errorLbl.Text = "Fill server ip first please";
            }
            else
            {
                NewAccountForm = new NewAccountForm();
                NewAccountForm.Show();
                this.Hide();
            }
        }

        private void deleteLbl_Click(object sender, EventArgs e)
        {
            if (serveripTxtBox.Text.Equals(""))
            {
                errorLbl.Text = "Fill server ip first please";
            }
            else
            {
                deleteForm = new DeleteForm();
                deleteForm.Show();
                this.Hide();
            }
        }

        private void exitLbl_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

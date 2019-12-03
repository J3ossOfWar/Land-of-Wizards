using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class DeleteForm : Form
    {
        TcpClient client;
        StreamReader streamReader;
        StreamWriter streamWriter;

        public DeleteForm()
        {
            InitializeComponent();
        }

        private void deleteLbl_Click(object sender, EventArgs e)
        {
            client = new TcpClient(Luncher.StartGame.serveripTxtBox.Text, 8080);
            streamReader = new StreamReader(client.GetStream());
            streamWriter = new StreamWriter(client.GetStream());

            streamWriter.WriteLine("3"); streamWriter.Flush();
            streamWriter.WriteLine(usernameTxtBox.Text); streamWriter.Flush();
            streamWriter.WriteLine(passwordTxtBox.Text); streamWriter.Flush();

            client.Close();
            streamReader.Close();
            streamWriter.Close();
            Luncher.StartGame.Show();
            this.Hide();
        }
    }
}

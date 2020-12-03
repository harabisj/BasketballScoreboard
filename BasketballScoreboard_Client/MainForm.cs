using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleTcp;

namespace BasketballScoreboard_Client
{
    public partial class MainForm : Form
    {
        private SimpleTcpClient client;

        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            client.Send("Test");
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            client = new SimpleTcpClient("127.0.0.1", 23190);
            client.Connect();
        }
    }
}

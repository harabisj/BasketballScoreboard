﻿using System;
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
        private ConnectionsManager connectionsManager;

        public MainForm(ConnectionsManager connectionsManager)
        {
            InitializeComponent();

            this.connectionsManager = connectionsManager;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connectionsManager.SendData("cscs");
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ;
        }
    }
}

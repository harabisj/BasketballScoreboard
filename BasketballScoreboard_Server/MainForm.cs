using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasketballScoreboard_Server
{
    public partial class MainForm : Form
    {
        public String ip;

        public MainForm(string ip)
        {
            InitializeComponent();

            this.ip = ip;
        }
    }
}

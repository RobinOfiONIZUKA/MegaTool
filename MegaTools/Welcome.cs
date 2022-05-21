using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DiscordRPC;
using Newtonsoft.Json;

namespace MegaTools
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void darkDockPanel1_Load(object sender, EventArgs e)
        {
            label2.Text = File.ReadAllText(Application.UserAppDataPath + @"Name.megatool");
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {

        }

        private void Welcome_Load(object sender, EventArgs e)
        {

        }
    }
}

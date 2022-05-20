
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DiscordRPC;
using Newtonsoft;

namespace MegaTools
{
    public partial class FortniteServer : Form
    {
        public FortniteServer()
        {
            InitializeComponent();
        }


    private void guna2Button1_Click(object sender, EventArgs e)
        {
            Configuracion.Server.InstallDll();
            Configuracion.Server.InstallSv();
            Configuracion.Server.StartFortnite();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaTools
{
    public partial class Logname : MetroSuite.MetroForm
    {
        public Logname()
        {
            InitializeComponent();
        }

        private void Logname_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox24_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2GradientTileButton1_Click(object sender, EventArgs e)
        {
            var name = guna2TextBox1.Text;
            MessageBox.Show("Welcome to MegaTools!");
            File.WriteAllText(Application.UserAppDataPath + @"Name.megatool", name);
            Form1 form = new Form1();
            form.Show();
            base.Hide();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaTools
{
    public partial class Roblox : Form
    {
        public Roblox()
        {
            InitializeComponent();
        }
        private Logic logic = new Logic();
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.logic.Injectar();
            this.Validate();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.logic.Fire();  
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            this.logic.Sparkles();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            string text = this.richTextBox1.Text;
            this.logic.RunLuaScript(text);
            this.richTextBox1.Text = string.Empty;
        }
    }
}

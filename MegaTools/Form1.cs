
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
using DiscordRPC;

namespace MegaTools
{
    public partial class Form1 : MetroSuite.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
            AbrirFormEnPanel(new Welcome());
        }

        Logname nombre;
        private void AbrirFormEnPanel(object formbitch)
        {
            if (this.guna2Panel2.Controls.Count > 0)
                this.guna2Panel2.Controls.RemoveAt(0);
            Form fh = formbitch as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.guna2Panel2.Controls.Add(fh);
            this.guna2Panel2.Tag = fh;
            fh.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label2.Text = File.ReadAllText(Application.UserAppDataPath + @"Name.megatool");
            RichPresenceClient.Start();

        }


        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2GradientTileButton4_Click(object sender, EventArgs e)
        {
            RichPresenceClient.UpdatePresence("Made by @lolperoi123", $"In the roblox section");
            AbrirFormEnPanel(new Roblox());
            guna2GradientTileButton4.BorderRadius = 10;
            guna2GradientTileButton1.BorderRadius = 21;
            guna2GradientTileButton2.BorderRadius = 21;
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (guna2ComboBox1.SelectedIndex == 0)
            {
                guna2Panel2.FillColor = Color.FromArgb(64, 64, 64);
                guna2Panel1.FillColor = Color.FromArgb(64, 64, 64);
                label1.ForeColor = Color.FromArgb(255, 255, 255);
                label2.ForeColor = Color.FromArgb(255, 255, 255);
                sideBar.FillColor = Color.FromArgb(63, 63, 63);
                sideBar.FillColor2 = Color.FromArgb(54, 54, 54);
                pictureBox22.BackColor = Color.FromArgb(64, 64, 64);
                pictureBox24.BackColor = Color.FromArgb(64, 64, 64);
            }


            if (guna2ComboBox1.SelectedIndex == 1)
            {
                guna2Panel2.FillColor = Color.FromArgb(215, 215, 215);
                guna2Panel1.FillColor = Color.FromArgb(215, 215, 215);
                label1.ForeColor = Color.FromArgb(000, 000, 000);
                label2.ForeColor = Color.FromArgb(000, 000, 000);
                sideBar.FillColor = Color.FromArgb(185, 185, 185);
                sideBar.FillColor2 = Color.FromArgb(189, 189, 189);
                pictureBox22.BackColor = Color.FromArgb(215, 215, 215);
                pictureBox24.BackColor = Color.FromArgb(215, 215, 215);
            }

            if (guna2ComboBox1.SelectedIndex == 2)
            {
                guna2Panel2.FillColor = Color.FromArgb(255, 000, 000);
                guna2Panel1.FillColor = Color.FromArgb(255, 000, 000);
                label1.ForeColor = Color.FromArgb(255, 255, 255);
                label2.ForeColor = Color.FromArgb(255, 255, 255);
                sideBar.FillColor = Color.FromArgb(255, 000, 000);
                sideBar.FillColor2 = Color.FromArgb(255, 000, 000);
                pictureBox22.BackColor = Color.FromArgb(255, 000, 000);
                pictureBox24.BackColor = Color.FromArgb(255, 000, 000);
            }

            if (guna2ComboBox1.SelectedIndex == 3)
            {
                guna2Panel1.FillColor = Color.FromArgb(127, 0, 255);
                guna2Panel2.FillColor = Color.FromArgb(127, 0, 255);
                label1.ForeColor = Color.FromArgb(255, 255, 255);
                label2.ForeColor = Color.FromArgb(255, 255, 255);
                sideBar.FillColor = Color.FromArgb(127, 0, 255);
                sideBar.FillColor2 = Color.FromArgb(127, 0, 255);
                pictureBox22.BackColor = Color.FromArgb(127, 0, 255);
                pictureBox24.BackColor = Color.FromArgb(127, 0, 255);
            }
        }


        private void guna2GradientTileButton1_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Welcome());
            guna2GradientTileButton1.BorderRadius = 10;
            guna2GradientTileButton3.BorderRadius = 21;
            guna2GradientTileButton2.BorderRadius = 21;
            guna2GradientTileButton4.BorderRadius = 21;
        }

        private void guna2GradientTileButton2_Click(object sender, EventArgs e)
        {
            RichPresenceClient.UpdatePresence("Made by @lolperoi123", $"In the fortnite section");
            AbrirFormEnPanel(new FortniteServer());
            guna2GradientTileButton2.BorderRadius = 10;
            guna2GradientTileButton1.BorderRadius = 21;
            guna2GradientTileButton3.BorderRadius = 21;
            guna2GradientTileButton4.BorderRadius = 21;
        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            File.Delete(Application.UserAppDataPath + @"Name.megatool");
            nombre = new Logname();
            nombre.Show();
            this.Hide();
        }

        private void pictureBox24_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void guna2GradientTileButton3_Click(object sender, EventArgs e)
        {
            RichPresenceClient.UpdatePresence("Made by @lolperoi123", $"In the fortnite exchanger section");
            AbrirFormEnPanel(new Exchanger());
            guna2GradientTileButton3.BorderRadius = 10;
            guna2GradientTileButton1.BorderRadius = 21;
            guna2GradientTileButton4.BorderRadius = 21;
            guna2GradientTileButton2.BorderRadius = 21;
        }
    }
}

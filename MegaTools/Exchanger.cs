using MegaTools.Fortnite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaTools
{
    public partial class Exchanger : Form
    {
        public Exchanger()
        {
            InitializeComponent();
        }

        private void Exchanger_Load(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            var FortniteID = guna2TextBox1.Text;
            var ExchangeCode = guna2TextBox2.Text;
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.CreateNoWindow = true;
            startInfo.UseShellExecute = true;
            startInfo.WorkingDirectory = MegaTools.Fortnite.FortniteUtil.FortniteUtils.BinariesPath;
            startInfo.FileName = "FortniteLauncher.exe";
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.Arguments = $"-AUTH_LOGIN=unused -AUTH_PASSWORD={ExchangeCode} -AUTH_TYPE=exchangecode -epicapp=Fortnite -epicenv=Prod -EpicPortal -epicuserid={FortniteID} -log";

            try
            {
                using (Process exeProcess = Process.Start(startInfo))
                {
                    exeProcess.WaitForExit();
                }
            }
            catch
            {

            }
        }
    }
}

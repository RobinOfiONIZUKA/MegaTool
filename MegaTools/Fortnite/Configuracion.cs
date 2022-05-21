using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Configuracion
{
    class Server
    {
        public static string GetFNVer()
        {
            var FNVer = "";
            var EpicInstalled = File.ReadAllText(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), "Epic\\UnrealEngineLauncher\\LauncherInstalled.dat"));
            dynamic Json = JsonConvert.DeserializeObject(EpicInstalled);

            foreach (var installion in Json.InstallationList)
            {
                if (installion.AppName == "Fortnite")
                {
                    FNVer = installion.AppVersion.ToString().Split('-')[1];
                }
            }

            return FNVer;
        }

        public static string GetFNPath()
        {
            var FNPath = File.ReadAllText(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), "Epic\\UnrealEngineLauncher\\LauncherInstalled.dat"));
            dynamic Json = JsonConvert.DeserializeObject(FNPath);
            foreach (var installion in Json.InstallationList)
            {
                if (installion.AppName == "Fortnite")
                {
                    FNPath = installion.InstallLocation.ToString(); // FortniteGame
                }
            }


            return FNPath;
        }

        public static void StartFortnite()
        {
            Process.Start("com.epicgames.launcher://apps/Fortnite?action=launch&silent=true");
        }

        public static void KillFortnite()
        {
            var Fortnite = ("Fortnitelauncher");
            var AC = ("FortniteClient-Win64-Shipping_EAC");
            var EpicGames = ("EpicGamesLauncher");
            DialogResult r = MessageBox.Show("¿Sure you want to close fortnite?", "Launcher", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                int i;
                Process[] processesByName = Process.GetProcessesByName($"{Fortnite}");
                for (i = 0; i < (int)processesByName.Length; i++)
                {
                    processesByName[i].Kill();
                }
                processesByName = Process.GetProcessesByName($"{AC}");
                for (i = 0; i < (int)processesByName.Length; i++)
                {
                    processesByName[i].Kill();
                }
                processesByName = Process.GetProcessesByName($"{EpicGames}");
                for (i = 0; i < (int)processesByName.Length; i++)
                {
                    processesByName[i].Kill();
                }
            }
        }


        public static async Task InstallDll()
        {
            var url = ("https://cdn.discordapp.com/attachments/940826339877998633/977329620938547200/K1R4FN.dll");
            var DLL = ("K1R4FN");
            string[] FNStuff = { "FortniteClient-Win64-Shipping_EAC.exe", "FortniteClient-Win64-Shipping_BE.exe", "FortniteLauncher.exe" };

            foreach (string procname in FNStuff)
            {
                var process = Process.GetProcessesByName(procname);
                foreach (var proc in process)
                {
                    proc.Kill();
                }
            }
            string TempPath = Path.GetTempPath();
            var Path1 = "";
            var version = "1";

            var path1 = File.ReadAllText(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), "Epic\\UnrealEngineLauncher\\LauncherInstalled.dat"));
            dynamic Json = JsonConvert.DeserializeObject(path1);

            foreach (var installion in Json.InstallationList)
            {
                if (installion.AppName == "Fortnite")
                {
                    Path1 = installion.InstallLocation.ToString() + "\\FortniteGame\\Binaries\\Win64";
                    version = installion.AppVersion.ToString().Split('-')[1];
                }
            }
            if (!File.Exists(Path1 + $"\\{DLL}.old")) { }
            else
            {
                File.Move(Path1 + $"\\{DLL}.dll", Path1 + $"\\{DLL}.dll.old");
            }


            WebClient webClient = new WebClient();

            await webClient.DownloadFileTaskAsync($"{url}", TempPath + $"\\{DLL}.dll");



            if (!File.Exists(Path1 + $"\\{DLL}.dll"))
            {
                File.Move(TempPath + $"\\{DLL}.dll", Path1 + $"\\{DLL}.dll");
            }
            else
            {
                File.Delete(Path1 + $"\\{DLL}.dll");
                File.Move(TempPath + $"\\{DLL}.dll", Path1 + $"\\{DLL}.dll");
            }

        }

        public static void Verify()
        {
            var Proc = new ProcessStartInfo();
            Proc.CreateNoWindow = true;
            Proc.FileName = "cmd.exe";
            Proc.Arguments = "/C start com.epicgames.launcher://apps/Fortnite?action=verify";
            Process.Start(Proc);
        }

        public static async Task InstallSv()
        {
            var url1 = ("https://cdn.discordapp.com/attachments/940826339877998633/977329621429276672/FortniteClient-Win64-Shipping_EAC.exe");
            var url2 = ("https://cdn.discordapp.com/attachments/940826339877998633/977329621177630820/FortniteClient-Win64-Shipping_BE.exe");

            string Temp = Path.GetTempPath();


            string[] FNStuff = { "FortniteClient-Win64-Shipping_EAC.exe", "FortniteClient-Win64-Shipping_BE.exe", "FortniteLauncher.exe" };

            foreach (string procname in FNStuff)
            {
                var process = Process.GetProcessesByName(procname);
                foreach (var proc in process)
                {
                    proc.Kill();
                }
            }
            string TempPath = Path.GetTempPath();
            var Path1 = "";
            var version = "1";

            var path1 = File.ReadAllText(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), "Epic\\UnrealEngineLauncher\\LauncherInstalled.dat"));
            dynamic Json = JsonConvert.DeserializeObject(path1);

            foreach (var installion in Json.InstallationList)
            {
                if (installion.AppName == "Fortnite")
                {
                    Path1 = installion.InstallLocation.ToString() + "\\FortniteGame\\Binaries\\Win64";
                    version = installion.AppVersion.ToString().Split('-')[1];
                }
            }


            if (!File.Exists(Path1 + "\\FortniteClient-Win64-Shipping_EAC.old")) { }
            else
            {
                File.Move(Path1 + "\\FortniteClient-Win64-Shipping_EAC.exe", Path1 + "\\FortniteClient-Win64-Shipping_EAC.exe.old");
            }

            if (!File.Exists(Path1 + "\\FortniteClient-Win64-Shipping_BE.old")) { }
            else
            {
                File.Move(Path1 + "\\FortniteClient-Win64-Shipping_BE.exe", Path1 + "\\FortniteClient-Win64-Shipping_BE.exe.old");
            }

            WebClient webClient = new WebClient();

            await webClient.DownloadFileTaskAsync($"{url1}", TempPath + "\\FortniteClient-Win64-Shipping_EAC.exe");
            await webClient.DownloadFileTaskAsync($"{url2}", TempPath + "\\FortniteClient-Win64-Shipping_BE.exe");



            if (!File.Exists(Path1 + "\\FortniteClient-Win64-Shipping_EAC.exe"))
            {
                File.Move(TempPath + "\\FortniteClient-Win64-Shipping_EAC.exe", Path1 + "\\FortniteClient-Win64-Shipping_EAC.exe");
            }
            else
            {
                File.Delete(Path1 + "\\FortniteClient-Win64-Shipping_EAC.exe");
                File.Move(TempPath + "\\FortniteClient-Win64-Shipping_EAC.exe", Path1 + "\\FortniteClient-Win64-Shipping_EAC.exe");
            }

            if (!File.Exists(Path1 + "\\FortniteClient-Win64-Shipping_BE.exe"))
            {
                File.Move(TempPath + "\\FortniteClient-Win64-Shipping_BE.exe", Path1 + "\\FortniteClient-Win64-Shipping_BE.exe");
            }
            else
            {
                File.Delete(Path1 + "\\FortniteClient-Win64-Shipping_BE.exe");
                File.Move(TempPath + "\\FortniteClient-Win64-Shipping_BE.exe", Path1 + "\\FortniteClient-Win64-Shipping_BE.exe");
            }


        }
    }
}
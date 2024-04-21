using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using CloudLauncher.Properties;
using CloudLauncher.files;

namespace CloudLauncher {
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.EmailBox.Text = Settings.Default.Email;
            this.PasswordBox.Text = Settings.Default.Password;
            this.PathBox.Text = Settings.Default.GamePath;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // gets fltoken and shit
            // not atm
        }

        public static Process StartProcess(string path, bool shouldFreeze, string extraArgs = "")
        {
            Process process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = path,
                    Arguments = $"-epicapp=Fortnite -epicenv=Prod -epiclocale=en-us -epicportal -noeac -fromfl=be -fltoken=5dh74c635862g575778132fb -skippatchcheck" + extraArgs
                }
            };
            process.Start();
            if (shouldFreeze)
            {
                foreach (object obj in process.Threads)
                {
                    ProcessThread thread = (ProcessThread)obj;
                    Win32.SuspendThread(Win32.OpenThread(2, false, thread.Id));
                }
            }
            return process;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var clientPath = Path.Combine(PathBox.Text, $"FortniteGame\\Binaries\\Win64\\{Program.client}.exe");

            if (!File.Exists(clientPath))
            {
                MessageBox.Show($"\"{Program.client}\" was not found, please make sure it exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var nativePath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), Program.dll);

            if (!File.Exists(nativePath))
            {
                MessageBox.Show($"\"{Program.dll}\" was not found, please make sure it exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Process process = StartProcess(PathBox.Text + $"\\FortniteGame\\Binaries\\Win64\\{Program.launcher}", true, "-NOSSLPINNING");
            Process process2 = StartProcess(PathBox.Text + $"\\FortniteGame\\Binaries\\Win64\\{Program.client}_BE.exe", true, "");
            Process process3 = StartProcess(PathBox.Text + $"\\FortniteGame\\Binaries\\Win64\\{Program.client}.exe", false, $"-AUTH_TYPE=epic -AUTH_LOGIN={EmailBox.Text} -AUTH_PASSWORD={PasswordBox.Text}");
            process3.WaitForInputIdle();
            base.Hide();
            inject.InjectDll(process3.Id, Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), Program.dll));
            process3.WaitForExit();
            base.Show();
        }

        private void EmailBox_TextChanged(object sender, EventArgs e) {

        }
    }
}

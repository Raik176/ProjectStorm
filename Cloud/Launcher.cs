using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using CloudLauncher.Properties;
using CloudLauncher.Files;
using System.Runtime.InteropServices;

namespace CloudLauncher {
    public partial class Launcher : Form {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        public Launcher() {
            InitializeComponent();
            LoadSettings();

            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void LoadSettings() {
            EmailBox.Text = Settings.Default.Email;
            PasswordBox.Text = Settings.Default.Password;
            GameDirectoryBox.Text = Settings.Default.GamePath;
        }

        private void LaunchGame_Click(object sender, EventArgs e) {
            string clientPath = Path.Combine(GameDirectoryBox.Text, $"FortniteGame\\Binaries\\Win64\\{Program.client}.exe");
            string launcherPath = $"{GameDirectoryBox.Text}\\FortniteGame\\Binaries\\Win64\\{Program.launcher}";
            string nativePath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), Program.dll);

            if (!File.Exists(clientPath)) {
                ShowError($"\"{Program.client}\" was not found, please make sure it exists.");
                return;
            }

            if (!File.Exists(nativePath)) {
                ShowError($"\"{Program.dll}\" was not found, please make sure it exists.");
                return;
            }
            if (File.Exists(launcherPath)) StartProcess(launcherPath, true, "-NOSSLPINNING");
            Process gameProcess = StartProcess(clientPath, false, $"-AUTH_TYPE=epic -AUTH_LOGIN={EmailBox.Text} -AUTH_PASSWORD={PasswordBox.Text}");
            StartProcess($"{GameDirectoryBox.Text}\\FortniteGame\\Binaries\\Win64\\{Program.client}_BE.exe", true, "");

            gameProcess.WaitForInputIdle();
            Hide();

            Inject.InjectDll(gameProcess.Id, nativePath);

            gameProcess.WaitForExit();
            Show();
        }

        private void ShowError(string message) {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private Process StartProcess(string path, bool shouldFreeze, string extraArgs = "") {
            Process process = new Process {
                StartInfo = new ProcessStartInfo {
                    FileName = path,
                    Arguments = $"-epicapp=Fortnite -epicenv=Prod -epiclocale=en-us -epicportal -noeac -fromfl=be -fltoken=5dh74c635862g575778132fb -skippatchcheck {extraArgs}"
                }
            };
            process.Start();
            if (shouldFreeze) {
                foreach (ProcessThread thread in process.Threads) {
                    Win32.SuspendThread(Win32.OpenThread(2, false, thread.Id));
                }
            }
            return process;
        }

        private void Launcher_Load(object sender, EventArgs e) {
            MOTDInfoBrowser.DocumentText = Markdig.Markdown.ToHtml(Program.HTTPGet(Program.server + "/launcher/motd"));
        }

        private void PasswordBox_TextChanged(object sender, EventArgs e) {

        }

        private void GameDirectoryPicker_HelpRequest(object sender, EventArgs e) {

        }

        private void ShowFolderDialog_Click(object sender, EventArgs e) {
            if (GameDirectoryPicker.ShowDialog() == DialogResult.OK) {
                GameDirectoryBox.Text = GameDirectoryPicker.SelectedPath;
            }
        }

        private void CloseApp_Click(object sender, EventArgs e) {
            Environment.Exit(0);
        }

        private void MOTDInfoBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e) {
            // Disable context menu
            MOTDInfoBrowser.IsWebBrowserContextMenuEnabled = false;

            MOTDInfoBrowser.PreviewKeyDown += (s, k) => k.IsInputKey = true;
            MOTDInfoBrowser.Document.MouseDown += (s, me) => me.ReturnValue = false;
        }
    }
}
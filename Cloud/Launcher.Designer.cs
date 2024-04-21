
namespace CloudLauncher {
    partial class Launcher
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button2 = new System.Windows.Forms.Button();
            this.EmailBox = new System.Windows.Forms.TextBox();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.GameDirectoryBox = new System.Windows.Forms.TextBox();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.GameDirectoryPicker = new System.Windows.Forms.FolderBrowserDialog();
            this.GameDirectoryLabel = new System.Windows.Forms.Label();
            this.CloseApp = new System.Windows.Forms.Button();
            this.MOTDInfoPanel = new System.Windows.Forms.Panel();
            this.MOTDInfoBrowser = new System.Windows.Forms.WebBrowser();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.MOTDInfoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(49, 198);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(245, 51);
            this.button2.TabIndex = 1;
            this.button2.Text = "Launch";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.LaunchGame_Click);
            // 
            // EmailBox
            // 
            this.EmailBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            this.EmailBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EmailBox.Font = new System.Drawing.Font("Consolas", 10F);
            this.EmailBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.EmailBox.Location = new System.Drawing.Point(165, 107);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Size = new System.Drawing.Size(175, 16);
            this.EmailBox.TabIndex = 2;
            // 
            // PasswordBox
            // 
            this.PasswordBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            this.PasswordBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PasswordBox.Font = new System.Drawing.Font("Consolas", 10F);
            this.PasswordBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.PasswordBox.Location = new System.Drawing.Point(165, 134);
            this.PasswordBox.MaxLength = 16;
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Size = new System.Drawing.Size(175, 16);
            this.PasswordBox.TabIndex = 3;
            this.PasswordBox.UseSystemPasswordChar = true;
            this.PasswordBox.TextChanged += new System.EventHandler(this.PasswordBox_TextChanged);
            // 
            // GameDirectoryBox
            // 
            this.GameDirectoryBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            this.GameDirectoryBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GameDirectoryBox.Font = new System.Drawing.Font("Consolas", 10F);
            this.GameDirectoryBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.GameDirectoryBox.Location = new System.Drawing.Point(165, 161);
            this.GameDirectoryBox.Name = "GameDirectoryBox";
            this.GameDirectoryBox.Size = new System.Drawing.Size(150, 16);
            this.GameDirectoryBox.TabIndex = 4;
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.EmailLabel.Location = new System.Drawing.Point(63, 103);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(53, 20);
            this.EmailLabel.TabIndex = 6;
            this.EmailLabel.Text = "Email";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.PasswordLabel.Location = new System.Drawing.Point(45, 130);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(86, 20);
            this.PasswordLabel.TabIndex = 7;
            this.PasswordLabel.Text = "Password";
            // 
            // GameDirectoryPicker
            // 
            this.GameDirectoryPicker.ShowNewFolderButton = false;
            this.GameDirectoryPicker.HelpRequest += new System.EventHandler(this.GameDirectoryPicker_HelpRequest);
            // 
            // GameDirectoryLabel
            // 
            this.GameDirectoryLabel.AutoSize = true;
            this.GameDirectoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameDirectoryLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.GameDirectoryLabel.Location = new System.Drawing.Point(23, 157);
            this.GameDirectoryLabel.Name = "GameDirectoryLabel";
            this.GameDirectoryLabel.Size = new System.Drawing.Size(134, 20);
            this.GameDirectoryLabel.TabIndex = 8;
            this.GameDirectoryLabel.Text = "Game Directory";
            // 
            // CloseApp
            // 
            this.CloseApp.FlatAppearance.BorderSize = 0;
            this.CloseApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseApp.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseApp.ForeColor = System.Drawing.Color.White;
            this.CloseApp.Location = new System.Drawing.Point(315, 12);
            this.CloseApp.Name = "CloseApp";
            this.CloseApp.Size = new System.Drawing.Size(25, 25);
            this.CloseApp.TabIndex = 9;
            this.CloseApp.Text = "x";
            this.CloseApp.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CloseApp.UseVisualStyleBackColor = true;
            this.CloseApp.Click += new System.EventHandler(this.CloseApp_Click);
            // 
            // MOTDInfoPanel
            // 
            this.MOTDInfoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.MOTDInfoPanel.Controls.Add(this.webBrowser1);
            this.MOTDInfoPanel.Controls.Add(this.MOTDInfoBrowser);
            this.MOTDInfoPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MOTDInfoPanel.Location = new System.Drawing.Point(0, 255);
            this.MOTDInfoPanel.Name = "MOTDInfoPanel";
            this.MOTDInfoPanel.Size = new System.Drawing.Size(350, 245);
            this.MOTDInfoPanel.TabIndex = 10;
            // 
            // MOTDInfoBrowser
            // 
            this.MOTDInfoBrowser.AllowNavigation = false;
            this.MOTDInfoBrowser.AllowWebBrowserDrop = false;
            this.MOTDInfoBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MOTDInfoBrowser.IsWebBrowserContextMenuEnabled = false;
            this.MOTDInfoBrowser.Location = new System.Drawing.Point(0, 0);
            this.MOTDInfoBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.MOTDInfoBrowser.Name = "MOTDInfoBrowser";
            this.MOTDInfoBrowser.ScriptErrorsSuppressed = true;
            this.MOTDInfoBrowser.ScrollBarsEnabled = false;
            this.MOTDInfoBrowser.Size = new System.Drawing.Size(350, 245);
            this.MOTDInfoBrowser.TabIndex = 0;
            this.MOTDInfoBrowser.TabStop = false;
            this.MOTDInfoBrowser.Url = new System.Uri("", System.UriKind.Relative);
            this.MOTDInfoBrowser.WebBrowserShortcutsEnabled = false;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(350, 245);
            this.webBrowser1.TabIndex = 1;
            // 
            // Launcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(350, 500);
            this.Controls.Add(this.MOTDInfoPanel);
            this.Controls.Add(this.CloseApp);
            this.Controls.Add(this.GameDirectoryLabel);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.GameDirectoryBox);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.EmailBox);
            this.Controls.Add(this.button2);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Launcher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Project Storm Launcher";
            this.Load += new System.EventHandler(this.Launcher_Load);
            this.MOTDInfoPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox EmailBox;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.TextBox GameDirectoryBox;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.FolderBrowserDialog GameDirectoryPicker;
        private System.Windows.Forms.Label GameDirectoryLabel;
        private System.Windows.Forms.Button CloseApp;
        private System.Windows.Forms.Panel MOTDInfoPanel;
        private System.Windows.Forms.WebBrowser MOTDInfoBrowser;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}


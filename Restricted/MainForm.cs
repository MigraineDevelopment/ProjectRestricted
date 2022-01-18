using DevExpress.XtraEditors;
using Restricted.Interface;
using System;
using System.IO;
using System.Windows.Forms;
using DevExpress.XtraNavBar;
using Restricted.Discord;
using System.Diagnostics;
using Restricted.Shared;
using XDevkit;
using JRPC_Client;

namespace Restricted {
    public partial class MainForm : XtraForm {
        private PluginLoader _pluginLoader = new PluginLoader();
        private XboxUtils _xbox = new XboxUtils();
        private DiscordRPC _discord = new DiscordRPC();
        public MainForm() =>
            InitializeComponent();

        private void MainForm_Load(object sender, EventArgs e) {
            string path = GetExecutionFolder();
            var plugins = _pluginLoader.LoadPlugins(path);

            if (plugins.Count == 0)
                MessageBox.Show("No Plugins found!");
            else {
                foreach (IPlugin plugin in plugins) {
                    SimpleButton button = new SimpleButton() { Width = 200, Height = 40 };
                    button.Text = plugin.Name;
                    button.Tag = plugin;
                    button.Dock = DockStyle.Top;
                    button.AllowFocus = false;
                    button.Click += new EventHandler(button_Click);
                    PluginsPanel.Controls.Add(button);
                }
            }

            _discord.Initialize();

            foreach(string xbCon in Xbox.xbMgr.Consoles) {
                SimpleButton button = new SimpleButton() { Width = 200, Height = 40 };
                button.Text = xbCon;
                button.Tag = xbCon;
                button.Dock = DockStyle.Top;
                button.AllowFocus = false;
                button.Click += new EventHandler(consolebutton_Click);
                ConsoleList.Controls.Add(button);
            }
        }

        void button_Click(object sender, EventArgs e) {
            IPlugin plugin = (sender as SimpleButton).Tag as IPlugin;
            plugin.Form.Show();
        }

        void consolebutton_Click(object sender, EventArgs e) {
            string plugin = (sender as SimpleButton).Tag as string;
            Constants.SelectedXbox = plugin;
            XtraMessageBox.Show($"Console {Constants.SelectedXbox} set!");
        }

        public string GetExecutionFolder() {
            return Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
        }


        private void NavBtnConnect_LinkClicked(object sender, NavBarLinkEventArgs e) {
            try {
                _xbox.Initialize();
            }
            catch (Exception ex) {
                XtraMessageBox.Show($"Exception: {ex}");
            }

            if (_xbox.PollConnection()) {
                ListXboxInfo.Items.Add($"CPUkey: {Xbox.xbCon.GetCPUKey()}");
                ListXboxInfo.Items.Add($"Console IP: {Xbox.xbCon.XboxIP()}");
                ListXboxInfo.Items.Add($"Kernel: {Xbox.xbCon.GetKernalVersion()}");
            }
        }

        private void NavBtnDisconnect_LinkClicked(object sender, NavBarLinkEventArgs e) =>
            _xbox.DisposeConnection();

        private void btnDiscord_Click(object sender, EventArgs e) =>
            Process.Start("https://discord.gg/Jh7KeRVfGr");
    }
}
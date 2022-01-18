using System;
using System.Collections.Generic;
using DevExpress.XtraEditors;
using Restricted.Shared;
using XDevkit;

namespace Restricted.Plugin.XboxModules {
    public partial class MainForm : XtraForm {
        public static List<IModules> _modules = new List<IModules>();
        public MainForm() {
            InitializeComponent();
            GridListModules.DataSource = _modules;
        }

        private void MainForm_Load(object sender, EventArgs e) {

        }

        private void btnLoadModule_Click(object sender, EventArgs e) {
            if (!Xbox.IsConnected())
                throw new Exception("Not connected to a console!");


        }

        private void btnUnloadModule_Click(object sender, EventArgs e) {
            if (!Xbox.IsConnected())
                throw new Exception("Not connected to a console!");


        }

        private void btnRefresh_Click(object sender, EventArgs e) {
            if (!Xbox.IsConnected())
                throw new Exception("Not connected to a console!");

            GridListModules.DataSource = null;

            _modules.Clear();

            foreach (IXboxModule module in Xbox.xbCon.DebugTarget.Modules) {
                _modules.Add(new IModules { 
                    Name = module.ModuleInfo.Name,
                    BaseAddress = module.ModuleInfo.BaseAddress.ToString("X"),
                    Checksum = module.ModuleInfo.CheckSum.ToString("X8")
                });
            }

            GridListModules.DataSource = _modules;
        }
    }

    public class IModules {
        public string Name { get; set; }
        public string BaseAddress { get; set; }
        public string Checksum { get; set; }
    }
}
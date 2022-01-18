using Restricted.Interface;
using System.Windows.Forms;

namespace Restricted.Plugin.XboxModules {
    public class XboxModules : IPlugin {
        public string Name
        {
            get { return "Module Launcher"; }
        }

        public Form Form
        {
            get { return new MainForm(); }
        }
    }
}

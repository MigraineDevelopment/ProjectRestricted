using Restricted.Interface;
using System.Windows.Forms;

namespace Restricted.Plugin.Screenshots
{
    public class XboxModules : IPlugin
    {
        public string Name
        {
            get { return "Screenshot"; }
        }

        public Form Form
        {
            get { return new MainForm(); }
        }
    }
}

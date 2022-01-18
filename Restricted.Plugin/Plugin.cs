using Restricted.Interface;
using System.Windows.Forms;

namespace Restricted.Plugin {
    public class Plugin : IPlugin {
        public string Name
        {
            get { return "Test Form"; }
        }

        public Form Form
        {
            get { return new TestForm(); }
        }
    }
}

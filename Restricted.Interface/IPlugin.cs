using System.Windows.Forms;

namespace Restricted.Interface {
    public interface IPlugin {
        string Name { get; }
        Form Form { get; }
    }
}

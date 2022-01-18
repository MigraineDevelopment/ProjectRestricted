using XDevkit;
using Restricted.Shared;
using JRPC_Client;
using DevExpress.XtraEditors;

namespace Restricted {
    public class XboxUtils {
        public void Initialize() {
            Xbox.xbCon = Xbox.xbMgr.OpenConsole(Constants.SelectedXbox);
            Xbox.xbDebug = Xbox.xbCon.DebugTarget;
            Xbox.xbDebug.ConnectAsDebugger(Constants.ProjectName, XboxDebugConnectFlags.Force);

            if (PollConnection()) {
                XtraMessageBox.Show($"Connected to {Xbox.xbCon.Name}");
                Constants.IsConnected = true;
            }
        }

        public bool PollConnection() {
            try { return (Xbox.xbCon.GetMemory(0x81AA2200, 1).Length > 0); }
            catch { return false; }
        }

        public void DisposeConnection() {
            try {
                Xbox.xbCon.DebugTarget.DisconnectAsDebugger();
                Xbox.xbCon = null;
                Xbox.xbMgr = null;
                Constants.IsConnected = false;
            }
            catch { }
        }
    }
}

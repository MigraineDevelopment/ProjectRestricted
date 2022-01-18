using System;
using System.Collections.Generic;
using XDevkit;

namespace Restricted.Shared {
    public class Xbox {
        public static IXboxConsole xbCon { get; set; }
        public static IXboxDebugTarget xbDebug { get; set; }
        public static IXboxManager xbMgr = new XboxManager();
        public static IXboxFiles xbFiles { get; set; }
        public static IXboxFile xbFile { get; set; }

		public enum TitleID : uint {
			COD4 = 0x415607E6,
			MW2 = 0x41560817,
			MW3 = 0x415608CB
		}

		public enum MPStringAddr : uint {
			COD4 = 0x82032AC4,
			MW2 = 0x82001270,
			MW3 = 0x82001458,
			COD4_ALPHA = 0x820019EC,
			MW2_ALPHA = 0x82001D38
		}

		public static bool IsConnected() {
			return Constants.IsConnected;
		}

		public static List<string> GetModuleNames() {
			if (!IsConnected())
				throw new Exception("Not connected to a console!");

			List<string> moduleNames = new List<string>();

			foreach (IXboxModule module in xbCon.DebugTarget.Modules)
				moduleNames.Add(module.ModuleInfo.Name);

			return moduleNames;
		}

		public static IXboxFile GetFile(string filePath) {
			if (!IsConnected())
				throw new Exception("Not connected to a console!");

			IXboxFile file = null;

			try {
				file = xbCon.GetFileObject(filePath);
			}
			catch (Exception) {
				throw new Exception(filePath + " does not exist!");
			}

			return file;
		}
	}
}

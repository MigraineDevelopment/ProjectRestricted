using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Reflection;
using Restricted.Shared;

namespace Restricted.Interface {
    public class PluginLoader {
        public IList<IPlugin> LoadPlugins(string folder) {
            IList<IPlugin> plugins = new List<IPlugin>();

            // Get files in folder
            string[] files = Directory.GetFiles(folder + "\\" + Constants.PluginFolder, "*.dll");
            foreach (string file in files) {
                Assembly assembly = Assembly.LoadFile(file);
                var types = assembly.GetExportedTypes();

                foreach (Type type in types)
                    if (type.GetInterfaces().Contains(typeof(IPlugin))) {
                        object instance = Activator.CreateInstance(type);
                        plugins.Add(instance as IPlugin);
                    }
            }

            return plugins;
        }
    }
}

using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;

namespace Restricted.Plugin.Screenshots {
    public partial class MainForm : DevExpress.XtraEditors.XtraForm {
        public MainForm() {
            InitializeComponent();
        }

        public static string[] GetFilesFrom(string searchFolder, string[] filters, bool isRecursive) {
            List<string> filesFound = new List<string>();
            var searchOption = isRecursive ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly;
            foreach (var filter in filters)
            {
                filesFound.AddRange(Directory.GetFiles(searchFolder, string.Format("*.{0}", filter), searchOption));
            }
            return filesFound.ToArray();
        }

        private void MainForm_Load(object sender, EventArgs e) {

        }

        public string GetExecutionFolder() {
            return Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
        }

        private void btnScreenshot_Click(object sender, EventArgs e)
        {
            var filters = new String[] { "jpg", "jpeg", "png", "bmp" };
            var files = GetFilesFrom($"{GetExecutionFolder()}\\Screenshots", filters, false);

            foreach (var file in files) {
                Image image = Image.FromFile(file);

                imageCollection1.AddImage(image);
            }
        }
    }
}
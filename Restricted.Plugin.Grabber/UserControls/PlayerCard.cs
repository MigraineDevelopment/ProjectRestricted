using DevExpress.XtraEditors;
using System;

namespace Restricted.Plugin.Grabber.UserControls {
    public partial class PlayerCard : XtraUserControl {
        private string _gamertag { get; set; }
        private string _xuid { get; set; }
        private string _external { get; set; }
        private string _internal { get; set; }
        private string _port { get; set; }

        public PlayerCard(string Gamertag, string XUID, string External, string Internal, string Port) {
            InitializeComponent();
            _gamertag = Gamertag;
            _xuid = XUID;
            _external = External;
            _internal = Internal;
            _port = Port;
        }

        private void PlayerCard_Load(object sender, EventArgs e) {
            txtGamertag.Text = _gamertag;
            txtXUID.Text = _xuid;
            txtExternalIP.Text = _external;
            txtInternalIP.Text = _internal;
            txtPort.Text = _port;
        }
    }
}

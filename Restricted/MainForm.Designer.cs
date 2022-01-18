namespace Restricted
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
            this.NavBtnConnect = new DevExpress.XtraNavBar.NavBarItem();
            this.NavBtnDisconnect = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroupControlContainer1 = new DevExpress.XtraNavBar.NavBarGroupControlContainer();
            this.PluginsPanel = new DevExpress.XtraEditors.XtraScrollableControl();
            this.navBarGroup2 = new DevExpress.XtraNavBar.NavBarGroup();
            this.btnDiscord = new DevExpress.XtraEditors.PictureEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.ListXboxInfo = new DevExpress.XtraEditors.ListBoxControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.ConsoleList = new DevExpress.XtraEditors.XtraScrollableControl();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            this.navBarControl1.SuspendLayout();
            this.navBarGroupControlContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnDiscord.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListXboxInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = this.navBarGroup1;
            this.navBarControl1.Controls.Add(this.navBarGroupControlContainer1);
            this.navBarControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroup1,
            this.navBarGroup2});
            this.navBarControl1.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.NavBtnConnect,
            this.NavBtnDisconnect});
            this.navBarControl1.Location = new System.Drawing.Point(0, 0);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 140;
            this.navBarControl1.Size = new System.Drawing.Size(140, 525);
            this.navBarControl1.TabIndex = 1;
            this.navBarControl1.Text = "navBarControl1";
            // 
            // navBarGroup1
            // 
            this.navBarGroup1.Caption = "Connection";
            this.navBarGroup1.Expanded = true;
            this.navBarGroup1.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.NavBtnConnect),
            new DevExpress.XtraNavBar.NavBarItemLink(this.NavBtnDisconnect)});
            this.navBarGroup1.Name = "navBarGroup1";
            // 
            // NavBtnConnect
            // 
            this.NavBtnConnect.Caption = "Connect";
            this.NavBtnConnect.Name = "NavBtnConnect";
            this.NavBtnConnect.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.NavBtnConnect_LinkClicked);
            // 
            // NavBtnDisconnect
            // 
            this.NavBtnDisconnect.Caption = "Disconnect";
            this.NavBtnDisconnect.Name = "NavBtnDisconnect";
            this.NavBtnDisconnect.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.NavBtnDisconnect_LinkClicked);
            // 
            // navBarGroupControlContainer1
            // 
            this.navBarGroupControlContainer1.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.navBarGroupControlContainer1.Appearance.Options.UseBackColor = true;
            this.navBarGroupControlContainer1.Controls.Add(this.PluginsPanel);
            this.navBarGroupControlContainer1.Name = "navBarGroupControlContainer1";
            this.navBarGroupControlContainer1.Size = new System.Drawing.Size(140, 80);
            this.navBarGroupControlContainer1.TabIndex = 0;
            // 
            // PluginsPanel
            // 
            this.PluginsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PluginsPanel.Location = new System.Drawing.Point(0, 0);
            this.PluginsPanel.Name = "PluginsPanel";
            this.PluginsPanel.Size = new System.Drawing.Size(140, 80);
            this.PluginsPanel.TabIndex = 0;
            // 
            // navBarGroup2
            // 
            this.navBarGroup2.Caption = "Plugins";
            this.navBarGroup2.ControlContainer = this.navBarGroupControlContainer1;
            this.navBarGroup2.GroupClientHeight = 80;
            this.navBarGroup2.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.ControlContainer;
            this.navBarGroup2.Name = "navBarGroup2";
            // 
            // btnDiscord
            // 
            this.btnDiscord.EditValue = global::Restricted.Properties.Resources.Discord;
            this.btnDiscord.Location = new System.Drawing.Point(784, 449);
            this.btnDiscord.Name = "btnDiscord";
            this.btnDiscord.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnDiscord.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.btnDiscord.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.btnDiscord.Size = new System.Drawing.Size(64, 64);
            this.btnDiscord.TabIndex = 2;
            this.btnDiscord.Click += new System.EventHandler(this.btnDiscord_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.ListXboxInfo);
            this.groupControl1.Location = new System.Drawing.Point(516, 21);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(248, 168);
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Text = "Your Xbox Info";
            // 
            // ListXboxInfo
            // 
            this.ListXboxInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListXboxInfo.Location = new System.Drawing.Point(2, 27);
            this.ListXboxInfo.Name = "ListXboxInfo";
            this.ListXboxInfo.Size = new System.Drawing.Size(244, 139);
            this.ListXboxInfo.TabIndex = 0;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.ConsoleList);
            this.groupControl2.Location = new System.Drawing.Point(253, 21);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(248, 168);
            this.groupControl2.TabIndex = 4;
            this.groupControl2.Text = "Select a Console";
            // 
            // ConsoleList
            // 
            this.ConsoleList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConsoleList.Location = new System.Drawing.Point(2, 27);
            this.ConsoleList.Name = "ConsoleList";
            this.ConsoleList.Size = new System.Drawing.Size(244, 139);
            this.ConsoleList.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 525);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.btnDiscord);
            this.Controls.Add(this.navBarControl1);
            this.IconOptions.Image = global::Restricted.Properties.Resources.Logo;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Restricted - Dashboard";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            this.navBarControl1.ResumeLayout(false);
            this.navBarGroupControlContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnDiscord.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ListXboxInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
        private DevExpress.XtraNavBar.NavBarItem NavBtnConnect;
        private DevExpress.XtraNavBar.NavBarItem NavBtnDisconnect;
        private DevExpress.XtraNavBar.NavBarGroupControlContainer navBarGroupControlContainer1;
        private DevExpress.XtraEditors.XtraScrollableControl PluginsPanel;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup2;
        private DevExpress.XtraEditors.PictureEdit btnDiscord;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.ListBoxControl ListXboxInfo;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.XtraScrollableControl ConsoleList;
    }
}
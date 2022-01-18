namespace Restricted.Plugin.Grabber.UserControls
{
    partial class PlayerCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.txtGamertag = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtXUID = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtExternalIP = new DevExpress.XtraEditors.LabelControl();
            this.txtInternalIP = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtPort = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = global::Restricted.Plugin.Grabber.Properties.Resources.Logo;
            this.pictureEdit1.Location = new System.Drawing.Point(14, 15);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(64, 64);
            this.pictureEdit1.TabIndex = 0;
            // 
            // txtGamertag
            // 
            this.txtGamertag.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGamertag.Appearance.Options.UseFont = true;
            this.txtGamertag.Location = new System.Drawing.Point(84, 47);
            this.txtGamertag.Name = "txtGamertag";
            this.txtGamertag.Size = new System.Drawing.Size(25, 14);
            this.txtGamertag.TabIndex = 1;
            this.txtGamertag.Text = "N/A";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(14, 85);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(38, 14);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "XUID: ";
            // 
            // txtXUID
            // 
            this.txtXUID.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtXUID.Appearance.Options.UseFont = true;
            this.txtXUID.Location = new System.Drawing.Point(58, 85);
            this.txtXUID.Name = "txtXUID";
            this.txtXUID.Size = new System.Drawing.Size(168, 14);
            this.txtXUID.TabIndex = 3;
            this.txtXUID.Text = "000000000000000000000";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(14, 105);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(71, 14);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "External IP:";
            // 
            // txtExternalIP
            // 
            this.txtExternalIP.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExternalIP.Appearance.Options.UseFont = true;
            this.txtExternalIP.Location = new System.Drawing.Point(91, 105);
            this.txtExternalIP.Name = "txtExternalIP";
            this.txtExternalIP.Size = new System.Drawing.Size(25, 14);
            this.txtExternalIP.TabIndex = 5;
            this.txtExternalIP.Text = "N/A";
            // 
            // txtInternalIP
            // 
            this.txtInternalIP.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInternalIP.Appearance.Options.UseFont = true;
            this.txtInternalIP.Location = new System.Drawing.Point(91, 125);
            this.txtInternalIP.Name = "txtInternalIP";
            this.txtInternalIP.Size = new System.Drawing.Size(25, 14);
            this.txtInternalIP.TabIndex = 7;
            this.txtInternalIP.Text = "N/A";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(14, 125);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(70, 14);
            this.labelControl6.TabIndex = 6;
            this.labelControl6.Text = "Internal IP:";
            // 
            // txtPort
            // 
            this.txtPort.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPort.Appearance.Options.UseFont = true;
            this.txtPort.Location = new System.Drawing.Point(56, 145);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(25, 14);
            this.txtPort.TabIndex = 9;
            this.txtPort.Text = "N/A";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(15, 145);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(35, 14);
            this.labelControl5.TabIndex = 8;
            this.labelControl5.Text = "Port: ";
            // 
            // PlayerCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.txtInternalIP);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.txtExternalIP);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtXUID);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtGamertag);
            this.Controls.Add(this.pictureEdit1);
            this.Name = "PlayerCard";
            this.Size = new System.Drawing.Size(329, 181);
            this.Load += new System.EventHandler(this.PlayerCard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.LabelControl txtGamertag;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl txtXUID;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl txtExternalIP;
        private DevExpress.XtraEditors.LabelControl txtInternalIP;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl txtPort;
        private DevExpress.XtraEditors.LabelControl labelControl5;
    }
}

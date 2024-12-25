namespace WinFormsControl
{
    partial class VideoConfig
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VideoConfig));
            fraVideConfig = new GroupBox();
            cmbBitRate = new ComboBox();
            lblBitRate = new Label();
            cmbFrameRate = new ComboBox();
            lblFrameRate = new Label();
            cmbAspect = new ComboBox();
            lblAspect = new Label();
            cmbSize = new ComboBox();
            lblSize = new Label();
            cmbCodec = new ComboBox();
            lblCodec = new Label();
            cmbFormat = new ComboBox();
            lblFormat = new Label();
            fraVideConfig.SuspendLayout();
            SuspendLayout();
            // 
            // fraVideConfig
            // 
            fraVideConfig.Controls.Add(cmbBitRate);
            fraVideConfig.Controls.Add(lblBitRate);
            fraVideConfig.Controls.Add(cmbFrameRate);
            fraVideConfig.Controls.Add(lblFrameRate);
            fraVideConfig.Controls.Add(cmbAspect);
            fraVideConfig.Controls.Add(lblAspect);
            fraVideConfig.Controls.Add(cmbSize);
            fraVideConfig.Controls.Add(lblSize);
            fraVideConfig.Controls.Add(cmbCodec);
            fraVideConfig.Controls.Add(lblCodec);
            fraVideConfig.Controls.Add(cmbFormat);
            fraVideConfig.Controls.Add(lblFormat);
            resources.ApplyResources(fraVideConfig, "fraVideConfig");
            fraVideConfig.Name = "fraVideConfig";
            fraVideConfig.TabStop = false;
            // 
            // cmbBitRate
            // 
            resources.ApplyResources(cmbBitRate, "cmbBitRate");
            cmbBitRate.FormattingEnabled = true;
            cmbBitRate.Name = "cmbBitRate";
            // 
            // lblBitRate
            // 
            resources.ApplyResources(lblBitRate, "lblBitRate");
            lblBitRate.Name = "lblBitRate";
            // 
            // cmbFrameRate
            // 
            resources.ApplyResources(cmbFrameRate, "cmbFrameRate");
            cmbFrameRate.FormattingEnabled = true;
            cmbFrameRate.Name = "cmbFrameRate";
            // 
            // lblFrameRate
            // 
            resources.ApplyResources(lblFrameRate, "lblFrameRate");
            lblFrameRate.Name = "lblFrameRate";
            // 
            // cmbAspect
            // 
            resources.ApplyResources(cmbAspect, "cmbAspect");
            cmbAspect.FormattingEnabled = true;
            cmbAspect.Name = "cmbAspect";
            // 
            // lblAspect
            // 
            resources.ApplyResources(lblAspect, "lblAspect");
            lblAspect.Name = "lblAspect";
            // 
            // cmbSize
            // 
            resources.ApplyResources(cmbSize, "cmbSize");
            cmbSize.FormattingEnabled = true;
            cmbSize.Name = "cmbSize";
            // 
            // lblSize
            // 
            resources.ApplyResources(lblSize, "lblSize");
            lblSize.Name = "lblSize";
            // 
            // cmbCodec
            // 
            resources.ApplyResources(cmbCodec, "cmbCodec");
            cmbCodec.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCodec.FormattingEnabled = true;
            cmbCodec.Name = "cmbCodec";
            // 
            // lblCodec
            // 
            resources.ApplyResources(lblCodec, "lblCodec");
            lblCodec.Name = "lblCodec";
            // 
            // cmbFormat
            // 
            resources.ApplyResources(cmbFormat, "cmbFormat");
            cmbFormat.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFormat.FormattingEnabled = true;
            cmbFormat.Name = "cmbFormat";
            // 
            // lblFormat
            // 
            resources.ApplyResources(lblFormat, "lblFormat");
            lblFormat.Name = "lblFormat";
            // 
            // VideoConfig
            // 
            AutoScaleMode = AutoScaleMode.None;
            Controls.Add(fraVideConfig);
            resources.ApplyResources(this, "$this");
            Name = "VideoConfig";
            fraVideConfig.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox fraVideConfig;
        private ComboBox cmbFormat;
        private Label lblFormat;
        private Label lblCodec;
        private Label lblAspect;
        private ComboBox cmbSize;
        private Label lblSize;
        private ComboBox cmbCodec;
        private ComboBox cmbFrameRate;
        private Label lblFrameRate;
        private ComboBox cmbAspect;
        private ComboBox cmbBitRate;
        private Label lblBitRate;
    }
}

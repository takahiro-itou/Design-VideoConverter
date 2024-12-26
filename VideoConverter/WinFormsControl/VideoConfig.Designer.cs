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
            spcVideoConfig = new SplitContainer();
            cmbAspect = new ComboBox();
            lblAspect = new Label();
            cmbSize = new ComboBox();
            lblSize = new Label();
            cmbFormat = new ComboBox();
            lblFormat = new Label();
            cmbBitRate = new ComboBox();
            lblBitRate = new Label();
            cmbFrameRate = new ComboBox();
            lblFrameRate = new Label();
            cmbCodec = new ComboBox();
            lblCodec = new Label();
            fraVideConfig = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)spcVideoConfig).BeginInit();
            spcVideoConfig.Panel1.SuspendLayout();
            spcVideoConfig.Panel2.SuspendLayout();
            spcVideoConfig.SuspendLayout();
            fraVideConfig.SuspendLayout();
            SuspendLayout();
            // 
            // spcVideoConfig
            // 
            resources.ApplyResources(spcVideoConfig, "spcVideoConfig");
            spcVideoConfig.Name = "spcVideoConfig";
            // 
            // spcVideoConfig.Panel1
            // 
            spcVideoConfig.Panel1.Controls.Add(cmbAspect);
            spcVideoConfig.Panel1.Controls.Add(lblAspect);
            spcVideoConfig.Panel1.Controls.Add(cmbSize);
            spcVideoConfig.Panel1.Controls.Add(lblSize);
            spcVideoConfig.Panel1.Controls.Add(cmbFormat);
            spcVideoConfig.Panel1.Controls.Add(lblFormat);
            // 
            // spcVideoConfig.Panel2
            // 
            spcVideoConfig.Panel2.Controls.Add(cmbBitRate);
            spcVideoConfig.Panel2.Controls.Add(lblBitRate);
            spcVideoConfig.Panel2.Controls.Add(cmbFrameRate);
            spcVideoConfig.Panel2.Controls.Add(lblFrameRate);
            spcVideoConfig.Panel2.Controls.Add(cmbCodec);
            spcVideoConfig.Panel2.Controls.Add(lblCodec);
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
            // fraVideConfig
            // 
            fraVideConfig.Controls.Add(spcVideoConfig);
            resources.ApplyResources(fraVideConfig, "fraVideConfig");
            fraVideConfig.Name = "fraVideConfig";
            fraVideConfig.TabStop = false;
            // 
            // VideoConfig
            // 
            AutoScaleMode = AutoScaleMode.None;
            Controls.Add(fraVideConfig);
            resources.ApplyResources(this, "$this");
            Name = "VideoConfig";
            spcVideoConfig.Panel1.ResumeLayout(false);
            spcVideoConfig.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)spcVideoConfig).EndInit();
            spcVideoConfig.ResumeLayout(false);
            fraVideConfig.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer spcVideoConfig;
        private ComboBox cmbAspect;
        private Label lblAspect;
        private ComboBox cmbSize;
        private Label lblSize;
        private ComboBox cmbFormat;
        private Label lblFormat;
        private ComboBox cmbBitRate;
        private Label lblBitRate;
        private ComboBox cmbFrameRate;
        private Label lblFrameRate;
        private ComboBox cmbCodec;
        private Label lblCodec;
        private GroupBox fraVideConfig;
    }
}

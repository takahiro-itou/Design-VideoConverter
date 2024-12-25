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
            SuspendLayout();
            // 
            // fraVideConfig
            // 
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
            ResumeLayout(false);
        }

        #endregion

        private GroupBox fraVideConfig;
    }
}

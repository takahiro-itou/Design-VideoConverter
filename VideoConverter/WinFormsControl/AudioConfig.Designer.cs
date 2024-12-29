namespace WinFormsControl
{
    partial class AudioConfig
    {
        /// <summary> 
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AudioConfig));
            fraAudioConfig = new GroupBox();
            spcAudioConfig = new SplitContainer();
            cmbAudioDelay = new ComboBox();
            lblDelay = new Label();
            cmbVolume = new ComboBox();
            lblVolume = new Label();
            cmbChannels = new ComboBox();
            lblChannel = new Label();
            cmbBitRate = new ComboBox();
            lblBitRate = new Label();
            cmbSampleRate = new ComboBox();
            lblSampleRate = new Label();
            cmbCodec = new ComboBox();
            lblCodec = new Label();
            fraAudioConfig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)spcAudioConfig).BeginInit();
            spcAudioConfig.Panel1.SuspendLayout();
            spcAudioConfig.Panel2.SuspendLayout();
            spcAudioConfig.SuspendLayout();
            SuspendLayout();
            // 
            // fraAudioConfig
            // 
            resources.ApplyResources(fraAudioConfig, "fraAudioConfig");
            fraAudioConfig.Controls.Add(spcAudioConfig);
            fraAudioConfig.Name = "fraAudioConfig";
            fraAudioConfig.TabStop = false;
            // 
            // spcAudioConfig
            // 
            resources.ApplyResources(spcAudioConfig, "spcAudioConfig");
            spcAudioConfig.Name = "spcAudioConfig";
            // 
            // spcAudioConfig.Panel1
            // 
            resources.ApplyResources(spcAudioConfig.Panel1, "spcAudioConfig.Panel1");
            spcAudioConfig.Panel1.Controls.Add(cmbAudioDelay);
            spcAudioConfig.Panel1.Controls.Add(lblDelay);
            spcAudioConfig.Panel1.Controls.Add(cmbVolume);
            spcAudioConfig.Panel1.Controls.Add(lblVolume);
            spcAudioConfig.Panel1.Controls.Add(cmbChannels);
            spcAudioConfig.Panel1.Controls.Add(lblChannel);
            // 
            // spcAudioConfig.Panel2
            // 
            resources.ApplyResources(spcAudioConfig.Panel2, "spcAudioConfig.Panel2");
            spcAudioConfig.Panel2.Controls.Add(cmbBitRate);
            spcAudioConfig.Panel2.Controls.Add(lblBitRate);
            spcAudioConfig.Panel2.Controls.Add(cmbSampleRate);
            spcAudioConfig.Panel2.Controls.Add(lblSampleRate);
            spcAudioConfig.Panel2.Controls.Add(cmbCodec);
            spcAudioConfig.Panel2.Controls.Add(lblCodec);
            // 
            // cmbAudioDelay
            // 
            resources.ApplyResources(cmbAudioDelay, "cmbAudioDelay");
            cmbAudioDelay.FormattingEnabled = true;
            cmbAudioDelay.Name = "cmbAudioDelay";
            // 
            // lblDelay
            // 
            resources.ApplyResources(lblDelay, "lblDelay");
            lblDelay.Name = "lblDelay";
            // 
            // cmbVolume
            // 
            resources.ApplyResources(cmbVolume, "cmbVolume");
            cmbVolume.FormattingEnabled = true;
            cmbVolume.Name = "cmbVolume";
            // 
            // lblVolume
            // 
            resources.ApplyResources(lblVolume, "lblVolume");
            lblVolume.Name = "lblVolume";
            // 
            // cmbChannels
            // 
            resources.ApplyResources(cmbChannels, "cmbChannels");
            cmbChannels.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbChannels.FormattingEnabled = true;
            cmbChannels.Name = "cmbChannels";
            // 
            // lblChannel
            // 
            resources.ApplyResources(lblChannel, "lblChannel");
            lblChannel.Name = "lblChannel";
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
            // cmbSampleRate
            // 
            resources.ApplyResources(cmbSampleRate, "cmbSampleRate");
            cmbSampleRate.FormattingEnabled = true;
            cmbSampleRate.Name = "cmbSampleRate";
            // 
            // lblSampleRate
            // 
            resources.ApplyResources(lblSampleRate, "lblSampleRate");
            lblSampleRate.Name = "lblSampleRate";
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
            // AudioConfig
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.None;
            Controls.Add(fraAudioConfig);
            Name = "AudioConfig";
            fraAudioConfig.ResumeLayout(false);
            spcAudioConfig.Panel1.ResumeLayout(false);
            spcAudioConfig.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)spcAudioConfig).EndInit();
            spcAudioConfig.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox fraAudioConfig;
        private SplitContainer spcAudioConfig;
        private ComboBox cmbAudioDelay;
        private Label lblDelay;
        private ComboBox cmbVolume;
        private Label lblVolume;
        private ComboBox cmbChannels;
        private Label lblChannel;
        private ComboBox cmbBitRate;
        private Label lblBitRate;
        private ComboBox cmbSampleRate;
        private Label lblSampleRate;
        private ComboBox cmbCodec;
        private Label lblCodec;
    }
}

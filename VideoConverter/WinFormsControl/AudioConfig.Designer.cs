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
            fraAudioConfig.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            fraAudioConfig.Controls.Add(spcAudioConfig);
            fraAudioConfig.Location = new Point(0, 0);
            fraAudioConfig.Name = "fraAudioConfig";
            fraAudioConfig.Size = new Size(532, 104);
            fraAudioConfig.TabIndex = 0;
            fraAudioConfig.TabStop = false;
            fraAudioConfig.Text = "&Audio Config";
            // 
            // spcAudioConfig
            // 
            spcAudioConfig.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            spcAudioConfig.Location = new Point(8, 16);
            spcAudioConfig.Name = "spcAudioConfig";
            // 
            // spcAudioConfig.Panel1
            // 
            spcAudioConfig.Panel1.Controls.Add(cmbAudioDelay);
            spcAudioConfig.Panel1.Controls.Add(lblDelay);
            spcAudioConfig.Panel1.Controls.Add(cmbVolume);
            spcAudioConfig.Panel1.Controls.Add(lblVolume);
            spcAudioConfig.Panel1.Controls.Add(cmbChannels);
            spcAudioConfig.Panel1.Controls.Add(lblChannel);
            spcAudioConfig.Panel1MinSize = 256;
            // 
            // spcAudioConfig.Panel2
            // 
            spcAudioConfig.Panel2.Controls.Add(cmbBitRate);
            spcAudioConfig.Panel2.Controls.Add(lblBitRate);
            spcAudioConfig.Panel2.Controls.Add(cmbSampleRate);
            spcAudioConfig.Panel2.Controls.Add(lblSampleRate);
            spcAudioConfig.Panel2.Controls.Add(cmbCodec);
            spcAudioConfig.Panel2.Controls.Add(lblCodec);
            spcAudioConfig.Panel2MinSize = 256;
            spcAudioConfig.Size = new Size(516, 78);
            spcAudioConfig.SplitterDistance = 256;
            spcAudioConfig.TabIndex = 0;
            // 
            // cmbAudioDelay
            // 
            cmbAudioDelay.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cmbAudioDelay.FormattingEnabled = true;
            cmbAudioDelay.Location = new Point(88, 56);
            cmbAudioDelay.Name = "cmbAudioDelay";
            cmbAudioDelay.Size = new Size(160, 20);
            cmbAudioDelay.TabIndex = 19;
            // 
            // lblDelay
            // 
            lblDelay.ImeMode = ImeMode.NoControl;
            lblDelay.Location = new Point(4, 56);
            lblDelay.Name = "lblDelay";
            lblDelay.Size = new Size(80, 20);
            lblDelay.TabIndex = 18;
            lblDelay.Text = "Delay Corr.";
            lblDelay.TextAlign = ContentAlignment.MiddleRight;
            // 
            // cmbVolume
            // 
            cmbVolume.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cmbVolume.FormattingEnabled = true;
            cmbVolume.Location = new Point(88, 28);
            cmbVolume.Name = "cmbVolume";
            cmbVolume.Size = new Size(160, 20);
            cmbVolume.TabIndex = 17;
            // 
            // lblVolume
            // 
            lblVolume.ImeMode = ImeMode.NoControl;
            lblVolume.Location = new Point(4, 28);
            lblVolume.Name = "lblVolume";
            lblVolume.Size = new Size(80, 20);
            lblVolume.TabIndex = 16;
            lblVolume.Text = "Volume:";
            lblVolume.TextAlign = ContentAlignment.MiddleRight;
            // 
            // cmbChannels
            // 
            cmbChannels.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cmbChannels.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbChannels.FormattingEnabled = true;
            cmbChannels.Location = new Point(88, 0);
            cmbChannels.Name = "cmbChannels";
            cmbChannels.Size = new Size(160, 20);
            cmbChannels.TabIndex = 15;
            // 
            // lblChannel
            // 
            lblChannel.ImeMode = ImeMode.NoControl;
            lblChannel.Location = new Point(4, 0);
            lblChannel.Name = "lblChannel";
            lblChannel.Size = new Size(80, 20);
            lblChannel.TabIndex = 14;
            lblChannel.Text = "Channels";
            lblChannel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // cmbBitRate
            // 
            cmbBitRate.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cmbBitRate.FormattingEnabled = true;
            cmbBitRate.Location = new Point(88, 56);
            cmbBitRate.Name = "cmbBitRate";
            cmbBitRate.Size = new Size(160, 20);
            cmbBitRate.TabIndex = 23;
            // 
            // lblBitRate
            // 
            lblBitRate.ImeMode = ImeMode.NoControl;
            lblBitRate.Location = new Point(4, 56);
            lblBitRate.Name = "lblBitRate";
            lblBitRate.Size = new Size(80, 20);
            lblBitRate.TabIndex = 22;
            lblBitRate.Text = "Bit Rate:";
            lblBitRate.TextAlign = ContentAlignment.MiddleRight;
            // 
            // cmbSampleRate
            // 
            cmbSampleRate.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cmbSampleRate.FormattingEnabled = true;
            cmbSampleRate.Location = new Point(88, 28);
            cmbSampleRate.Name = "cmbSampleRate";
            cmbSampleRate.Size = new Size(160, 20);
            cmbSampleRate.TabIndex = 21;
            // 
            // lblSampleRate
            // 
            lblSampleRate.ImeMode = ImeMode.NoControl;
            lblSampleRate.Location = new Point(4, 28);
            lblSampleRate.Name = "lblSampleRate";
            lblSampleRate.Size = new Size(80, 20);
            lblSampleRate.TabIndex = 20;
            lblSampleRate.Text = "Sample Rate:";
            lblSampleRate.TextAlign = ContentAlignment.MiddleRight;
            // 
            // cmbCodec
            // 
            cmbCodec.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cmbCodec.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCodec.FormattingEnabled = true;
            cmbCodec.Location = new Point(88, 0);
            cmbCodec.Name = "cmbCodec";
            cmbCodec.Size = new Size(160, 20);
            cmbCodec.TabIndex = 19;
            // 
            // lblCodec
            // 
            lblCodec.ImeMode = ImeMode.NoControl;
            lblCodec.Location = new Point(4, 0);
            lblCodec.Name = "lblCodec";
            lblCodec.Size = new Size(80, 20);
            lblCodec.TabIndex = 18;
            lblCodec.Text = "Codec:";
            lblCodec.TextAlign = ContentAlignment.MiddleRight;
            // 
            // AudioConfig
            // 
            AutoScaleMode = AutoScaleMode.None;
            Controls.Add(fraAudioConfig);
            Font = new Font("ＭＳ ゴシック", 9F, FontStyle.Regular, GraphicsUnit.Point);
            MaximumSize = new Size(0, 104);
            MinimumSize = new Size(532, 104);
            Name = "AudioConfig";
            Size = new Size(532, 104);
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

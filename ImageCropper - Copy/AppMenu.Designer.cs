namespace ImageCropper
{
    partial class AppMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonBrowse = new Button();
            openFileDialog1 = new OpenFileDialog();
            pictureBox = new PictureBox();
            buttonCrop = new Button();
            textBoxFile = new TextBox();
            buttonSave = new Button();
            buttonClose = new Button();
            radioButtonAudio = new RadioButton();
            radioButtonVideo = new RadioButton();
            groupBoxMediaType = new GroupBox();
            groupBoxQuality = new GroupBox();
            labelQuality = new Label();
            radioButtonDefault = new RadioButton();
            radioButtonManual = new RadioButton();
            trackBarQuality = new TrackBar();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            groupBoxMediaType.SuspendLayout();
            groupBoxQuality.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBarQuality).BeginInit();
            SuspendLayout();
            // 
            // buttonBrowse
            // 
            buttonBrowse.Location = new Point(430, 16);
            buttonBrowse.Margin = new Padding(3, 4, 3, 4);
            buttonBrowse.Name = "buttonBrowse";
            buttonBrowse.Size = new Size(71, 31);
            buttonBrowse.TabIndex = 0;
            buttonBrowse.Text = "Browse";
            buttonBrowse.UseVisualStyleBackColor = true;
            buttonBrowse.Click += buttonBrowse_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox
            // 
            pictureBox.Location = new Point(506, 16);
            pictureBox.Margin = new Padding(3, 4, 3, 4);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(731, 480);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.TabIndex = 1;
            pictureBox.TabStop = false;
            pictureBox.SizeChanged += pictureBox_SizeChanged;
            pictureBox.Click += pictureBox_Click;
            // 
            // buttonCrop
            // 
            buttonCrop.Enabled = false;
            buttonCrop.Location = new Point(409, 252);
            buttonCrop.Margin = new Padding(3, 4, 3, 4);
            buttonCrop.Name = "buttonCrop";
            buttonCrop.Size = new Size(90, 31);
            buttonCrop.TabIndex = 2;
            buttonCrop.Text = "Crop";
            buttonCrop.UseVisualStyleBackColor = true;
            buttonCrop.Click += buttonCrop_Click;
            // 
            // textBoxFile
            // 
            textBoxFile.Location = new Point(14, 16);
            textBoxFile.Margin = new Padding(3, 4, 3, 4);
            textBoxFile.Name = "textBoxFile";
            textBoxFile.Size = new Size(410, 27);
            textBoxFile.TabIndex = 3;
            textBoxFile.Text = "Enter path to image or browse";
            // 
            // buttonSave
            // 
            buttonSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonSave.Location = new Point(506, 504);
            buttonSave.Margin = new Padding(3, 4, 3, 4);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(86, 31);
            buttonSave.TabIndex = 4;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonClose
            // 
            buttonClose.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonClose.Location = new Point(1152, 504);
            buttonClose.Margin = new Padding(3, 4, 3, 4);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(86, 31);
            buttonClose.TabIndex = 5;
            buttonClose.Text = "Close";
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // radioButtonAudio
            // 
            radioButtonAudio.AutoSize = true;
            radioButtonAudio.Location = new Point(177, 17);
            radioButtonAudio.Margin = new Padding(3, 4, 3, 4);
            radioButtonAudio.Name = "radioButtonAudio";
            radioButtonAudio.Size = new Size(70, 24);
            radioButtonAudio.TabIndex = 7;
            radioButtonAudio.Text = "Audio";
            radioButtonAudio.UseVisualStyleBackColor = true;
            // 
            // radioButtonVideo
            // 
            radioButtonVideo.AutoSize = true;
            radioButtonVideo.Checked = true;
            radioButtonVideo.Location = new Point(299, 17);
            radioButtonVideo.Margin = new Padding(3, 4, 3, 4);
            radioButtonVideo.Name = "radioButtonVideo";
            radioButtonVideo.Size = new Size(69, 24);
            radioButtonVideo.TabIndex = 8;
            radioButtonVideo.TabStop = true;
            radioButtonVideo.Text = "Video";
            radioButtonVideo.UseVisualStyleBackColor = true;
            // 
            // groupBoxMediaType
            // 
            groupBoxMediaType.Controls.Add(radioButtonAudio);
            groupBoxMediaType.Controls.Add(radioButtonVideo);
            groupBoxMediaType.Location = new Point(14, 55);
            groupBoxMediaType.Margin = new Padding(3, 4, 3, 4);
            groupBoxMediaType.Name = "groupBoxMediaType";
            groupBoxMediaType.Padding = new Padding(3, 4, 3, 4);
            groupBoxMediaType.Size = new Size(487, 52);
            groupBoxMediaType.TabIndex = 9;
            groupBoxMediaType.TabStop = false;
            groupBoxMediaType.Text = "Select Media Type:";
            // 
            // groupBoxQuality
            // 
            groupBoxQuality.Controls.Add(labelQuality);
            groupBoxQuality.Controls.Add(radioButtonDefault);
            groupBoxQuality.Controls.Add(radioButtonManual);
            groupBoxQuality.Location = new Point(14, 115);
            groupBoxQuality.Margin = new Padding(3, 4, 3, 4);
            groupBoxQuality.Name = "groupBoxQuality";
            groupBoxQuality.Padding = new Padding(3, 4, 3, 4);
            groupBoxQuality.Size = new Size(487, 61);
            groupBoxQuality.TabIndex = 10;
            groupBoxQuality.TabStop = false;
            groupBoxQuality.Text = "Set Quality Level At Saving";
            // 
            // labelQuality
            // 
            labelQuality.AutoSize = true;
            labelQuality.Enabled = false;
            labelQuality.Location = new Point(10, 36);
            labelQuality.Name = "labelQuality";
            labelQuality.Size = new Size(0, 20);
            labelQuality.TabIndex = 2;
            // 
            // radioButtonDefault
            // 
            radioButtonDefault.AutoSize = true;
            radioButtonDefault.Checked = true;
            radioButtonDefault.Location = new Point(299, 21);
            radioButtonDefault.Margin = new Padding(3, 4, 3, 4);
            radioButtonDefault.Name = "radioButtonDefault";
            radioButtonDefault.Size = new Size(79, 24);
            radioButtonDefault.TabIndex = 1;
            radioButtonDefault.TabStop = true;
            radioButtonDefault.Text = "Default";
            radioButtonDefault.UseVisualStyleBackColor = true;
            // 
            // radioButtonManual
            // 
            radioButtonManual.AutoSize = true;
            radioButtonManual.Location = new Point(177, 21);
            radioButtonManual.Margin = new Padding(3, 4, 3, 4);
            radioButtonManual.Name = "radioButtonManual";
            radioButtonManual.Size = new Size(79, 24);
            radioButtonManual.TabIndex = 0;
            radioButtonManual.Text = "Manual";
            radioButtonManual.UseVisualStyleBackColor = true;
            radioButtonManual.CheckedChanged += radioButtonManual_CheckedChanged;
            // 
            // trackBarQuality
            // 
            trackBarQuality.Enabled = false;
            trackBarQuality.Location = new Point(14, 184);
            trackBarQuality.Margin = new Padding(3, 4, 3, 4);
            trackBarQuality.Maximum = 100;
            trackBarQuality.Name = "trackBarQuality";
            trackBarQuality.Size = new Size(487, 56);
            trackBarQuality.TabIndex = 11;
            trackBarQuality.TickFrequency = 5;
            trackBarQuality.TickStyle = TickStyle.TopLeft;
            trackBarQuality.Value = 75;
            trackBarQuality.Scroll += trackBarQuality_Scroll;
            // 
            // AppMenu
            // 
            AcceptButton = buttonCrop;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = buttonClose;
            ClientSize = new Size(1251, 551);
            Controls.Add(trackBarQuality);
            Controls.Add(groupBoxQuality);
            Controls.Add(groupBoxMediaType);
            Controls.Add(buttonClose);
            Controls.Add(buttonSave);
            Controls.Add(textBoxFile);
            Controls.Add(buttonCrop);
            Controls.Add(pictureBox);
            Controls.Add(buttonBrowse);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AppMenu";
            Text = "AppMenu";
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            groupBoxMediaType.ResumeLayout(false);
            groupBoxMediaType.PerformLayout();
            groupBoxQuality.ResumeLayout(false);
            groupBoxQuality.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBarQuality).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonBrowse;
        private OpenFileDialog openFileDialog1;
        private PictureBox pictureBox;
        private Button buttonCrop;
        private TextBox textBoxFile;
        private Button buttonSave;
        private Button buttonClose;
        private RadioButton radioButtonAudio;
        private RadioButton radioButtonVideo;
        private GroupBox groupBoxMediaType;
        private GroupBox groupBoxQuality;
        private RadioButton radioButtonManual;
        private RadioButton radioButtonDefault;
        private TrackBar trackBarQuality;
        private Label labelQuality;
    }
}
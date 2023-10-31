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
            buttonBrowse.Location = new Point(384, 12);
            buttonBrowse.Name = "buttonBrowse";
            buttonBrowse.Size = new Size(54, 23);
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
            pictureBox.Location = new Point(443, 12);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(640, 360);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.TabIndex = 1;
            pictureBox.TabStop = false;
            // 
            // buttonCrop
            // 
            buttonCrop.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCrop.Location = new Point(443, 378);
            buttonCrop.Name = "buttonCrop";
            buttonCrop.Size = new Size(124, 23);
            buttonCrop.TabIndex = 2;
            buttonCrop.Text = "Crop";
            buttonCrop.UseVisualStyleBackColor = true;
            buttonCrop.Click += buttonCrop_Click;
            // 
            // textBoxFile
            // 
            textBoxFile.Location = new Point(12, 12);
            textBoxFile.Name = "textBoxFile";
            textBoxFile.Size = new Size(366, 23);
            textBoxFile.TabIndex = 3;
            textBoxFile.Text = "Enter path to image or browse";
            // 
            // buttonSave
            // 
            buttonSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonSave.Location = new Point(731, 378);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(75, 23);
            buttonSave.TabIndex = 4;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonClose
            // 
            buttonClose.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonClose.Location = new Point(1008, 378);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(75, 23);
            buttonClose.TabIndex = 5;
            buttonClose.Text = "Close";
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // radioButtonAudio
            // 
            radioButtonAudio.AutoSize = true;
            radioButtonAudio.Location = new Point(155, 13);
            radioButtonAudio.Name = "radioButtonAudio";
            radioButtonAudio.Size = new Size(57, 19);
            radioButtonAudio.TabIndex = 7;
            radioButtonAudio.Text = "Audio";
            radioButtonAudio.UseVisualStyleBackColor = true;
            // 
            // radioButtonVideo
            // 
            radioButtonVideo.AutoSize = true;
            radioButtonVideo.Checked = true;
            radioButtonVideo.Location = new Point(262, 13);
            radioButtonVideo.Name = "radioButtonVideo";
            radioButtonVideo.Size = new Size(55, 19);
            radioButtonVideo.TabIndex = 8;
            radioButtonVideo.TabStop = true;
            radioButtonVideo.Text = "Video";
            radioButtonVideo.UseVisualStyleBackColor = true;
            // 
            // groupBoxMediaType
            // 
            groupBoxMediaType.Controls.Add(radioButtonAudio);
            groupBoxMediaType.Controls.Add(radioButtonVideo);
            groupBoxMediaType.Location = new Point(12, 41);
            groupBoxMediaType.Name = "groupBoxMediaType";
            groupBoxMediaType.Size = new Size(426, 39);
            groupBoxMediaType.TabIndex = 9;
            groupBoxMediaType.TabStop = false;
            groupBoxMediaType.Text = "Select Media Type:";
            // 
            // groupBoxQuality
            // 
            groupBoxQuality.Controls.Add(labelQuality);
            groupBoxQuality.Controls.Add(radioButtonDefault);
            groupBoxQuality.Controls.Add(radioButtonManual);
            groupBoxQuality.Location = new Point(12, 86);
            groupBoxQuality.Name = "groupBoxQuality";
            groupBoxQuality.Size = new Size(426, 46);
            groupBoxQuality.TabIndex = 10;
            groupBoxQuality.TabStop = false;
            groupBoxQuality.Text = "Set Quality Level At Saving";
            // 
            // labelQuality
            // 
            labelQuality.AutoSize = true;
            labelQuality.Enabled = false;
            labelQuality.Location = new Point(9, 27);
            labelQuality.Name = "labelQuality";
            labelQuality.Size = new Size(0, 15);
            labelQuality.TabIndex = 2;
            // 
            // radioButtonDefault
            // 
            radioButtonDefault.AutoSize = true;
            radioButtonDefault.Checked = true;
            radioButtonDefault.Location = new Point(262, 16);
            radioButtonDefault.Name = "radioButtonDefault";
            radioButtonDefault.Size = new Size(63, 19);
            radioButtonDefault.TabIndex = 1;
            radioButtonDefault.TabStop = true;
            radioButtonDefault.Text = "Default";
            radioButtonDefault.UseVisualStyleBackColor = true;
            // 
            // radioButtonManual
            // 
            radioButtonManual.AutoSize = true;
            radioButtonManual.Location = new Point(155, 16);
            radioButtonManual.Name = "radioButtonManual";
            radioButtonManual.Size = new Size(65, 19);
            radioButtonManual.TabIndex = 0;
            radioButtonManual.Text = "Manual";
            radioButtonManual.UseVisualStyleBackColor = true;
            radioButtonManual.CheckedChanged += radioButtonManual_CheckedChanged;
            // 
            // trackBarQuality
            // 
            trackBarQuality.Enabled = false;
            trackBarQuality.Location = new Point(12, 138);
            trackBarQuality.Maximum = 100;
            trackBarQuality.Name = "trackBarQuality";
            trackBarQuality.Size = new Size(426, 45);
            trackBarQuality.TabIndex = 11;
            trackBarQuality.Value = 75;
            trackBarQuality.Scroll += trackBarQuality_Scroll;
            // 
            // AppMenu
            // 
            AcceptButton = buttonCrop;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = buttonClose;
            ClientSize = new Size(1095, 413);
            Controls.Add(trackBarQuality);
            Controls.Add(groupBoxQuality);
            Controls.Add(groupBoxMediaType);
            Controls.Add(buttonClose);
            Controls.Add(buttonSave);
            Controls.Add(textBoxFile);
            Controls.Add(buttonCrop);
            Controls.Add(pictureBox);
            Controls.Add(buttonBrowse);
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
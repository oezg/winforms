namespace ImageCropper
{
    partial class Settings
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
            buttonChooseFile = new Button();
            openFileDialog1 = new OpenFileDialog();
            pictureBox = new PictureBox();
            buttonCropImage = new Button();
            textBox = new TextBox();
            buttonOK = new Button();
            buttonCancel = new Button();
            labelMediaType = new Label();
            radioButtonAudio = new RadioButton();
            radioButtonVideo = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // buttonChooseFile
            // 
            buttonChooseFile.Location = new Point(314, 12);
            buttonChooseFile.Name = "buttonChooseFile";
            buttonChooseFile.Size = new Size(124, 23);
            buttonChooseFile.TabIndex = 0;
            buttonChooseFile.Text = "Choose File";
            buttonChooseFile.UseVisualStyleBackColor = true;
            buttonChooseFile.Click += buttonChooseFile_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox
            // 
            pictureBox.Location = new Point(444, 12);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(286, 302);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.TabIndex = 1;
            pictureBox.TabStop = false;
            // 
            // buttonCropImage
            // 
            buttonCropImage.Location = new Point(314, 291);
            buttonCropImage.Name = "buttonCropImage";
            buttonCropImage.Size = new Size(124, 23);
            buttonCropImage.TabIndex = 2;
            buttonCropImage.Text = "Crop Image";
            buttonCropImage.UseVisualStyleBackColor = true;
            buttonCropImage.Click += buttonCropImage_Click;
            // 
            // textBox
            // 
            textBox.Location = new Point(12, 12);
            textBox.Name = "textBox";
            textBox.Size = new Size(296, 23);
            textBox.TabIndex = 3;
            // 
            // buttonOK
            // 
            buttonOK.Location = new Point(529, 375);
            buttonOK.Name = "buttonOK";
            buttonOK.Size = new Size(75, 23);
            buttonOK.TabIndex = 4;
            buttonOK.Text = "OK";
            buttonOK.UseVisualStyleBackColor = true;
            buttonOK.Click += buttonOK_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(644, 375);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(75, 23);
            buttonCancel.TabIndex = 5;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // labelMediaType
            // 
            labelMediaType.AutoSize = true;
            labelMediaType.Location = new Point(12, 61);
            labelMediaType.Name = "labelMediaType";
            labelMediaType.Size = new Size(104, 15);
            labelMediaType.TabIndex = 6;
            labelMediaType.Text = "Select Media Type:";
            // 
            // radioButtonAudio
            // 
            radioButtonAudio.AutoSize = true;
            radioButtonAudio.Location = new Point(122, 61);
            radioButtonAudio.Name = "radioButtonAudio";
            radioButtonAudio.Size = new Size(57, 19);
            radioButtonAudio.TabIndex = 7;
            radioButtonAudio.TabStop = true;
            radioButtonAudio.Text = "Audio";
            radioButtonAudio.UseVisualStyleBackColor = true;
            // 
            // radioButtonVideo
            // 
            radioButtonVideo.AutoSize = true;
            radioButtonVideo.Location = new Point(222, 61);
            radioButtonVideo.Name = "radioButtonVideo";
            radioButtonVideo.Size = new Size(55, 19);
            radioButtonVideo.TabIndex = 8;
            radioButtonVideo.TabStop = true;
            radioButtonVideo.Text = "Video";
            radioButtonVideo.UseVisualStyleBackColor = true;
            // 
            // Settings
            // 
            AcceptButton = buttonOK;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = buttonCancel;
            ClientSize = new Size(800, 450);
            Controls.Add(radioButtonVideo);
            Controls.Add(radioButtonAudio);
            Controls.Add(labelMediaType);
            Controls.Add(buttonCancel);
            Controls.Add(buttonOK);
            Controls.Add(textBox);
            Controls.Add(buttonCropImage);
            Controls.Add(pictureBox);
            Controls.Add(buttonChooseFile);
            Name = "Settings";
            Text = "Settings";
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonChooseFile;
        private OpenFileDialog openFileDialog1;
        private PictureBox pictureBox;
        private Button buttonCropImage;
        private TextBox textBox;
        private Button buttonOK;
        private Button buttonCancel;
        private Label labelMediaType;
        private RadioButton radioButtonAudio;
        private RadioButton radioButtonVideo;
    }
}
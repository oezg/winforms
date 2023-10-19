﻿namespace ImageCropper
{
    partial class FileChooser
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
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // buttonChooseFile
            // 
            buttonChooseFile.Location = new Point(247, 144);
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
            buttonCropImage.Location = new Point(247, 188);
            buttonCropImage.Name = "buttonCropImage";
            buttonCropImage.Size = new Size(124, 23);
            buttonCropImage.TabIndex = 2;
            buttonCropImage.Text = "Crop Image";
            buttonCropImage.UseVisualStyleBackColor = true;
            buttonCropImage.Click += buttonCropImage_Click;
            // 
            // textBox
            // 
            textBox.Location = new Point(27, 144);
            textBox.Name = "textBox";
            textBox.Size = new Size(203, 23);
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
            // FileChooser
            // 
            AcceptButton = buttonOK;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = buttonCancel;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonCancel);
            Controls.Add(buttonOK);
            Controls.Add(textBox);
            Controls.Add(buttonCropImage);
            Controls.Add(pictureBox);
            Controls.Add(buttonChooseFile);
            Name = "FileChooser";
            Text = "File Chooser";
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
    }
}
namespace ImageCropper
{
    partial class ImageCropper
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox = new PictureBox();
            buttonOK = new Button();
            buttonCancel = new Button();
            trackBar = new TrackBar();
            labelFactor = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar).BeginInit();
            SuspendLayout();
            // 
            // pictureBox
            // 
            pictureBox.Location = new Point(12, 12);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(672, 459);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.TabIndex = 0;
            pictureBox.TabStop = false;
            pictureBox.Paint += pictureBox_Paint;
            pictureBox.MouseDown += pictureBox_MouseDown;
            pictureBox.MouseMove += pictureBox_MouseMove;
            pictureBox.MouseUp += pictureBox_MouseUp;
            // 
            // buttonOK
            // 
            buttonOK.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonOK.Location = new Point(468, 499);
            buttonOK.Name = "buttonOK";
            buttonOK.Size = new Size(105, 23);
            buttonOK.TabIndex = 2;
            buttonOK.Text = "OK";
            buttonOK.UseVisualStyleBackColor = true;
            buttonOK.Click += buttonOK_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.Location = new Point(579, 499);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(105, 23);
            buttonCancel.TabIndex = 3;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // trackBar
            // 
            trackBar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            trackBar.Location = new Point(12, 477);
            trackBar.Maximum = 100;
            trackBar.Minimum = 20;
            trackBar.Name = "trackBar";
            trackBar.Size = new Size(368, 45);
            trackBar.TabIndex = 4;
            trackBar.TickFrequency = 5;
            trackBar.TickStyle = TickStyle.TopLeft;
            trackBar.Value = 80;
            trackBar.Scroll += trackBar_Scroll;
            // 
            // labelFactor
            // 
            labelFactor.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            labelFactor.AutoSize = true;
            labelFactor.Location = new Point(386, 477);
            labelFactor.Name = "labelFactor";
            labelFactor.Size = new Size(48, 45);
            labelFactor.TabIndex = 5;
            labelFactor.Text = "Minim: \r\nFactor: \r\nMaxim:";
            // 
            // ImageCropper
            // 
            AcceptButton = buttonOK;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = buttonCancel;
            ClientSize = new Size(696, 534);
            Controls.Add(labelFactor);
            Controls.Add(trackBar);
            Controls.Add(buttonCancel);
            Controls.Add(buttonOK);
            Controls.Add(pictureBox);
            Name = "ImageCropper";
            Text = "ImageCropper";
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox;
        private Button buttonOK;
        private Button buttonCancel;
        private TrackBar trackBar;
        private Label labelFactor;
    }
}
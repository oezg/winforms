namespace ImageCropper
{
    public partial class FileChooser : Form
    {
        public FileChooser()
        {
            InitializeComponent();

        }

        private void buttonChooseFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox.Text = openFileDialog1.FileName;
                Image image = Image.FromFile(textBox.Text);
                pictureBox.Height = pictureBox.Width * image.Height / image.Width;
                pictureBox.Image = image;
            }
        }



        private void buttonCropImage_Click(object sender, EventArgs e)
        {
            ImageCropper imageCropper = new ImageCropper(pictureBox.Image);
            if (imageCropper.ShowDialog() == DialogResult.OK)
            {
                pictureBox.Image = imageCropper.CroppedImage;
                string croppedFilename = "cropped_" + Path.GetFileName(textBox.Text);
                croppedFilename = @"C:\Users\b45089\Pictures\Testbilder\Output\" + croppedFilename;
                pictureBox.Image.Save(croppedFilename);
            }
        }


        private void buttonOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
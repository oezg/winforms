using System.Drawing.Imaging;

namespace ImageCropper
{
    public partial class Settings : Form
    {
        public Settings()
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
                //pictureBox.Image.Save(croppedFilename, ImageFormat.Jpeg);


                Encoder myEncoder = Encoder.Quality;

                ImageCodecInfo jpgEncoder = GetEncoder(ImageFormat.Jpeg);


                EncoderParameters myEncoderParameters = new EncoderParameters(1);

                var myEncoderParameter = new EncoderParameter(myEncoder, 100L);
                myEncoderParameters.Param[0] = myEncoderParameter;
                pictureBox.Image.Save(croppedFilename, jpgEncoder, myEncoderParameters);
            }
        }

        private ImageCodecInfo GetEncoder(ImageFormat format)
        {
            ImageCodecInfo[] codecs = ImageCodecInfo.GetImageEncoders();
            foreach (ImageCodecInfo codec in codecs)
            {
                if (codec.FormatID == format.Guid)
                {
                    return codec;
                }
            }
            return null;
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
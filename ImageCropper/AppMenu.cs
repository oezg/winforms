using System.Drawing.Imaging;

namespace ImageCropper
{
    public partial class AppMenu : Form
    {
        private static readonly ArdAspectRatio s_ardAspectRatioAudio;
        private static readonly ArdAspectRatio s_ardAspectRatioVideo;

        private readonly ArdAspectRatio _selectedArdAspectRatio;

        static AppMenu()
        {
            s_ardAspectRatioAudio = new ArdAspectRatio(MediaType.Audio);
            s_ardAspectRatioVideo = new ArdAspectRatio(MediaType.Video);
        }

        public AppMenu()
        {
            InitializeComponent();
            _selectedArdAspectRatio = radioButtonAudio.Checked
                ? s_ardAspectRatioAudio
                : s_ardAspectRatioVideo;
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBoxFile.Text = openFileDialog1.FileName;
                Image image = Image.FromFile(textBoxFile.Text);
                pictureBox.Height = pictureBox.Width * image.Height / image.Width;
                pictureBox.Image = image;
                adjustPictureBoxSize(image.Size);
                updateButtonCrop(image.Size);
            }
        }

        private void updateButtonCrop(Size size)
            => buttonCrop.Enabled = !(size < _selectedArdAspectRatio);

        private void adjustPictureBoxSize(Size size)
            => pictureBox.Height = pictureBox.Width * size.Height / size.Width;

        private void buttonCrop_Click(object sender, EventArgs e)
        {
            ImageCropper imageCropper = new(pictureBox.Image, _selectedArdAspectRatio);

            if (imageCropper.ShowDialog() == DialogResult.OK)
            {
                pictureBox.Image = imageCropper.CroppedImage;
                pictureBox.Size = imageCropper.CropRectangle.Size;
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
            => Close();

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string croppedFilename = getCroppedFilename();

            if (radioButtonDefault.Checked)
            {
                pictureBox.Image.Save(croppedFilename, ImageFormat.Jpeg);

            }

            else
            {
                using EncoderParameters myEncoderParameters = new(1);

                myEncoderParameters.Param[0] = new EncoderParameter(Encoder.Quality, trackBarQuality.Value);

                var jpgEncoder = ImageCodecInfo.GetImageEncoders().First(codec => codec.FormatID == ImageFormat.Jpeg.Guid);

                pictureBox.Image.Save(croppedFilename, jpgEncoder, myEncoderParameters);
            }
        }

        private string getCroppedFilename()
            => Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.UserProfile),
                "Pictures", "ImageCropper", "Cropped",
                $"X{(trackBarQuality.Enabled ? trackBarQuality.Value : "Def")}_{Path.GetFileName(textBoxFile.Text)}");

        private void radioButtonManual_CheckedChanged(object sender, EventArgs e)
        {
            trackBarQuality.Enabled = radioButtonManual.Checked;
            labelQuality.Enabled = radioButtonManual.Checked;
            updateLabelQualityText();
        }

        private void updateLabelQualityText()
            => labelQuality.Text = labelQuality.Enabled ? $"Quality Level: {trackBarQuality.Value}" : string.Empty;

        private void trackBarQuality_Scroll(object sender, EventArgs e)
            => updateLabelQualityText();

        private void pictureBox_SizeChanged(object sender, EventArgs e)
        {
            Height = pictureBox.Bottom + 100;
            Width = pictureBox.Right + 30;
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            if (buttonCrop.Enabled)
            {
                buttonCrop_Click(sender, e);
            }
        }
    }
}
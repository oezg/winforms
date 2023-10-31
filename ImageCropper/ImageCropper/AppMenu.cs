using System.Drawing.Imaging;
using System.Linq;
using static System.Windows.Forms.DataFormats;

namespace ImageCropper
{
    public partial class AppMenu : Form
    {
        public AppMenu()
        {
            InitializeComponent();

        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBoxFile.Text = openFileDialog1.FileName;
                Image image = Image.FromFile(textBoxFile.Text);
                pictureBox.Height = pictureBox.Width * image.Height / image.Width;
                pictureBox.Image = image;
                adjustSizePictureBoxAndForm(image.Size);
            }
        }

        // the height of the window is changed as much as the adjustment in height to the picture box
        private void adjustSizePictureBoxAndForm(Size size)
        {
            pictureBox.Height = pictureBox.Width * size.Height / size.Width;
            this.Height = pictureBox.Bottom + 80;
        }

        private void buttonCrop_Click(object sender, EventArgs e)
        {
            ImageCropper imageCropper = new(
                pictureBox.Image,
                new ArdAspectRatio(radioButtonAudio.Checked ? MediaType.Audio : MediaType.Video));

            if (imageCropper.ShowDialog() == DialogResult.OK)
            {
                pictureBox.Image = imageCropper.CroppedImage;
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
    }
}
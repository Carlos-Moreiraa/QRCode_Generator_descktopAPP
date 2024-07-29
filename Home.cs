using QRCoder;
using System.Windows.Forms;

namespace QrCodeDesktopAPP
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            var qrCodeImage = GenerateImage(txtBoxEnterString.Text);
            ptbQrView.Image = ConvertByteToImagem(qrCodeImage);
            ptbQrView.SizeMode = PictureBoxSizeMode.AutoSize;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ptbQrView.Image = null;
            txtBoxEnterString.Text = null;
            txtBoxEnterString.Refresh();
        }

        private void bntDownload_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Png Image|*.png";
            sfd.Title = "Save an Image File";
            sfd.ShowDialog();
            if (sfd.FileName != "")
            {
                // Saves the Image via a FileStream created by the OpenFile method.
                System.IO.FileStream fs =
                    (System.IO.FileStream)sfd.OpenFile();
                this.ptbQrView.Image.Save(fs,
            System.Drawing.Imaging.ImageFormat.Png);
            }
        }
        //method generate QrCode image.
        private byte[] GenerateImage(string txt)
        {

            var qrGenerator = new QRCodeGenerator();
            var qrCodeData = qrGenerator.CreateQrCode(txt, QRCodeGenerator.ECCLevel.Q);
            var qrCode = new PngByteQRCode(qrCodeData);
            var qrCodeImage = qrCode.GetGraphic(10);
            return qrCodeImage;
        }

        //Convert byte to image for show in forms.
        private Image ConvertByteToImagem(byte[] arquivo)
        {
            try
            {
                using (MemoryStream mStream = new MemoryStream(arquivo))
                {
                    return Image.FromStream(mStream);
                }
            }
            catch (Exception ex)
            {                
                throw; 
            }
        }


    }
}

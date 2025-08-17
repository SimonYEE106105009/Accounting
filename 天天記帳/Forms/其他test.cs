using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Drawing.Imaging;


namespace 天天記帳.Forms
{
    public partial class 其他 : Form
    {
        int count = 0;

        private void button9_Click(object sender, EventArgs e)
        {
            string imgPath = "D:\\VisualStudio作業\\source\\repos\\01beb406-8aa4-4a1b-bbbb-bd7f327ccfee.jpg";
            string compressPath = "D:\\VisualStudio作業\\source\\repos\\test0706.jpg";
            using (Bitmap bmp1 = new Bitmap(imgPath))
            {
                ImageCodecInfo jpgEncoder = GetEncoder(ImageFormat.Jpeg);
                System.Drawing.Imaging.Encoder myEncoder =
                    System.Drawing.Imaging.Encoder.Quality;
                EncoderParameters myEncoderParameters = new EncoderParameters(1);
                EncoderParameter myEncoderParameter = new EncoderParameter(myEncoder, 10L);
                myEncoderParameters.Param[0] = myEncoderParameter;
                bmp1.Save(compressPath, jpgEncoder, myEncoderParameters);
            }
        }

 


        public 其他()
        {
            InitializeComponent();
        }

        private void navbar1_Load(object sender, EventArgs e)
        {
            using (Bitmap bmp1 = new Bitmap(@"D:\VisualStudio作業\source\repos\01beb406-8aa4-4a1b-bbbb-bd7f327ccfee.jpg"))
            {
                ImageCodecInfo jpgEncoder = GetEncoder(ImageFormat.Jpeg);

                // Create an Encoder object based on the GUID
                // for the Quality parameter category.
                System.Drawing.Imaging.Encoder myEncoder =
                    System.Drawing.Imaging.Encoder.Quality;

                // Create an EncoderParameters object.
                // An EncoderParameters object has an array of EncoderParameter
                // objects. In this case, there is only one
                // EncoderParameter object in the array.
                EncoderParameters myEncoderParameters = new EncoderParameters(1);
                EncoderParameter myEncoderParameter = new EncoderParameter(myEncoder, 50L);
                myEncoderParameters.Param[0] = myEncoderParameter;
                bmp1.Save(@"D:\VisualStudio作業\source\repos\test.jpg", jpgEncoder, myEncoderParameters);
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
    }
}

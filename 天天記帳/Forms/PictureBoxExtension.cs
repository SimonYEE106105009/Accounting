using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace 天天記帳.Forms
{
    class PictureBoxExtension
    {
        public Bitmap Compress(string pictureadress)
        {
            Bitmap bmp1 = new Bitmap(pictureadress);
            ImageCodecInfo jpgEncoder = GetEncoder(ImageFormat.Jpeg);
            System.Drawing.Imaging.Encoder myEncoder =
                System.Drawing.Imaging.Encoder.Quality;
            EncoderParameters myEncoderParameters = new EncoderParameters(1);
            EncoderParameter myEncoderParameter = new EncoderParameter(myEncoder, 50L);
            myEncoderParameters.Param[0] = myEncoderParameter;
            MemoryStream ms = new MemoryStream();
            bmp1.Save(ms, jpgEncoder, myEncoderParameters);
            byte[] result = ms.ToArray();
            ms.Dispose();
            //return result;
            //Bitmap bmp1 = new Bitmap(pictureadress);
            //ImageCodecInfo jpgEncoder = GetEncoder(ImageFormat.Jpeg);

            //System.Drawing.Imaging.Encoder myEncoder = System.Drawing.Imaging.Encoder.Quality;
            //EncoderParameters myEncoderParameters = new EncoderParameters(1);
            //EncoderParameter myEncoderParameter = new EncoderParameter(myEncoder, 50L); // 壓縮品質
            //myEncoderParameters.Param[0] = myEncoderParameter;

            //using (MemoryStream ms = new MemoryStream())
            //{
            //    bmp1.Save(ms, jpgEncoder, myEncoderParameters); // 儲存壓縮後內容到記憶體
            //    ms.Position = 0; // 回到開頭，準備讀取
            //    Bitmap compressMap = new Bitmap(ms);
            //    bmp1.Dispose(); 
            //    // 回傳新的 Bitmap（已經壓縮）
            //    return compressMap;
            //}
            //Bitmap resizedImage = new Bitmap(newWidth, newHeight);

            //using (Graphics g = Graphics.FromImage(resizedImage))
            //{
            //    g.DrawImage(pictureadress, 0, 0, 40,40);
            //}

            return null;
        }
        
    private ImageCodecInfo GetEncoder(ImageFormat format)
        {
            return ImageCodecInfo.GetImageDecoders()
                .FirstOrDefault(codec => codec.FormatID == format.Guid);
        }
        //private ImageCodecInfo GetEncoder(ImageFormat format)
        //{
        //    ImageCodecInfo[] codecs = ImageCodecInfo.GetImageEncoders();
        //    foreach (ImageCodecInfo codec in codecs)
        //    {
        //        if (codec.FormatID == format.Guid)
        //        {
        //            return codec;
        //        }
        //    }
        //    return null;
        //}
    }
}

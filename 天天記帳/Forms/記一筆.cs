using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSV_Library;
using 天天記帳.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace 天天記帳.Forms
{
    public partial class 記一筆 : Form
    {
        string picture1reload;
        public 記一筆()
        {
            InitializeComponent();
        }
        string imagename1;
        string imagename2;
        private void navbar1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void 記一筆_Load(object sender, EventArgs e)
        {
            Type_comboBox.DataSource = DataModel.list;
            pictureBox1.Image = Image.FromFile("D:\\VisualStudio作業\\source\\repos\\天天記帳\\天天記帳\\上傳用icon.png");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox2.Image = Image.FromFile("D:\\VisualStudio作業\\source\\repos\\天天記帳\\天天記帳\\上傳用icon.png");
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void Type_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            Purpose_comboBox.DataSource = DataModel.keyValuePairs[Type_comboBox.Text];
            Store_comboBox.DataSource = DataModel.keyValueStore[Type_comboBox.Text];
            Object_comboBox.DataSource = DataModel.keyValueObject[Type_comboBox.Text];

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DebounceTime((data) =>
            {

                string date = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                CSV csv = new CSV();
                Guid guid1 = Guid.NewGuid();
                Guid guid2 = Guid.NewGuid();
                string picture1 = "D:\\VisualStudio作業\\source\\repos\\天天記帳\\天天記帳\\記帳資料\\" + date + "\\40x40_" + guid1 + ".jpg";
                string picture2 = "D:\\VisualStudio作業\\source\\repos\\天天記帳\\天天記帳\\記帳資料\\" + date + "\\40x40_" + guid2 + ".jpg";

                RecordModel recordModel = new RecordModel(date, Number_textBox.Text, Type_comboBox.Text, Purpose_comboBox.Text, Object_comboBox.Text,
                  Store_comboBox.Text, picture1, picture2, Remark_textBox.Text);
                csv.Writer("D:\\VisualStudio作業\\source\\repos\\天天記帳\\天天記帳\\記帳資料\\" + date + "\\data.csv", recordModel);

                Bitmap resizedImage = new Bitmap(40, 40);
                Graphics g = Graphics.FromImage(resizedImage);
                g.DrawImage(pictureBox1.Image, 0, 0, 40, 40);
                resizedImage.Save(picture1, ImageFormat.Jpeg);

                Bitmap resizedImage2 = new Bitmap(40, 40);
                Graphics g2 = Graphics.FromImage(resizedImage2);
                g2.DrawImage(pictureBox2.Image, 0, 0, 40, 40);
                resizedImage2.Save(picture2, ImageFormat.Jpeg);

                ImageCodecInfo jpgEncoder = GetEncoder(ImageFormat.Jpeg);
                System.Drawing.Imaging.Encoder myEncoder =
                    System.Drawing.Imaging.Encoder.Quality;
                EncoderParameters myEncoderParameters = new EncoderParameters(1);
                EncoderParameter myEncoderParameter = new EncoderParameter(myEncoder, 10L);
                myEncoderParameters.Param[0] = myEncoderParameter;
                string press1 = "D:\\VisualStudio作業\\source\\repos\\天天記帳\\天天記帳\\記帳資料\\" + date + "\\" + guid1 + ".jpg";
                string press2 = "D:\\VisualStudio作業\\source\\repos\\天天記帳\\天天記帳\\記帳資料\\" + date + "\\" + guid2 + ".jpg";
                pictureBox1.Image.Save(press1, jpgEncoder, myEncoderParameters);
                pictureBox2.Image.Save(press2, jpgEncoder, myEncoderParameters);
                
                //pictureBox1.Image.Save(picture1);
                //pictureBox2.Image.Save(picture2);
            }, 400);
            //using (Bitmap bmp1 = new Bitmap(picture1reload))
            //{
            //    ImageCodecInfo jpgEncoder = GetEncoder(ImageFormat.Jpeg);

            //    // Create an Encoder object based on the GUID
            //    // for the Quality parameter category.
            //    System.Drawing.Imaging.Encoder myEncoder =
            //        System.Drawing.Imaging.Encoder.Quality;

            //    // Create an EncoderParameters object.
            //    // An EncoderParameters object has an array of EncoderParameter
            //    // objects. In this case, there is only one
            //    // EncoderParameter object in the array.
            //    EncoderParameters myEncoderParameters = new EncoderParameters(1);
            //    EncoderParameter myEncoderParameter = new EncoderParameter(myEncoder, 50L);
            //    myEncoderParameters.Param[0] = myEncoderParameter;
            //    bmp1.Save(@"D:\VisualStudio作業\source\repos\test.jpg", jpgEncoder, myEncoderParameters);
            //    //Bitmap originalImage = new Bitmap("D:\\VisualStudio作業\\source\\repos\\3dd4ca8b-2025-4086-aace-f778bb4ae5f8.jpg");
            //}

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

        //this.DebounceTime((data) => ;


        private void Number_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Purpose_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Object_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Store_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Remark_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamReader reader = new StreamReader("data.csv");
            List<RecordModel> models = new List<RecordModel>();
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                string[] data = line.Split(',');
                RecordModel model = new RecordModel(data[0], data[1], data[2], data[3], data[4], data[5], data[6], data[7], data[8]);
                models.Add(model);
            }
            foreach (var model in models)
            {
                Console.WriteLine(model.Number);
            }
        }

        private void UploadImage_Click(object sender, EventArgs e)
        {

        }

        private void UploadImage_Click1(object sender, EventArgs e)
        {

            PictureBox pictureBox = (PictureBox)sender;
            //pictureBox.Image.Dispose();
            //pictureBox.Image = null;

            //GC.Collect();
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "圖片檔|*.jpg;*.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Console.WriteLine(openFileDialog.FileName);
                imagename1 = openFileDialog.FileName;
                //PictureBoxExtension pictureBoxExtension = new PictureBoxExtension();
                //pictureBox.Image = pictureBoxExtension.Compress(imagename1);
                pictureBox.Image = Image.FromFile(openFileDialog.FileName);
            }
        }

        private void UploadImage_Click2(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            pictureBox.Image.Dispose();
            pictureBox.Image = null;
            GC.Collect();
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "圖片檔|*.jpg;*.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Console.WriteLine(openFileDialog.FileName);
                imagename2 = openFileDialog.FileName;
                pictureBox.Image = Image.FromFile(openFileDialog.FileName);
            }
        }

    }
}

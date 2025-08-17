using System.Drawing.Imaging;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace 天天記帳.Forms
{
    partial class 其他
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
            return null;
        }

        public void CompressForty(PictureBox pictureBox1)
        {
            Bitmap resizedImage = new Bitmap(40, 40);
            Graphics g = Graphics.FromImage(resizedImage);

            g.DrawImage(pictureBox1.Image, 0, 0, 40, 40);

            resizedImage.Save("D:\\VisualStudio作業\\source\\repos\\compress picture\\picture.jpg", ImageFormat.Jpeg);
        }
        #region Windows Form Designer generated code

            /// <summary>
            /// Required method for Designer support - do not modify
            /// the contents of this method with the code editor.
            /// </summary>
        private void InitializeComponent()
        {
            this.navbar1 = new 天天記帳.Components.Navbar();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // navbar1
            // 
            this.navbar1.Location = new System.Drawing.Point(187, 352);
            this.navbar1.Name = "navbar1";
            this.navbar1.Size = new System.Drawing.Size(466, 64);
            this.navbar1.TabIndex = 0;
            this.navbar1.Load += new System.EventHandler(this.navbar1_Load);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(593, 283);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button9";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button9_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(620, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.button9_Click);
            // 
            // 其他
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.navbar1);
            this.Name = "其他";
            this.Text = "其他";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Components.Navbar navbar1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}
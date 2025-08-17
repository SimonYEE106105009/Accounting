namespace 天天記帳.Forms
{
    partial class 記一筆
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Number_textBox = new System.Windows.Forms.TextBox();
            this.Purpose_comboBox = new System.Windows.Forms.ComboBox();
            this.Type_comboBox = new System.Windows.Forms.ComboBox();
            this.Object_comboBox = new System.Windows.Forms.ComboBox();
            this.Store_comboBox = new System.Windows.Forms.ComboBox();
            this.Remark_textBox = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.navbar1 = new 天天記帳.Components.Navbar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "日期";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "消費金額";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "消費類型";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "消費對象";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 5;
            this.label5.Text = "消費店家";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(521, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 6;
            this.label6.Text = "收據";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 7;
            this.label7.Text = "消費目的";
            // 
            // Number_textBox
            // 
            this.Number_textBox.Location = new System.Drawing.Point(71, 82);
            this.Number_textBox.Name = "Number_textBox";
            this.Number_textBox.Size = new System.Drawing.Size(123, 22);
            this.Number_textBox.TabIndex = 8;
            this.Number_textBox.TextChanged += new System.EventHandler(this.Number_textBox_TextChanged);
            // 
            // Purpose_comboBox
            // 
            this.Purpose_comboBox.FormattingEnabled = true;
            this.Purpose_comboBox.Location = new System.Drawing.Point(71, 168);
            this.Purpose_comboBox.Name = "Purpose_comboBox";
            this.Purpose_comboBox.Size = new System.Drawing.Size(123, 20);
            this.Purpose_comboBox.TabIndex = 9;
            this.Purpose_comboBox.SelectedIndexChanged += new System.EventHandler(this.Purpose_comboBox_SelectedIndexChanged);
            // 
            // Type_comboBox
            // 
            this.Type_comboBox.FormattingEnabled = true;
            this.Type_comboBox.Location = new System.Drawing.Point(71, 123);
            this.Type_comboBox.Name = "Type_comboBox";
            this.Type_comboBox.Size = new System.Drawing.Size(123, 20);
            this.Type_comboBox.TabIndex = 10;
            this.Type_comboBox.SelectedIndexChanged += new System.EventHandler(this.Type_comboBox_SelectedIndexChanged);
            // 
            // Object_comboBox
            // 
            this.Object_comboBox.FormattingEnabled = true;
            this.Object_comboBox.Location = new System.Drawing.Point(71, 214);
            this.Object_comboBox.Name = "Object_comboBox";
            this.Object_comboBox.Size = new System.Drawing.Size(123, 20);
            this.Object_comboBox.TabIndex = 11;
            this.Object_comboBox.SelectedIndexChanged += new System.EventHandler(this.Object_comboBox_SelectedIndexChanged);
            // 
            // Store_comboBox
            // 
            this.Store_comboBox.FormattingEnabled = true;
            this.Store_comboBox.Location = new System.Drawing.Point(71, 261);
            this.Store_comboBox.Name = "Store_comboBox";
            this.Store_comboBox.Size = new System.Drawing.Size(123, 20);
            this.Store_comboBox.TabIndex = 12;
            this.Store_comboBox.SelectedIndexChanged += new System.EventHandler(this.Store_comboBox_SelectedIndexChanged);
            // 
            // Remark_textBox
            // 
            this.Remark_textBox.Location = new System.Drawing.Point(71, 309);
            this.Remark_textBox.Name = "Remark_textBox";
            this.Remark_textBox.Size = new System.Drawing.Size(123, 22);
            this.Remark_textBox.TabIndex = 13;
            this.Remark_textBox.TextChanged += new System.EventHandler(this.Remark_textBox_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(71, 26);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(123, 22);
            this.dateTimePicker1.TabIndex = 14;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(26, 337);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(119, 337);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "Read";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(243, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(235, 310);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.UploadImage_Click1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(523, 26);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(235, 310);
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.UploadImage_Click2);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(241, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 6;
            this.label8.Text = "收據";
            // 
            // navbar1
            // 
            this.navbar1.Location = new System.Drawing.Point(219, 374);
            this.navbar1.Name = "navbar1";
            this.navbar1.Size = new System.Drawing.Size(466, 64);
            this.navbar1.TabIndex = 0;
            this.navbar1.Load += new System.EventHandler(this.navbar1_Load);
            // 
            // 記一筆
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Remark_textBox);
            this.Controls.Add(this.Store_comboBox);
            this.Controls.Add(this.Object_comboBox);
            this.Controls.Add(this.Type_comboBox);
            this.Controls.Add(this.Purpose_comboBox);
            this.Controls.Add(this.Number_textBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.navbar1);
            this.Name = "記一筆";
            this.Text = "記一筆";
            this.Load += new System.EventHandler(this.記一筆_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Components.Navbar navbar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Number_textBox;
        private System.Windows.Forms.ComboBox Purpose_comboBox;
        private System.Windows.Forms.ComboBox Type_comboBox;
        private System.Windows.Forms.ComboBox Object_comboBox;
        private System.Windows.Forms.ComboBox Store_comboBox;
        private System.Windows.Forms.TextBox Remark_textBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label8;
    }
}
namespace 天天記帳.Forms
{
    partial class 記帳本
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
            this.navbar1 = new 天天記帳.Components.Navbar();
            this.SuspendLayout();
            // 
            // navbar1
            // 
            this.navbar1.Location = new System.Drawing.Point(158, 374);
            this.navbar1.Name = "navbar1";
            this.navbar1.Size = new System.Drawing.Size(466, 64);
            this.navbar1.TabIndex = 0;
            // 
            // 記帳本
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.navbar1);
            this.Name = "記帳本";
            this.Text = "記帳本";
            this.ResumeLayout(false);

        }

        #endregion

        private Components.Navbar navbar1;
    }
}
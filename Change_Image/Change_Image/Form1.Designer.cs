namespace Change_Image
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_ReadImage = new System.Windows.Forms.Button();
            this.button_ChageImage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(465, 352);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button_ReadImage
            // 
            this.button_ReadImage.Location = new System.Drawing.Point(12, 380);
            this.button_ReadImage.Name = "button_ReadImage";
            this.button_ReadImage.Size = new System.Drawing.Size(75, 23);
            this.button_ReadImage.TabIndex = 1;
            this.button_ReadImage.Text = "讀入影像";
            this.button_ReadImage.UseVisualStyleBackColor = true;
            this.button_ReadImage.Click += new System.EventHandler(this.button_ReadImage_Click);
            // 
            // button_ChageImage
            // 
            this.button_ChageImage.Location = new System.Drawing.Point(93, 380);
            this.button_ChageImage.Name = "button_ChageImage";
            this.button_ChageImage.Size = new System.Drawing.Size(75, 23);
            this.button_ChageImage.TabIndex = 2;
            this.button_ChageImage.Text = "改變影像";
            this.button_ChageImage.UseVisualStyleBackColor = true;
            this.button_ChageImage.Click += new System.EventHandler(this.button_ChageImage_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 438);
            this.Controls.Add(this.button_ChageImage);
            this.Controls.Add(this.button_ReadImage);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "改變影像像素";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_ReadImage;
        private System.Windows.Forms.Button button_ChageImage;
    }
}


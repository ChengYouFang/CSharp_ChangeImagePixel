using System;
using System.Drawing;
using System.Windows.Forms;

namespace Change_Image
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_ReadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "PNG|*.png";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                this.pictureBox1.Image = Image.FromFile(dialog.FileName);
            }
        }

        private void button_ChageImage_Click(object sender, EventArgs e)
        {
            if (this.pictureBox1.Image != null)
            {
                Bitmap image = new Bitmap(this.pictureBox1.Image);

                for (int width = 0; width < image.Width; width++)
                {
                    for (int heigth = 0; heigth < image.Height; heigth++)
                    {
                        Color color = image.GetPixel(width, heigth);
                        if (color.ToArgb() == Color.Black.ToArgb())
                        {
                            image.SetPixel(width, heigth, Color.White);
                        }
                        else if (color.ToArgb() == Color.White.ToArgb())
                        {
                            image.SetPixel(width, heigth, Color.Black);
                        }
                    }
                }
                this.pictureBox1.Image = image;
            }
        }
    }
}
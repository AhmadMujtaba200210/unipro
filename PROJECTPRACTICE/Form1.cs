using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Emgu;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;


namespace PROJECTPRACTICE
{
    public partial class Form1 : Form
    {
      
            int x = 50;
            int y = 170;
      
        public string imgname = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void image_load_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog emf = new OpenFileDialog();
            try
            {
                if (emf.ShowDialog() == DialogResult.OK)
                {
                    imgname = emf.FileName;
                    Image<Bgr, byte> img = new Image<Bgr, byte>(emf.FileName);
                    imageBox1.Image = img;
                    textimage.Visible = true;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

      
        private void textimage_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            textBox1.Focus();
            textapply.Visible = true;
            Xbox.Visible = true;
            Ybox.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            imageBox2.Visible = true;
        }

        private void textapply_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                Image<Bgr, byte> image = new Image<Bgr, byte>(imgname);
                CvInvoke.PutText(image, textBox1.Text, new System.Drawing.Point(x, y), FontFace.HersheySimplex, 2.0, new MCvScalar(0, 0, 255), 8);
                imageBox2.Image = image;
                CvInvoke.WaitKey();
                image.Dispose();
                //cordinates
                 x = Int32.Parse(Xbox.Text);
                 y = Int32.Parse(Ybox.Text);
            }
            else
            {
                MessageBox.Show("Please fill the text box");
                textBox1.Focus();
            }
        }

        private void imageBox2_MouseClick(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

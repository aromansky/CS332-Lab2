using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS332_Lab2
{
    public partial class FormTask3 : Form
    {
        public MyImage originalImage { get; set; }
        private MyImage correctedlImage { get; set; }
        public FormTask3()
        {
            InitializeComponent();

            UpdateLabel();
        }

        private void FormTask3_Load(object sender, EventArgs e)
        {

        }

        private void UpdateLabel()
        {
            label.Text = $"H = {trackBarH.Value}\n" +
                $"S = {trackBarS.Value}\n" +
                $"V = {trackBarV.Value}";
        }

        public void DrawImage()
        {
            pictureBox.Image = originalImage.Img;
        }

        private void trackBar_ValueChanged(object sender, EventArgs e)
        {
            UpdateLabel();
        }

        private void createImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            correctedlImage = Task3.ApplyHSVCorrection(originalImage, trackBarH.Value, trackBarS.Value / 100.0, trackBarV.Value / 100.0);
            pictureBox.Image = correctedlImage.Img;
        }

        private void saveImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveDialog = new SaveFileDialog())
            {
                saveDialog.Filter = "JPEG Image|*.jpg|PNG Image|*.png|BMP Image|*.bmp";
                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    pictureBox.Image.Save(saveDialog.FileName);
                }
            }
        }
    }
}

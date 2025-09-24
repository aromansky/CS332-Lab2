using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static CS332_Lab2.Task2;

namespace CS332_Lab2
{
    public partial class Menu : Form
    {
        string filePath = String.Empty;
        MyImage image = null;
        FormTask1 task1 = new FormTask1();
        FormTask2 task2 = new FormTask2();
        FormTask3 task3 = new FormTask3();
        public Menu()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                this.filePath = openFileDialog1.FileName;
                LoadImage(filePath);
                pictureBox1.Image = image.Img;
            }
        }

        private void LoadImage(string path)
        {
            image = new MyImage(new Bitmap(path));
        }

        private void task1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (image == null)
            {
                return;
            }

            if (task1 == null || task1.IsDisposed)
            {
                task1 = new FormTask1();
            }

            task1.originalImage = image;
            task1.DrawImages();
            task1.Show();
        }

        private void task2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (image == null)
            {
                return;
            }

            if (task2 == null || task2.IsDisposed)
            {
                task2 = new FormTask2();
            }

            task2.Image = image;
            task2.DrawHistogram();
            task2.Show();
        }

        private void task3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (image == null)
            {
                return;
            }

            if (task3 == null || task3.IsDisposed)
            {
                task3 = new FormTask3();
            }

            task3.originalImage = image;
            task3.DrawImage();
            task3.Show();
        }
    }
}

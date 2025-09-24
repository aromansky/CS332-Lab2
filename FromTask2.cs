using System;
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
    public partial class FormTask2 : Form
    {
        public MyImage Image {get; set;}
        public FormTask2()
        {
            InitializeComponent();
        }

        public void DrawHistogram()
        {
            ClearHistogram();
            if (Image != null)
            {  
                FillHistogram(extractRGB(Image));
                pictureBoxR.Image = Task2.RImage.Img;
                pictureBoxG.Image = Task2.GImage.Img;
                pictureBoxB.Image = Task2.BImage.Img;
            }
        }

        private void ClearHistogram()
        {
            pictureBoxR.Image = null;
            pictureBoxG.Image = null;
            pictureBoxB.Image = null;

            foreach (Series series in chart.Series)
            {
                series.Points.Clear();
            }
        }

        private void FillHistogram(Dictionary<(COLOR, int), int> dict)
        {

            foreach ((COLOR, int) col in dict.Keys)
            {
                string color = string.Empty;
                switch (col.Item1)
                {
                    case COLOR.R:
                        color = "R";
                        break;
                    case COLOR.G:
                        color = "G";
                        break;
                    case COLOR.B:
                        color = "B";
                        break;
                }
                chart.Series[color].Points.AddXY(col.Item2, dict[col]);
            }
        }
    }
}

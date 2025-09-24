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
    public partial class FormTask1 : Form
    {
        public MyImage originalImage { get; set; }
        private MyImage NTSCImage { get; set; }
        private MyImage SRGBImage { get; set; }
        private MyImage DiffImage { get; set; }
        public FormTask1()
        {
            InitializeComponent();
        }

        private void FormTask1_Load(object sender, EventArgs e)
        {

        }
        public void DrawImages()
        {
            DrawNTSC();
            DrawSRGB();
            DrawDiff();

            ClearHistograms();
            FillHistograms();
        }

        private void DrawNTSC()
        {
            ntsc_box.Image = null;
            NTSCImage = Task1.ConvertToGrayscale(originalImage, Task1.Calculate_NTSC_RGB);
            ntsc_box.Image = NTSCImage.Img;
        }

        private void DrawSRGB()
        {
            srgb_box.Image = null;
            SRGBImage = Task1.ConvertToGrayscale(originalImage, Task1.Calculate_sRGB);
            srgb_box.Image = NTSCImage.Img;
        }

        private void DrawDiff()
        {
            diff_box.Image = null;
            DiffImage = Task1.DiffGrayScales(originalImage, 1);
            diff_box.Image = DiffImage.Img;
        }

        private void ClearHistograms()
        {
            foreach (Series series in chart1.Series)
            {
                series.Points.Clear();
            }

            foreach (Series series in chart2.Series)
            {
                series.Points.Clear();
            }

            foreach (Series series in chart3.Series)
            {
                series.Points.Clear();
            }
        }

        private void FillHistograms()
        {
            Dictionary<int, int> NTSCDict = Task1.extractIntensity(NTSCImage);
            foreach (int key in NTSCDict.Keys)
            {
                chart1.Series["X"].Points.AddXY(key, NTSCDict[key]);
            }

            Dictionary<int, int> SRGBDict = Task1.extractIntensity(NTSCImage);
            foreach (int key in SRGBDict.Keys)
            {
                chart2.Series["X"].Points.AddXY(key, SRGBDict[key]);
            }

            Dictionary<int, int> DiffDict = Task1.extractIntensity(DiffImage);
            foreach (int key in DiffDict.Keys)
            {
                chart3.Series["X"].Points.AddXY(key, DiffDict[key]);
            }
        }
    }
    
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CS332_Lab2.Task2;

namespace CS332_Lab2
{
    public static class Task1
    {
        public static double Calculate_NTSC_RGB((int r, int g, int b) rgb)
        {
            return 0.3 * rgb.r + 0.59 * rgb.g + 0.11 * rgb.b;
        }

        public static double Calculate_sRGB((int r, int g, int b) rgb)
        {
            return 0.21 * rgb.r + 0.72 * rgb.g + 0.07 * rgb.b;
        }

        public static MyImage ConvertToGrayscale(MyImage source, Func<(int r, int g, int b), double> formula)
        {
            MyImage result = new MyImage(new Bitmap(source.Img));
            result.Lock();

            for (int x = 0; x < result.Width; x++)
            {
                for (int y = 0; y < result.Height; y++)
                {
                    var rgb = result.GetRGB(x, y);
                    double brightness = formula(rgb);

                    int grayValue = (int)Math.Round(brightness);

                    var grayPixel = (grayValue, grayValue, grayValue);

                    result.SetPixel(x, y, grayPixel);
                }
            }

            result.Unlock();
            return result;
        }

        public static MyImage DiffGrayScales(MyImage source, int multiplier = 5)
        {
            MyImage result = new MyImage(new Bitmap(source.Img));
            result.Lock();

            for (int x = 0; x < result.Width; x++)
            {
                for (int y = 0; y < result.Height; y++)
                {
                    var rgb = result.GetRGB(x, y);
                    double brightness_1 = Calculate_NTSC_RGB(rgb) * multiplier;
                    if (brightness_1 < 0)
                    {
                        brightness_1 = 0;
                    }
                    if (brightness_1 > 255)
                    {
                        brightness_1 = 255;
                    }

                    double brightness_2 = Calculate_sRGB(rgb) * multiplier;
                    if (brightness_2 < 0)
                    {
                        brightness_2 = 0;
                    }
                    if (brightness_2 > 255)
                    {
                        brightness_2 = 255;
                    }

                    int grayValue = (int)Math.Round(Math.Abs(brightness_1 - brightness_2));

                    var grayPixel = (grayValue, grayValue, grayValue);

                    result.SetPixel(x, y, grayPixel);
                }
            }

            result.Unlock();
            return result;
        }

        public static Dictionary< int, int> extractIntensity(MyImage img)
        {
            Dictionary<int, int> res = new Dictionary<int, int>();
            img.Lock();

            for (int x = 0; x < img.Width; x++)
            {
                for (int y = 0; y < img.Height; y++)
                {
                    var (r, g, b) = img.GetRGB(x, y);
                    if (res.ContainsKey(r))
                    {
                        res[r]++;
                    }
                    else
                    {
                        res[r] = 1;
                    }
                }
            }
            img.Unlock();
            return res;
        }
    }
}

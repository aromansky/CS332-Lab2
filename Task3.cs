using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CS332_Lab2
{
    public static class Task3
    {
        private static (int h, double s, double v) ConvertRGBToHSV((int r, int g, int b)rgb)
        {
            double R = rgb.r / 255.0;
            double G = rgb.g / 255.0;
            double B = rgb.b / 255.0;

            double MAX = Math.Max(R, Math.Max(G, B));
            double MIN = Math.Min(R, Math.Min(G, B));

            // считаем h
            double h = -1;
            if (MAX == MIN)
            {
                h = 0;
            }
            else if (MAX == R)
            {
                if (G >= B)
                {
                    h = 60 * (G - B) / (MAX - MIN) + 0;
                }
                else
                {
                    h = 60 * (G - B) / (MAX - MIN) + 360;
                }
            }
            else if (MAX == G) 
            {
                h = 60 * (B - R) / (MAX - MIN) + 120;
            }
            else if (MAX == B)
            {
                h = 60 * (R - G) / (MAX - MIN) + 240;
            }

            // считаем s
            double s = -1;
            if (MAX == 0)
            {
                s = 0;
            }
            else
            {
                s = 1 - MIN / MAX;
            }

            // считаем v
            double v = MAX;

            return ((int)h, s, v);
        }

        private static (int r, int g, int b) ConvertHSVToRGB(int h, double s, double v)
        {
            h %= 360;
            s %= 100;
            v %= 100;
            double H = h;
            int Hi = h / 60 % 6;

            double f = H / 60 - Math.Floor(H/60);
            double p = v * (1 - s);
            double q = v * (1 - f * s);
            double t = v * (1 - (1 - f) * s);

            int r, g, b;

            switch (Hi)
            {
                case 0:
                    r = (int)(v * 255);     
                    g = (int)(t * 255);    
                    b = (int)(p * 255);  
                    break;
                case 1:
                    r = (int)(q * 255);  
                    g = (int)(v * 255);    
                    b = (int)(p * 255); 
                    break;
                case 2:
                    r = (int)(p * 255);  
                    g = (int)(v * 255);      
                    b = (int)(t * 255);  
                    break;
                case 3:
                    r = (int)(p * 255);    
                    g = (int)(q * 255);   
                    b = (int)(v * 255); 
                    break;
                case 4:
                    r = (int)(t * 255);    
                    g = (int)(p * 255);    
                    b = (int)(v * 255);     
                    break;
                case 5:
                    r = (int)(v * 255);       
                    g = (int)(p * 255);     
                    b = (int)(q * 255);  
                    break;
                default:
                    r = g = b = 0;
                    break;
            }


            return (r, g, b);
        }


        public static MyImage ApplyHSVCorrection(MyImage source, int H, double S, double V)
        {
            MyImage image = new MyImage(new Bitmap(source.Img));
            image.Lock();
            for (int x = 0; x < image.Width; x++)
            {
                for (int y = 0; y < image.Height; y++)
                {
                    var (h, s, v) = ConvertRGBToHSV(image.GetRGB(x, y));

                    h += H;
                    s += S;
                    v += V;

                    var rgb = ConvertHSVToRGB(h, s, v);

                    image.SetPixel(x, y, rgb);
                }
            }
            image.Unlock();
            return image;
        }
    }
}

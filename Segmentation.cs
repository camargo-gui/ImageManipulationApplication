using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;

namespace ImageManipulationApplication
{
    class Segmentation
    {
        public static void FourConected(Bitmap imageSrc, Bitmap imageDest)
        {
            int width = imageSrc.Width;
            int height = imageSrc.Height;

            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    if (!isBlack(imageSrc.GetPixel(x, y)))
                    {
                        if (checkFourConected(imageSrc, x, y))
                        {
                            imageDest.SetPixel(x, y, Color.FromArgb(255, 0, 255, 0));
                        }
                        else
                        {
                            imageDest.SetPixel(x, y, imageSrc.GetPixel(x, y));
                        }
                    }
                }
                    
            }
        }

        private static bool checkFourConected(Bitmap image, int x, int y)
        {
            bool top = (y > 0) && isBlack(image.GetPixel(x, y - 1));
            bool bottom = (y < image.Height - 1) && isBlack(image.GetPixel(x, y + 1));
            bool left = (x > 0) && isBlack(image.GetPixel(x - 1, y));
            bool right = (x < image.Width - 1) && isBlack(image.GetPixel(x + 1, y));
            return top || bottom || left || right;
        }

        public static void EightConected(Bitmap imageSrc, Bitmap imageDest)
        {
            int width = imageSrc.Width;
            int height = imageSrc.Height;

            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    if (!isBlack(imageSrc.GetPixel(x, y)))
                    {
                        if (checkEightConected(imageSrc, x, y))
                        {
                            imageDest.SetPixel(x, y, Color.FromArgb(255, 0, 255, 0));
                        }
                        else
                        {
                            imageDest.SetPixel(x, y, imageSrc.GetPixel(x, y));
                        }
                    }
                }

            }
        }

        private static bool checkEightConected(Bitmap image, int x, int y)
        {
            bool fourConected = checkFourConected(image, x, y);
            bool leftTop = (x > 0 && y > 0) && isBlack(image.GetPixel(x - 1, y - 1));
            bool rightTop = (x < image.Width - 1 && y > 0) && isBlack(image.GetPixel(x + 1, y - 1));
            bool leftBottom = (x > 0 && y < image.Height - 1) && isBlack(image.GetPixel(x - 1, y + 1));
            bool rightBottom = (x < image.Width - 1 && y < image.Height - 1) && isBlack(image.GetPixel(x + 1, y + 1));
            return fourConected | leftTop | leftBottom | rightBottom | rightTop;
        }

        private static bool isBlack(Color color)
        {
            int R, G, B;
            R = color.R;
            G = color.G;
            B = color.B;
            return R == 0 && G == 0 && B == 0;
        }
    }
}

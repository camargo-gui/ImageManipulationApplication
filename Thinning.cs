using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using static System.Net.Mime.MediaTypeNames;

namespace ImageManipulationApplication
{
    class Thinning
    {
        public static void ZhangSuen(Bitmap imageSrc)
        {
            List<Point> list = [];
            int width = imageSrc.Width, height = imageSrc.Height;
            bool continueThinning = true, subiteration = true;
            while (continueThinning)
            {
                for(int x = 1; x < width - 1; x++)
                {
                    for(int y = 1; y < height - 1; y++)
                    {
                        Color color = imageSrc.GetPixel(x, y);
                        if (PixelUtil.isBlack(color))
                        {
                            Point point = new Point(x, y);
                            bool condition1 = FirstCondition(imageSrc, point);
                            bool condition2 = SecondCondition(imageSrc, point);
                            bool condition3 = ThirdCondition(imageSrc, point, subiteration);
                            bool condition4 = FourthCondition(imageSrc, point, subiteration);

                            if (condition1 && condition2 && condition3 && condition4)
                            {
                                list.Add(new Point(x, y));
                            }
                        }

                    }
                }
                if (list.Count == 0)
                {
                    continueThinning = false;
                }
                else
                {
                    while (list.Count != 0)
                    {
                        foreach(var point in list)
                        {
                            imageSrc.SetPixel(point.X, point.Y, Color.White);
                        }
                        list.Clear();
                    }
                }
                subiteration = !subiteration;
            }
        }


        private static bool FirstCondition(Bitmap imageSrc, Point point)
        {
            int total = 0;
            Color[] pixels = PixelUtil.GetNeighbords(imageSrc, point); 
            for(int i = 0; i < pixels.Length - 1; i++)
            {
                if (PixelUtil.hasTransition(pixels[i], pixels[i + 1]))
                {
                    total += 1;
                }
            }

            if (PixelUtil.hasTransition(pixels[pixels.Length - 1], pixels[0]))
                total += 1;

            return total == 1;
        }

        private static bool SecondCondition(Bitmap imageSrc, Point point)
        {
            int total = 0;
            Color[] pixels = PixelUtil.GetNeighbords(imageSrc, point);
            foreach(var pixel in pixels)
            {
                if (PixelUtil.isBlack(pixel))
                    total += 1;

            }
            return total >= 2 && total <= 6;
        }

        private static bool ThirdCondition(Bitmap imageSrc, Point point, bool firstIteration)
        {
            int x = point.X, y = point.Y;
            int p2 = PixelUtil.isWhite(imageSrc.GetPixel(x - 1, y)) ? 1 : 0;
            int p4 =  PixelUtil.isWhite(imageSrc.GetPixel(x, y + 1)) ? 1 : 0;
            int p6 = PixelUtil.isWhite(imageSrc.GetPixel(x + 1, y)) ? 1 : 0;
            int p8 = PixelUtil.isWhite(imageSrc.GetPixel(x, y - 1)) ? 1 : 0;
            return firstIteration ? (p2 + p4 + p8) > 0 : (p2 + p4 + p6) > 0;
        }

        private static bool FourthCondition(Bitmap imageSrc, Point point, bool firstIteration)
        {
            int x = point.X, y = point.Y;
            int p2 = PixelUtil.isWhite(imageSrc.GetPixel(x - 1, y)) ? 1 : 0;
            int p4 = PixelUtil.isWhite(imageSrc.GetPixel(x, y + 1)) ? 1 : 0;
            int p6 = PixelUtil.isWhite(imageSrc.GetPixel(x + 1, y)) ? 1 : 0;
            int p8 = PixelUtil.isWhite(imageSrc.GetPixel(x, y - 1)) ? 1 : 0;
            return firstIteration ? (p2 + p6 + p8) > 0 : (p4 + p6 + p8) > 0;
        }

    }
}

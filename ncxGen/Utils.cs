using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;

namespace ncxGen
{
    static class Utils
    {
        internal static void CreateBitmapImage(string text, string savePath)
        {
            Bitmap textImage = new Bitmap(1, 1);

            int intWidth = 0;
            int intHeight = 0;

            // Create the Font object for the image text drawing.
            Font objFont = new Font("Courier New", 20, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);

            // Create a graphics object to measure the text's width and height.
            Graphics objGraphics = Graphics.FromImage(textImage);

            // This is where the bitmap size is determined.
            intWidth = (int)objGraphics.MeasureString(text, objFont).Width;
            intHeight = (int)objGraphics.MeasureString(text, objFont).Height;

            // Create the bmpImage again with the correct size for the text and font.
            textImage = new Bitmap(textImage, new Size(intWidth, intHeight));

            // Add the colors to the new bitmap.
            objGraphics = Graphics.FromImage(textImage);

            // Set Background color
            objGraphics.Clear(Color.White);
            objGraphics.SmoothingMode = SmoothingMode.AntiAlias;
            objGraphics.TextRenderingHint = TextRenderingHint.AntiAlias;
            objGraphics.DrawString(text, objFont, new SolidBrush(Color.Black), 0, 0);
            objGraphics.Flush();

            textImage.Save(savePath, System.Drawing.Imaging.ImageFormat.Png);
        }
    }
}

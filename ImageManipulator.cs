using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClickCounter
{
    static class ImageManipulator
    {
        private static List<Image> historie = new List<Image>();

        private static PropertyService propSerivice = PropertyService.getInstance();

        /// <summary>
        /// Draws a point to the given image and returns it
        /// </summary>
        /// <param name="image"></param>
        /// <param name="coords"></param>
        /// <param name="color"></param>
        /// <returns></returns>
        public static Image drawPoint(Image image, Point coords, Color color)
        {
            if( image == null || coords == null || color == null )
            {
                throw new ArgumentException("One argument is null");
            }

            
            addHistoryEntry((Image)image.Clone());

            Graphics g = Graphics.FromImage(image);

            Pen pen = new Pen(color, propSerivice.penWidth);
            g.DrawRectangle(pen, coords.X, coords.Y, propSerivice.rectangleSize.Width, propSerivice.rectangleSize.Height);
            g.Save();

            return image;
        }


        public static Image revertLastManipulation()
        {
            if( historie.Count > 0 )
            {
                // get image before last modification and remove it from list
                Image i = historie.Last<Image>(); ;
                historie.RemoveAt(historie.Count - 1);
                return i;
            } 
            else
            {
                return null;
            }
        }

        private static void addHistoryEntry(Image image)
        {
            if( image != null )
            {
                // if max historie count is reached, remove the oldest entry
                if( historie.Count >= propSerivice.maxHistorie )
                {
                    historie.RemoveAt(0);
                }

                historie.Add(image);
            }
        }
    }
}

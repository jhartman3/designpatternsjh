using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SketchPad
{
    public class Shape
    {
        string shapeName;
        Pen drawingColor;
        int topX;
        int topY;
        int xLen;
        int yLen;
        public Shape(string shape, Pen color, int x1, int y1, int length, int width)
        {
            shapeName = shape;
            drawingColor = color;
            topX = x1;
            topY = y1;
            xLen = length;
            yLen = width;
        }

        public string getShape()
        {
            return shapeName;
        }

        public Pen getColor()
        {
            return drawingColor;
        }

        public int getTopX()
        {
            return topX;
        }

        public int getTopY()
        {
            return topY;
        }

        public int getLength()
        {
            return xLen;
        }

        public int getHeight()
        {
            return yLen;
        }
    }
}

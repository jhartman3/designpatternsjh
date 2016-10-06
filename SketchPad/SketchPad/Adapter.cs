using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SketchPad
{
    public class Adapter // this is the adapter and receiver class
    {
        Graphics g;
        List<Shape> shapeList;
        public Adapter(System.Windows.Forms.Panel panel)
        {
            g = panel.CreateGraphics();
            shapeList = new List<Shape>();
        }

        public void drawRect(Pen color, int x1, int y1, int width, int height)
        {
            g.Clear(Color.White);
            g.DrawRectangle(Pens.Red, x1, y1, width, height);
        }

        public void drawCircle(Pen color, int x1, int y1, int width, int height)
        {
            g.Clear(Color.White);
            g.DrawEllipse(Pens.Red, x1, y1, width, height);
        }

        public void addToList(string shape, Pen color, int x1, int y1, int width, int height)
        {
            shapeList.Add(new Shape(shape, color, x1, y1, width, height));
        }

        public void addToList(Shape shape)
        {
            shapeList.Add(shape);
        }

        public void clear()
        {
            g.Clear(Color.White);
        }

        public void remove()
        {
            int c = shapeList.Count - 1;
            shapeList.RemoveAt(c);
        }

        public void drawAll()
        {
            for (int i = 0; i < shapeList.Count(); i++)
            {
                Shape s = shapeList[i];
                if (s.getShape() == "rect")
                {
                    g.DrawRectangle(s.getColor(), s.getTopX(), s.getTopY(), s.getLength(), s.getHeight());
                }
                else if (s.getShape() == "circle")
                {
                    g.DrawEllipse(s.getColor(), s.getTopX(), s.getTopY(), s.getLength(), s.getHeight());
                }
            }
        }
    }
}

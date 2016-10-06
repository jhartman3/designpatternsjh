using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SketchPad
{
    public class RectCommand : Command // this is a ConcreteCommand class
    {
        Shape rectangle;
        Adapter adapter;
        public RectCommand(Pen color, int x1, int y1, int width, int height, Adapter a)
        {
            rectangle = new Shape("rect", color, x1, y1, width, height);
            adapter = a;
        }

        public override void draw()
        {
            adapter.addToList(rectangle);
            adapter.drawAll();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SketchPad
{
    public class CircleCommand : Command // this is a ConcreteCommand class
    {
        Shape circle;
        Adapter adapter;
        public CircleCommand(Pen color, int x1, int y1, int width, int height, Adapter a)
        {
            circle = new Shape("circle", color, x1, y1, width, height);
            adapter = a;
        }
        public override void draw()
        {
            adapter.addToList(circle);
            adapter.drawAll();
        }
    }
}

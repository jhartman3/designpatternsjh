using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SketchPad
{
    public partial class Form1 : Form
    {
        int x1;
        int y1;
        string currentShape;
        Adapter adapter;
        Invoker invoker;
        public Form1()
        {
            InitializeComponent();
            adapter = new Adapter(pnl_canvas);
            currentShape = "rect";
            invoker = new Invoker(adapter);
        }

        private void pnl_canvas_MouseDown(object sender, MouseEventArgs e)
        {
            x1 = e.X;
            y1 = e.Y;
        }

        private void pnl_canvas_MouseUp(object sender, MouseEventArgs e)
        {
            if (currentShape == "rect")
            {
                invoker.Add(new RectCommand(Pens.Red, x1, y1, e.X - x1, e.Y - y1, adapter));
            }
            else if (currentShape == "circle")
            {
                invoker.Add(new CircleCommand(Pens.Red, x1, y1, e.X - x1, e.Y - y1, adapter));
            }
        }

        private void pnl_canvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                return;
            }
            else
            {
                if (currentShape == "rect")
                {
                    adapter.drawRect(System.Drawing.Pens.Red, x1, y1, e.X - x1, e.Y - y1);
                }
                else if (currentShape == "circle")
                {
                    adapter.drawCircle(System.Drawing.Pens.Red, x1, y1, e.X - x1, e.Y - y1);
                }
                adapter.drawAll();
            }
        }

        private void rb_rect_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_rect.Checked)
            {
                currentShape = "rect";
            }
        }

        private void rb_circle_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_circle.Checked)
            {
                currentShape = "circle";
            }
        }

        private void btn_undo_Click(object sender, EventArgs e)
        {
            invoker.Undo();
        }

        private void btn_redo_Click(object sender, EventArgs e)
        {
            invoker.Redo();
        }
    }
}

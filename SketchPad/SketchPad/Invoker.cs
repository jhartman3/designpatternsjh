using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SketchPad
{
    public class Invoker // this is the invoker class
    {
        Adapter adapter;
        Stack<Command> drawnList;
        Stack<Command> undrawnList;

        public Invoker(Adapter a)
        {
            adapter = a;
            drawnList = new Stack<Command>();
            undrawnList = new Stack<Command>();
        }

        public void Add(Command c)
        {
            drawnList.Push(c);
            drawnList.Peek().draw();
        }

        public void Undo()
        {
            if (drawnList.Count > 0)
            {
                undrawnList.Push(drawnList.Pop());
                adapter.remove();
                adapter.clear();
                adapter.drawAll();
            }
        }

        public void Redo()
        {
            if (undrawnList.Count > 0)
            {
                drawnList.Push(undrawnList.Pop());
                adapter.clear();
                drawnList.Peek().draw();
            }
        }
    }
}

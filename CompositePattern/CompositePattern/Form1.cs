using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompositePattern
{
    public partial class Form1 : Form
    {
        public List<Component> compounds;
        public List<Component> formula;
        public bool isCyclic;
        public Form1()
        {
            InitializeComponent();
            compounds = new List<Component>();
            formula   = new List<Component>();
            isCyclic = false;
        }

        private void btn_addItem_Click(object sender, EventArgs e)
        {
            int a = cb_newItem.SelectedIndex;
            if (a != -1)
            {
                if (a == 0)
                {
                    formula.Add(new Methane());
                    lb_newCompound.Items.Add("Methane Group");
                }
                else if (a == 1)
                {
                    formula.Add(new Benzene());
                    lb_newCompound.Items.Add("Benzene Ring");
                }
                else if (a == 2)
                {
                    isCyclic = true;
                    lb_newCompound.Items.Add("Cyclic Bond");
                }
            }
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            int a = compounds.Count;
            Composite c = new Composite();
            foreach (Component b in formula)
            {
                c.addComponent(b);
            }
            c.setCyclic(isCyclic);
            compounds.Add(c);
            lb_newCompound.Items.Clear();
            Composite temp = (Composite)compounds[a];
            lb_compoundList.Items.Add(temp.getName());
            int d = temp.getChildCount();
            for (int i = 0; i < d; i++)
            {
                Component child = temp.getChild(i);
                lb_compoundList.Items.Add("    " + child.getName());
            }
            formula.Clear();
            isCyclic = false;
        }
    }
}

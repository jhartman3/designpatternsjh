using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemplateMethod
{
    public partial class Form1 : Form
    {
        SetCounter counter;
        public Form1()
        {
            InitializeComponent();
            counter = new Permutation();
        }

        private void rb_permutation_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_permutation.Checked && !(counter is Permutation))
            {
                counter = new Permutation();
            }
        }

        private void rb_combinations_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_combinations.Checked && !(counter is Combination))
            {
                counter = new Combination();
            }
        }

        private void btn_calculate_Click(object sender, EventArgs e)
        {
            int n = (int)spin_setcount.Value;
            int r = (int)spin_choosecount.Value;
            int result = counter.calculate(n, r);
            if (result == -1)
            {
                MessageBox.Show("The number of elements to choose must not be greater than" + 
                    " the set size!");
            }
            else
            {
                string s;
                if (counter is Permutation)
                {
                    s = "P";
                }
                else
                {
                    s = "C";
                }
                string entry = "" + n + " " + s + " " + r + " = " + result;
                lb_result.Items.Insert(0, entry);
            }
        }
    }
}

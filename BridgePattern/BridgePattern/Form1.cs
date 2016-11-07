using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BridgePattern
{
    public partial class Form1 : Form
    {
        General general;
        public Form1()
        {
            InitializeComponent();
            general = new FieldGeneral();
        }

        private void rb_attack_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_attack.Checked)
            {
                general.callRaider();
            }
        }

        private void rb_defend_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_defend.Checked)
            {
                general.callGuard();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lb_output.Items.Insert(0, general.command());
        }
    }
}

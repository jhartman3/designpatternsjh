using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FactoryMethod
{
    public partial class Form1 : Form
    {
        public List<LightBulb> bulbList;
        public Factory incanFactory;
        public Factory fluorFactory;
        public Factory ledFactory;
        public Form1()
        {
            InitializeComponent();
            bulbList     = new List<LightBulb>();
            incanFactory = new IncandescentFactory();
            fluorFactory = new FluorescentFactory();
            ledFactory   = new LEDFactory();
        }

        private void btn_addbutton_Click(object sender, EventArgs e)
        {
            int bulbindex = cb_bulbtype.SelectedIndex;
            if (bulbindex == 0)
            {
                bulbList.Add(incanFactory.createBulb());
                lb_bulblist.Items.Add("Incandescent bulb");
            }
            else if (bulbindex == 1)
            {
                bulbList.Add(fluorFactory.createBulb());
                lb_bulblist.Items.Add("Fluorescent bulb");
            }
            else if (bulbindex == 2)
            {
                bulbList.Add(ledFactory.createBulb());
                lb_bulblist.Items.Add("Light-Emitting Diode");
            }
        }

        private void btn_viewbutton_Click(object sender, EventArgs e)
        {
            int bulbindex         = lb_bulblist.SelectedIndex;
            if (bulbindex == -1) return;
            LightBulb currentBulb = bulbList[bulbindex];
            int    wattage        = currentBulb.getWattage();
            double cost           = currentBulb.getCost();
            lbl_watts.Text = "" + wattage;
            lbl_cost.Text  = "" + cost;
        }
    }
}

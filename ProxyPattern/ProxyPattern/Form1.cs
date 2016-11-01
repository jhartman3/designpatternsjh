using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProxyPattern
{
    public partial class Form1 : Form
    {
        Subject joe;
        public Form1()
        {
            InitializeComponent();
            joe = new Engineer();
        }

        public int getIndex()
        {
            int s;
            if (rb_shields.Checked)
            {
                s = 0;
            }
            else if (rb_hull.Checked)
            {
                s = 1;
            }
            else if (rb_power.Checked)
            {
                s = 2;
            }
            else if (rb_weapons.Checked)
            {
                s = 3;
            }
            else if (rb_sensors.Checked)
            {
                s = 4;
            }
            else if (rb_comms.Checked)
            {
                s = 5;
            }
            else
            {
                s = -1;
            }
            return s;
        }

        private void btn_ask_Click(object sender, EventArgs e)
        {
            if (joe.hullIntegrity() == 0)
                return;
            int s = getIndex();
            string message = "error";
            if (s == 0)
            {
                message = joe.getShields();
            }
            else if (s == 1)
            {
                message = joe.getHull();
            }
            else if (s == 2)
            {
                message = joe.getPower();
            }
            else if (s == 3)
            {
                message = joe.getWeapons();
            }
            else if (s == 4)
            {
                message = joe.getSensors();
            }
            else if (s == 5)
            {
                message = joe.getComms();
            }
            lb_status.Items.Add(message);
            lb_status.TopIndex = lb_status.Items.Count - 1;
        }

        private void btn_fire_Click(object sender, EventArgs e)
        {
            if (joe.torpCount() > 0)
            {
                joe.fireWeapons();
                lb_status.Items.Add("Firing now, Captain.");
                lb_status.TopIndex = lb_status.Items.Count - 1;
            }
            else
            {
                lb_status.Items.Add("We are out of weapons, Captain.");
                lb_status.TopIndex = lb_status.Items.Count - 1;
            }
        }

        private void btn_jam_Click(object sender, EventArgs e)
        {
            joe.jamFrequencies();
            lb_status.Items.Add("Captain, something is jamming us.");
            lb_status.TopIndex = lb_status.Items.Count - 1;
            btn_jam.Enabled = false;
        }

        private void btn_explode_Click(object sender, EventArgs e)
        {
            joe.detonate();
            if (joe.hullIntegrity() > 0)
            {
                lb_status.Items.Add("Captain, an explosive has gone off within the ship.");
                lb_status.TopIndex = lb_status.Items.Count - 1;
            }
            else
            {
                lb_status.Items.Add("Notice: the ship has been destroyed.");
                lb_status.TopIndex = lb_status.Items.Count - 1;
                btn_ask.Enabled = false;
                btn_fire.Enabled = false;
                btn_jam.Enabled = false;
                btn_explode.Enabled = false;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StatePattern
{
    public partial class Form1 : Form
    {
        int currIndex;
        Cell cell;
        public Form1()
        {
            InitializeComponent();
            cell = new Cell();
            for (int i = 0; i < 10; i++)
            {
                lb_energyList.Items.Add("ADP");
            }
            currIndex = 0;
        }

        private void lb_energyList_SelectedIndexChanged(object sender, EventArgs e)
        {
            currIndex = lb_energyList.SelectedIndex;
            updateButtons();
        }

        private void btn_charge_Click(object sender, EventArgs e)
        {
            cell.setState(currIndex, true);
            updateList();
            updateButtons();
            lb_energyList.SelectedIndex = currIndex;
        }

        private void btn_discharge_Click(object sender, EventArgs e)
        {
            cell.setState(currIndex, false);
            updateList();
            updateButtons();
            lb_energyList.SelectedIndex = currIndex;
        }

        private void updateList()
        {
            lb_energyList.Items.Clear();
            for (int i = 0; i < 10; i++)
            {
                lb_energyList.Items.Add(cell.getState(i));
            }
        }

        private void updateButtons()
        {
            if (cell.getState(currIndex) == "ATP")
            {
                btn_charge.Enabled = false;
                btn_discharge.Enabled = true;
            }
            else
            {
                btn_charge.Enabled = true;
                btn_discharge.Enabled = false;
            }
        }
    }
}

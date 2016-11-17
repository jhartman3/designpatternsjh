using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DecoratorPattern
{
    public partial class Form1 : Form
    {
        List<Soldier> knightList;
        Soldier knight;
        int index;
        public Form1()
        {
            InitializeComponent();
            knightList = new List<Soldier>();
        }

        private void btn_recruit_Click(object sender, EventArgs e)
        {
            string name = tb_name.Text;
            if (name == "")
            {
                MessageBox.Show("You haven't entered a name for the new recruit!");
            }
            else if (lb_knights.Items.Contains(name))
            {
                MessageBox.Show("That knight has already been recruited!");
                tb_name.Text = "";
            }
            else
            {
                lb_knights.Items.Add(name);
                knightList.Add(new Swordsman());
                tb_name.Text = "";
            }
        }

        private void lb_knights_SelectedIndexChanged(object sender, EventArgs e)
        {
            index = lb_knights.SelectedIndex;
            knight = knightList[index];
            btn_attack.Enabled = true;
            if (knight is Spearman)
            {
                btn_charge.Enabled = true;
                btn_defend.Enabled = false;
                btn_dropdefense.Enabled = false;
                btn_spear.Enabled = false;
                btn_shield.Enabled = false;
            }
            else if (knight is ShieldBearer)
            {
                btn_charge.Enabled = false;
                btn_defend.Enabled = true;
                btn_dropdefense.Enabled = true;
                btn_spear.Enabled = false;
                btn_shield.Enabled = false;
            }
            else
            {
                btn_charge.Enabled = false;
                btn_defend.Enabled = false;
                btn_dropdefense.Enabled = false;
                btn_spear.Enabled = true;
                btn_shield.Enabled = true;
            }
        }

        private void btn_spear_Click(object sender, EventArgs e)
        {
            knightList[index] = new Spearman();
            lb_knights_SelectedIndexChanged(sender, e);
        }

        private void btn_shield_Click(object sender, EventArgs e)
        {
            knightList[index] = new ShieldBearer();
            lb_knights_SelectedIndexChanged(sender, e);
        }

        private void btn_attack_Click(object sender, EventArgs e)
        {
            lb_feedback.Items.Insert(0, knight.attack());
        }

        private void btn_charge_Click(object sender, EventArgs e)
        {
            Spearman spearman = (Spearman)knight;
            lb_feedback.Items.Insert(0, spearman.charge());
        }

        private void btn_defend_Click(object sender, EventArgs e)
        {
            ShieldBearer defender = (ShieldBearer)knight;
            lb_feedback.Items.Insert(0, defender.defend());
        }

        private void btn_dropdefense_Click(object sender, EventArgs e)
        {
            ShieldBearer defender = (ShieldBearer)knight;
            lb_feedback.Items.Insert(0, defender.dropDefense());
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstractFactory
{
    public partial class Form1 : Form
    {
        public AbstractFactory castle;
        public AbstractFactory smithy;
        public List<object> armory;
        public int count = 0;
        public Form1()
        {
            InitializeComponent();
            castle = new CastleSmith();
            smithy = new TownSmith();
            armory = new List<object>();
        }

        private void btn_forge_Click(object sender, EventArgs e)
        {
            int item = cb_itemType.SelectedIndex;
            string mater = (string)cb_material.SelectedItem;
            if (item == 0)
            {
                armory.Add(castle.createSword(mater));
                string newName = armory[count].ToString();
                count++;
                lb_itemBox.Items.Add(newName);
            }
            else if (item == 1)
            {
                armory.Add(smithy.createSword(mater));
                string newName = armory[count].ToString();
                count++;
                lb_itemBox.Items.Add(newName);
            }
            else if (item == 2)
            {
                armory.Add(castle.createShield(mater));
                string newName = armory[count].ToString();
                count++;
                lb_itemBox.Items.Add(newName);
            }
            else if (item == 3)
            {
                armory.Add(smithy.createShield(mater));
                string newName = armory[count].ToString();
                count++;
                lb_itemBox.Items.Add(newName);
            }
        }

        private void lb_itemBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int item = lb_itemBox.SelectedIndex;
            if (lb_itemBox.GetItemText(item) == null){
                return;
            }
            if (armory[item].ToString().Contains("sword"))
            {
                AbstractSword currentItem = (AbstractSword)armory[item];
                lbl_length.Text = "" + currentItem.getLength();
                lbl_shape.Text = "N/A";
                lbl_material.Text = currentItem.getMaterial();
            }
            else if (armory[item].ToString().Contains("Shield"))
            {
                AbstractShield currentItem = (AbstractShield)armory[item];
                lbl_length.Text = "N/A";
                lbl_shape.Text = currentItem.getShape();
                lbl_material.Text = currentItem.getMaterial();
            }
        }
    }
}

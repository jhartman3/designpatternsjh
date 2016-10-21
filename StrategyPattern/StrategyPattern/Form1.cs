using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StrategyPattern
{
    public partial class Form1 : Form
    {
        private List<int>     list;
        private Sort          sorter;
        private InsertionSort inserter;
        private SelectionSort selector;
        private BubbleSort    bubble;
        public Form1()
        {
            InitializeComponent();
            cb_sortType.SelectedIndex = 0;
            list     = new List<int>();
            inserter = new InsertionSort();
            sorter   = inserter;
            selector = new SelectionSort();
            bubble   = new BubbleSort();
        }

        private void displayList()
        {
            lb_numList.Items.Clear();
            foreach (int a in list)
            {
                lb_numList.Items.Add("" + a);
            }
        }

        private void sortList(List<int> aList)
        {
            list = sorter.sortList(aList);
            displayList();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            int a = (int)nud_newNum.Value;
            list.Add(a);
            displayList();
        }

        private void cb_sortType_SelectedIndexChanged(object sender, EventArgs e)
        {
            int a = cb_sortType.SelectedIndex;
            if (a == 0)
            {
                sorter = inserter;
            }
            else if (a == 1)
            {
                sorter = selector;
            }
            else
            {
                sorter = bubble;
            }
        }

        private void btn_sort_Click(object sender, EventArgs e)
        {
            if (list.Count > 0)
            {
                sortList(list);
            }
        }
    }
}

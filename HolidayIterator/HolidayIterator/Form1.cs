using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HolidayIterator
{
    public partial class Form1 : Form
    {
        Aggregate forwardAgg = new ConcreteAggregate();
        Aggregate reverseAgg = new ConcreteAggregate();
        Iterator forwardIter;
        Iterator reverseIter;
        bool isFiltered = false; // whether checking for a particular month
        public Form1()
        {
            InitializeComponent();
            PrepareForward();
            PrepareReverse();
        }

        // prepare the forward iterator and its aggregate, adding all elements
        private void PrepareForward()
        {
            forwardAgg.elements.Add(new Holiday(1, "New Years Day"));
            forwardAgg.elements.Add(new Holiday(1, "Martin Luther King, Jr. Day"));
            forwardAgg.elements.Add(new Holiday(2, "George Washington's Birthday"));
            forwardAgg.elements.Add(new Holiday(5, "Memorial Day"));
            forwardAgg.elements.Add(new Holiday(7, "Independence Day"));
            forwardAgg.elements.Add(new Holiday(9, "Labor Day"));
            forwardAgg.elements.Add(new Holiday(10, "Columbus Day"));
            forwardAgg.elements.Add(new Holiday(11, "Veterans' Day"));
            forwardAgg.elements.Add(new Holiday(11, "Thanksgiving"));
            forwardAgg.elements.Add(new Holiday(12, "Christmas"));
            forwardIter = forwardAgg.createIterator();
        }

        // prepare the reverse iterator and its aggregate, adding all elements
        private void PrepareReverse()
        {
            reverseAgg.isReverse = true;
            reverseAgg.elements.Add(new Holiday(1, "New Years Day"));
            reverseAgg.elements.Add(new Holiday(1, "Martin Luther King, Jr. Day"));
            reverseAgg.elements.Add(new Holiday(2, "George Washington's Birthday"));
            reverseAgg.elements.Add(new Holiday(5, "Memorial Day"));
            reverseAgg.elements.Add(new Holiday(7, "Independence Day"));
            reverseAgg.elements.Add(new Holiday(9, "Labor Day"));
            reverseAgg.elements.Add(new Holiday(10, "Columbus Day"));
            reverseAgg.elements.Add(new Holiday(11, "Veterans' Day"));
            reverseAgg.elements.Add(new Holiday(11, "Thanksgiving"));
            reverseAgg.elements.Add(new Holiday(12, "Christmas"));
            reverseIter = reverseAgg.createIterator();
        }

        private void btn_View_Click(object sender, EventArgs e)
        {
            isFiltered = cb_ByDate.Checked;
            forwardIter.first();
            lb_Collection.Items.Clear(); // clear the list to show results
            // if not checking for a month, show all items
            if (!isFiltered)
            {
                while (!forwardIter.isDone())
                {
                    lb_Collection.Items.Add(forwardIter.currentItem().ToString());
                    forwardIter.next();
                }
            }
            else // searching for a month, so filter
            {
                if (cb_MonthChoose.SelectedIndex != -1) // make sure something is selected
                {
                    // filter based on the month
                    int checkMonth = cb_MonthChoose.SelectedIndex + 1;
                    while (!forwardIter.isDone())
                    {
                        Holiday hol = (Holiday)forwardIter.currentItem();
                        if (hol.month == checkMonth)
                        {
                            lb_Collection.Items.Add(forwardIter.currentItem().ToString());
                        }
                        forwardIter.next();
                    }
                }
            }
        }

        private void btn_Reverse_Click(object sender, EventArgs e)
        {
            isFiltered = cb_ByDate.Checked;
            reverseIter.first();
            lb_Collection.Items.Clear(); // clear the list to show results
            // if not checking for a month, show all items
            if (!isFiltered)
            {
                while (!reverseIter.isDone())
                {
                    lb_Collection.Items.Add(reverseIter.currentItem().ToString());
                    reverseIter.next();
                }
            }
            else // searching for a month, so filter
            {
                if (cb_MonthChoose.SelectedIndex != -1) // make sure something is selected
                {
                    // filter based on the month
                    int checkMonth = cb_MonthChoose.SelectedIndex + 1;
                    while (!reverseIter.isDone())
                    {
                        Holiday hol = (Holiday)reverseIter.currentItem();
                        if (hol.month == checkMonth)
                        {
                            lb_Collection.Items.Add(reverseIter.currentItem().ToString());
                        }
                        reverseIter.next();
                    }
                }
            }
        }
    }
}

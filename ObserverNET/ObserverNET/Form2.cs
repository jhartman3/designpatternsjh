using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObserverNET
{
    public partial class Form2 : Form // this is the ConcreteObservable class
    {
        private string name;
        public delegate void ChatEventHandler(object sender, ChatEventArgs e);

        public event ChatEventHandler ChatPosted;

        public string memberName
        {
            get { return name; }
            set { name = value; }
        }

        public Form2()
        {
            InitializeComponent();
        }

        public Form2(string aName)
        {
            InitializeComponent();
            memberName = aName;
            this.Text = aName;
        }

        private void btn_post_Click(object sender, EventArgs e)
        {
            ChatPosted(this, new ChatEventArgs(memberName, tb_chatBox.Text));
            tb_chatBox.Text = "";
        }
    }
}

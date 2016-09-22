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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_newMember_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(tb_newName.Text);
            f2.ChatPosted += new Form2.ChatEventHandler(f2_chatPosted);
            f2.Show();
        }

        void f2_chatPosted(object sender, ChatEventArgs e)
        {
            string newPost = e.chatName + ": " + e.postContent + "\r\n";
            tb_groupChat.Text += newPost;
        }
    }
}

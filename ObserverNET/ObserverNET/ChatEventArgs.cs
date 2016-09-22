using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverNET
{
    public class ChatEventArgs : EventArgs
    {
        private string name;

        public string chatName
        {
            get { return name; }
            set { name = value; }
        }

        private string content;

        public string postContent
        {
            get { return content; }
            set { content = value; }
        }

        public ChatEventArgs(string newName, string newContent)
        {
            name = newName;
            content = newContent;
        }
    }
}

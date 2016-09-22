namespace ObserverNET
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btn_newMember = new System.Windows.Forms.Button();
            this.tb_groupChat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_newName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Group Chat Window";
            // 
            // btn_newMember
            // 
            this.btn_newMember.Location = new System.Drawing.Point(277, 72);
            this.btn_newMember.Name = "btn_newMember";
            this.btn_newMember.Size = new System.Drawing.Size(105, 23);
            this.btn_newMember.TabIndex = 1;
            this.btn_newMember.Text = "New Member";
            this.btn_newMember.UseVisualStyleBackColor = true;
            this.btn_newMember.Click += new System.EventHandler(this.btn_newMember_Click);
            // 
            // tb_groupChat
            // 
            this.tb_groupChat.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tb_groupChat.Location = new System.Drawing.Point(16, 29);
            this.tb_groupChat.Multiline = true;
            this.tb_groupChat.Name = "tb_groupChat";
            this.tb_groupChat.ReadOnly = true;
            this.tb_groupChat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_groupChat.Size = new System.Drawing.Size(256, 256);
            this.tb_groupChat.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(279, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name:";
            // 
            // tb_newName
            // 
            this.tb_newName.Location = new System.Drawing.Point(277, 46);
            this.tb_newName.Name = "tb_newName";
            this.tb_newName.Size = new System.Drawing.Size(105, 20);
            this.tb_newName.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 297);
            this.Controls.Add(this.tb_newName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_groupChat);
            this.Controls.Add(this.btn_newMember);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Group Chat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_newMember;
        private System.Windows.Forms.TextBox tb_groupChat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_newName;
    }
}


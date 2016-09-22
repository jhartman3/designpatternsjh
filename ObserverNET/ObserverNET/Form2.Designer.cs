namespace ObserverNET
{
    partial class Form2
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
            this.btn_post = new System.Windows.Forms.Button();
            this.tb_chatBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_post
            // 
            this.btn_post.Location = new System.Drawing.Point(13, 226);
            this.btn_post.Name = "btn_post";
            this.btn_post.Size = new System.Drawing.Size(75, 23);
            this.btn_post.TabIndex = 2;
            this.btn_post.Text = "Post";
            this.btn_post.UseVisualStyleBackColor = true;
            this.btn_post.Click += new System.EventHandler(this.btn_post_Click);
            // 
            // tb_chatBox
            // 
            this.tb_chatBox.Location = new System.Drawing.Point(13, 12);
            this.tb_chatBox.Multiline = true;
            this.tb_chatBox.Name = "tb_chatBox";
            this.tb_chatBox.Size = new System.Drawing.Size(258, 208);
            this.tb_chatBox.TabIndex = 3;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.tb_chatBox);
            this.Controls.Add(this.btn_post);
            this.Name = "Form2";
            this.Text = "Chat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_post;
        private System.Windows.Forms.TextBox tb_chatBox;
    }
}
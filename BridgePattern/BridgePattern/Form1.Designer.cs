namespace BridgePattern
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_attack = new System.Windows.Forms.RadioButton();
            this.rb_defend = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.lb_output = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.rb_defend);
            this.groupBox1.Controls.Add(this.rb_attack);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 70);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tactics";
            // 
            // rb_attack
            // 
            this.rb_attack.AutoSize = true;
            this.rb_attack.Location = new System.Drawing.Point(7, 20);
            this.rb_attack.Name = "rb_attack";
            this.rb_attack.Size = new System.Drawing.Size(108, 17);
            this.rb_attack.TabIndex = 0;
            this.rb_attack.TabStop = true;
            this.rb_attack.Text = "Attack the enemy";
            this.rb_attack.UseVisualStyleBackColor = true;
            this.rb_attack.CheckedChanged += new System.EventHandler(this.rb_attack_CheckedChanged);
            // 
            // rb_defend
            // 
            this.rb_defend.AutoSize = true;
            this.rb_defend.Location = new System.Drawing.Point(7, 44);
            this.rb_defend.Name = "rb_defend";
            this.rb_defend.Size = new System.Drawing.Size(115, 17);
            this.rb_defend.TabIndex = 1;
            this.rb_defend.TabStop = true;
            this.rb_defend.Text = "Defend our territory";
            this.rb_defend.UseVisualStyleBackColor = true;
            this.rb_defend.CheckedChanged += new System.EventHandler(this.rb_defend_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(178, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 41);
            this.button1.TabIndex = 2;
            this.button1.Text = "Advance";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lb_output
            // 
            this.lb_output.FormattingEnabled = true;
            this.lb_output.Location = new System.Drawing.Point(13, 90);
            this.lb_output.Name = "lb_output";
            this.lb_output.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lb_output.Size = new System.Drawing.Size(259, 95);
            this.lb_output.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 197);
            this.Controls.Add(this.lb_output);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Army Manager";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rb_defend;
        private System.Windows.Forms.RadioButton rb_attack;
        private System.Windows.Forms.ListBox lb_output;
    }
}


namespace FactoryMethod
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
            this.lb_bulblist = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_bulbtype = new System.Windows.Forms.ComboBox();
            this.btn_addbutton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_watts = new System.Windows.Forms.Label();
            this.lbl_cost = new System.Windows.Forms.Label();
            this.btn_viewbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_bulblist
            // 
            this.lb_bulblist.FormattingEnabled = true;
            this.lb_bulblist.Location = new System.Drawing.Point(16, 46);
            this.lb_bulblist.Name = "lb_bulblist";
            this.lb_bulblist.Size = new System.Drawing.Size(120, 199);
            this.lb_bulblist.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select a type of light bulb and press add to create it.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Select a bulb and press view to see its properties.";
            // 
            // cb_bulbtype
            // 
            this.cb_bulbtype.FormattingEnabled = true;
            this.cb_bulbtype.Items.AddRange(new object[] {
            "Incandescent",
            "Fluorescent",
            "Light-Emitting Diode"});
            this.cb_bulbtype.Location = new System.Drawing.Point(143, 47);
            this.cb_bulbtype.Name = "cb_bulbtype";
            this.cb_bulbtype.Size = new System.Drawing.Size(129, 21);
            this.cb_bulbtype.TabIndex = 3;
            // 
            // btn_addbutton
            // 
            this.btn_addbutton.Location = new System.Drawing.Point(143, 75);
            this.btn_addbutton.Name = "btn_addbutton";
            this.btn_addbutton.Size = new System.Drawing.Size(75, 23);
            this.btn_addbutton.TabIndex = 4;
            this.btn_addbutton.Text = "Add";
            this.btn_addbutton.UseVisualStyleBackColor = true;
            this.btn_addbutton.Click += new System.EventHandler(this.btn_addbutton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(142, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Watts:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(142, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Annual Cost:";
            // 
            // lbl_watts
            // 
            this.lbl_watts.AutoSize = true;
            this.lbl_watts.Location = new System.Drawing.Point(187, 111);
            this.lbl_watts.Name = "lbl_watts";
            this.lbl_watts.Size = new System.Drawing.Size(13, 13);
            this.lbl_watts.TabIndex = 7;
            this.lbl_watts.Text = "0";
            // 
            // lbl_cost
            // 
            this.lbl_cost.AutoSize = true;
            this.lbl_cost.Location = new System.Drawing.Point(216, 136);
            this.lbl_cost.Name = "lbl_cost";
            this.lbl_cost.Size = new System.Drawing.Size(13, 13);
            this.lbl_cost.TabIndex = 8;
            this.lbl_cost.Text = "0";
            // 
            // btn_viewbutton
            // 
            this.btn_viewbutton.Location = new System.Drawing.Point(143, 168);
            this.btn_viewbutton.Name = "btn_viewbutton";
            this.btn_viewbutton.Size = new System.Drawing.Size(75, 23);
            this.btn_viewbutton.TabIndex = 9;
            this.btn_viewbutton.Text = "View";
            this.btn_viewbutton.UseVisualStyleBackColor = true;
            this.btn_viewbutton.Click += new System.EventHandler(this.btn_viewbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btn_viewbutton);
            this.Controls.Add(this.lbl_cost);
            this.Controls.Add(this.lbl_watts);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_addbutton);
            this.Controls.Add(this.cb_bulbtype);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_bulblist);
            this.Name = "Form1";
            this.Text = "Light Bulb Factory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb_bulblist;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_bulbtype;
        private System.Windows.Forms.Button btn_addbutton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_watts;
        private System.Windows.Forms.Label lbl_cost;
        private System.Windows.Forms.Button btn_viewbutton;
    }
}


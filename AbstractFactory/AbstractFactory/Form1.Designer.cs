namespace AbstractFactory
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
            this.lb_itemBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_length = new System.Windows.Forms.Label();
            this.lbl_shape = new System.Windows.Forms.Label();
            this.lbl_material = new System.Windows.Forms.Label();
            this.cb_material = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_itemType = new System.Windows.Forms.ComboBox();
            this.btn_forge = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_itemBox
            // 
            this.lb_itemBox.FormattingEnabled = true;
            this.lb_itemBox.Location = new System.Drawing.Point(13, 36);
            this.lb_itemBox.Name = "lb_itemBox";
            this.lb_itemBox.Size = new System.Drawing.Size(164, 212);
            this.lb_itemBox.TabIndex = 0;
            this.lb_itemBox.SelectedIndexChanged += new System.EventHandler(this.lb_itemBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(392, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select an item to view its properties. Use the menus provided to create new items" +
    ".";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(183, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Length:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(183, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Shape:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(183, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Material:";
            // 
            // lbl_length
            // 
            this.lbl_length.AutoSize = true;
            this.lbl_length.Location = new System.Drawing.Point(233, 35);
            this.lbl_length.Name = "lbl_length";
            this.lbl_length.Size = new System.Drawing.Size(13, 13);
            this.lbl_length.TabIndex = 5;
            this.lbl_length.Text = "0";
            // 
            // lbl_shape
            // 
            this.lbl_shape.AutoSize = true;
            this.lbl_shape.Location = new System.Drawing.Point(233, 48);
            this.lbl_shape.Name = "lbl_shape";
            this.lbl_shape.Size = new System.Drawing.Size(27, 13);
            this.lbl_shape.TabIndex = 6;
            this.lbl_shape.Text = "N/A";
            // 
            // lbl_material
            // 
            this.lbl_material.AutoSize = true;
            this.lbl_material.Location = new System.Drawing.Point(233, 62);
            this.lbl_material.Name = "lbl_material";
            this.lbl_material.Size = new System.Drawing.Size(27, 13);
            this.lbl_material.TabIndex = 7;
            this.lbl_material.Text = "N/A";
            // 
            // cb_material
            // 
            this.cb_material.FormattingEnabled = true;
            this.cb_material.Items.AddRange(new object[] {
            "Wooden",
            "Iron",
            "Steel",
            "Silver",
            "Gold"});
            this.cb_material.Location = new System.Drawing.Point(186, 180);
            this.cb_material.Name = "cb_material";
            this.cb_material.Size = new System.Drawing.Size(121, 21);
            this.cb_material.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(183, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Material:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(183, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Item:";
            // 
            // cb_itemType
            // 
            this.cb_itemType.FormattingEnabled = true;
            this.cb_itemType.Items.AddRange(new object[] {
            "Long Sword",
            "Short Sword",
            "Heater Shield",
            "Round Shield"});
            this.cb_itemType.Location = new System.Drawing.Point(186, 134);
            this.cb_itemType.Name = "cb_itemType";
            this.cb_itemType.Size = new System.Drawing.Size(121, 21);
            this.cb_itemType.TabIndex = 11;
            // 
            // btn_forge
            // 
            this.btn_forge.Location = new System.Drawing.Point(186, 208);
            this.btn_forge.Name = "btn_forge";
            this.btn_forge.Size = new System.Drawing.Size(75, 23);
            this.btn_forge.TabIndex = 12;
            this.btn_forge.Text = "Forge Item";
            this.btn_forge.UseVisualStyleBackColor = true;
            this.btn_forge.Click += new System.EventHandler(this.btn_forge_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 261);
            this.Controls.Add(this.btn_forge);
            this.Controls.Add(this.cb_itemType);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cb_material);
            this.Controls.Add(this.lbl_material);
            this.Controls.Add(this.lbl_shape);
            this.Controls.Add(this.lbl_length);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_itemBox);
            this.Name = "Form1";
            this.Text = "Abstract Factory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb_itemBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_length;
        private System.Windows.Forms.Label lbl_shape;
        private System.Windows.Forms.Label lbl_material;
        private System.Windows.Forms.ComboBox cb_material;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_itemType;
        private System.Windows.Forms.Button btn_forge;
    }
}


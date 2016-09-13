namespace FacadePattern
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
            this.cmb_Mode = new System.Windows.Forms.ComboBox();
            this.btn_Facade = new System.Windows.Forms.Button();
            this.pnl_FactoryFloor = new System.Windows.Forms.Panel();
            this.pnl_Warehouse = new System.Windows.Forms.Panel();
            this.pnl_Garage = new System.Windows.Forms.Panel();
            this.pnl_Office1 = new System.Windows.Forms.Panel();
            this.pnl_Office2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pnl_AC2 = new System.Windows.Forms.Panel();
            this.pnl_AC1 = new System.Windows.Forms.Panel();
            this.pnl_AC3 = new System.Windows.Forms.Panel();
            this.pnl_AC4 = new System.Windows.Forms.Panel();
            this.pnl_Fan1 = new System.Windows.Forms.Panel();
            this.pnl_Fan2 = new System.Windows.Forms.Panel();
            this.pnl_Fan3 = new System.Windows.Forms.Panel();
            this.pnl_Fan4 = new System.Windows.Forms.Panel();
            this.pnl_machine1 = new System.Windows.Forms.Panel();
            this.pnl_machine2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.pnl_FactoryFloor.SuspendLayout();
            this.pnl_Warehouse.SuspendLayout();
            this.pnl_Garage.SuspendLayout();
            this.pnl_Office1.SuspendLayout();
            this.pnl_Office2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmb_Mode
            // 
            this.cmb_Mode.FormattingEnabled = true;
            this.cmb_Mode.Items.AddRange(new object[] {
            "Day Shift",
            "Evening Shift",
            "Night Shift",
            "Delivery",
            "Closed"});
            this.cmb_Mode.Location = new System.Drawing.Point(12, 29);
            this.cmb_Mode.Name = "cmb_Mode";
            this.cmb_Mode.Size = new System.Drawing.Size(121, 21);
            this.cmb_Mode.TabIndex = 0;
            // 
            // btn_Facade
            // 
            this.btn_Facade.Location = new System.Drawing.Point(139, 29);
            this.btn_Facade.Name = "btn_Facade";
            this.btn_Facade.Size = new System.Drawing.Size(103, 23);
            this.btn_Facade.TabIndex = 1;
            this.btn_Facade.Text = "Update Systems";
            this.btn_Facade.UseVisualStyleBackColor = true;
            this.btn_Facade.Click += new System.EventHandler(this.btn_Facade_Click);
            // 
            // pnl_FactoryFloor
            // 
            this.pnl_FactoryFloor.BackColor = System.Drawing.Color.Yellow;
            this.pnl_FactoryFloor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_FactoryFloor.Controls.Add(this.pnl_machine2);
            this.pnl_FactoryFloor.Controls.Add(this.pnl_machine1);
            this.pnl_FactoryFloor.Controls.Add(this.pnl_Fan2);
            this.pnl_FactoryFloor.Controls.Add(this.pnl_Fan1);
            this.pnl_FactoryFloor.Controls.Add(this.label3);
            this.pnl_FactoryFloor.Location = new System.Drawing.Point(11, 97);
            this.pnl_FactoryFloor.Name = "pnl_FactoryFloor";
            this.pnl_FactoryFloor.Size = new System.Drawing.Size(195, 127);
            this.pnl_FactoryFloor.TabIndex = 2;
            // 
            // pnl_Warehouse
            // 
            this.pnl_Warehouse.BackColor = System.Drawing.Color.Yellow;
            this.pnl_Warehouse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Warehouse.Controls.Add(this.label4);
            this.pnl_Warehouse.Location = new System.Drawing.Point(213, 97);
            this.pnl_Warehouse.Name = "pnl_Warehouse";
            this.pnl_Warehouse.Size = new System.Drawing.Size(200, 127);
            this.pnl_Warehouse.TabIndex = 3;
            // 
            // pnl_Garage
            // 
            this.pnl_Garage.BackColor = System.Drawing.Color.Yellow;
            this.pnl_Garage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Garage.Controls.Add(this.label6);
            this.pnl_Garage.Location = new System.Drawing.Point(213, 230);
            this.pnl_Garage.Name = "pnl_Garage";
            this.pnl_Garage.Size = new System.Drawing.Size(200, 29);
            this.pnl_Garage.TabIndex = 4;
            // 
            // pnl_Office1
            // 
            this.pnl_Office1.BackColor = System.Drawing.Color.Yellow;
            this.pnl_Office1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Office1.Controls.Add(this.pnl_Fan3);
            this.pnl_Office1.Controls.Add(this.label2);
            this.pnl_Office1.Location = new System.Drawing.Point(12, 56);
            this.pnl_Office1.Name = "pnl_Office1";
            this.pnl_Office1.Size = new System.Drawing.Size(73, 35);
            this.pnl_Office1.TabIndex = 5;
            // 
            // pnl_Office2
            // 
            this.pnl_Office2.BackColor = System.Drawing.Color.Yellow;
            this.pnl_Office2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Office2.Controls.Add(this.pnl_Fan4);
            this.pnl_Office2.Controls.Add(this.label5);
            this.pnl_Office2.Location = new System.Drawing.Point(280, 56);
            this.pnl_Office2.Name = "pnl_Office2";
            this.pnl_Office2.Size = new System.Drawing.Size(73, 35);
            this.pnl_Office2.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Select a mode and press the button to update the systems.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Office 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Factory Floor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-1, -1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Warehouse";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(-1, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Office 2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(-1, -1);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Garage";
            // 
            // pnl_AC2
            // 
            this.pnl_AC2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.pnl_AC2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_AC2.Location = new System.Drawing.Point(139, 230);
            this.pnl_AC2.Name = "pnl_AC2";
            this.pnl_AC2.Size = new System.Drawing.Size(47, 21);
            this.pnl_AC2.TabIndex = 8;
            // 
            // pnl_AC1
            // 
            this.pnl_AC1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.pnl_AC1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_AC1.Location = new System.Drawing.Point(32, 230);
            this.pnl_AC1.Name = "pnl_AC1";
            this.pnl_AC1.Size = new System.Drawing.Size(47, 21);
            this.pnl_AC1.TabIndex = 9;
            // 
            // pnl_AC3
            // 
            this.pnl_AC3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.pnl_AC3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_AC3.Location = new System.Drawing.Point(227, 70);
            this.pnl_AC3.Name = "pnl_AC3";
            this.pnl_AC3.Size = new System.Drawing.Size(47, 21);
            this.pnl_AC3.TabIndex = 10;
            // 
            // pnl_AC4
            // 
            this.pnl_AC4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.pnl_AC4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_AC4.Location = new System.Drawing.Point(359, 70);
            this.pnl_AC4.Name = "pnl_AC4";
            this.pnl_AC4.Size = new System.Drawing.Size(47, 21);
            this.pnl_AC4.TabIndex = 11;
            // 
            // pnl_Fan1
            // 
            this.pnl_Fan1.BackColor = System.Drawing.Color.Silver;
            this.pnl_Fan1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Fan1.Location = new System.Drawing.Point(20, 49);
            this.pnl_Fan1.Name = "pnl_Fan1";
            this.pnl_Fan1.Size = new System.Drawing.Size(25, 26);
            this.pnl_Fan1.TabIndex = 1;
            // 
            // pnl_Fan2
            // 
            this.pnl_Fan2.BackColor = System.Drawing.Color.Silver;
            this.pnl_Fan2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Fan2.Location = new System.Drawing.Point(148, 49);
            this.pnl_Fan2.Name = "pnl_Fan2";
            this.pnl_Fan2.Size = new System.Drawing.Size(26, 26);
            this.pnl_Fan2.TabIndex = 2;
            // 
            // pnl_Fan3
            // 
            this.pnl_Fan3.BackColor = System.Drawing.Color.Silver;
            this.pnl_Fan3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Fan3.Location = new System.Drawing.Point(50, 0);
            this.pnl_Fan3.Name = "pnl_Fan3";
            this.pnl_Fan3.Size = new System.Drawing.Size(22, 22);
            this.pnl_Fan3.TabIndex = 3;
            // 
            // pnl_Fan4
            // 
            this.pnl_Fan4.BackColor = System.Drawing.Color.Silver;
            this.pnl_Fan4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Fan4.Location = new System.Drawing.Point(50, 0);
            this.pnl_Fan4.Name = "pnl_Fan4";
            this.pnl_Fan4.Size = new System.Drawing.Size(22, 22);
            this.pnl_Fan4.TabIndex = 4;
            // 
            // pnl_machine1
            // 
            this.pnl_machine1.BackColor = System.Drawing.Color.Lime;
            this.pnl_machine1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_machine1.Location = new System.Drawing.Point(32, 16);
            this.pnl_machine1.Name = "pnl_machine1";
            this.pnl_machine1.Size = new System.Drawing.Size(130, 23);
            this.pnl_machine1.TabIndex = 3;
            // 
            // pnl_machine2
            // 
            this.pnl_machine2.BackColor = System.Drawing.Color.Lime;
            this.pnl_machine2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_machine2.Location = new System.Drawing.Point(32, 87);
            this.pnl_machine2.Name = "pnl_machine2";
            this.pnl_machine2.Size = new System.Drawing.Size(130, 23);
            this.pnl_machine2.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 270);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Key:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Yellow;
            this.panel1.Location = new System.Drawing.Point(12, 286);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(27, 13);
            this.panel1.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(45, 286);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Lit Room";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Location = new System.Drawing.Point(12, 305);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(27, 13);
            this.panel2.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(46, 305);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Unlit Room";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Navy;
            this.panel3.Location = new System.Drawing.Point(120, 305);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(27, 13);
            this.panel3.TabIndex = 15;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel4.Location = new System.Drawing.Point(120, 286);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(27, 13);
            this.panel4.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(154, 286);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Active AC Unit";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(154, 303);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Inactive AC Unit";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel5.Location = new System.Drawing.Point(248, 305);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(27, 13);
            this.panel5.TabIndex = 16;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Silver;
            this.panel6.Location = new System.Drawing.Point(248, 286);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(27, 13);
            this.panel6.TabIndex = 17;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(280, 286);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 13);
            this.label12.TabIndex = 19;
            this.label12.Text = "Active Fan";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(280, 305);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 13);
            this.label13.TabIndex = 20;
            this.label13.Text = "Inactive Fan";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Lime;
            this.panel7.Location = new System.Drawing.Point(12, 324);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(27, 13);
            this.panel7.TabIndex = 15;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(48, 324);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(89, 13);
            this.label14.TabIndex = 21;
            this.label14.Text = "Active Machinery";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Red;
            this.panel8.Location = new System.Drawing.Point(147, 324);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(27, 13);
            this.panel8.TabIndex = 16;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(181, 324);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(97, 13);
            this.label15.TabIndex = 22;
            this.label15.Text = "Inactive Machinery";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 349);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pnl_AC4);
            this.Controls.Add(this.pnl_AC3);
            this.Controls.Add(this.pnl_AC1);
            this.Controls.Add(this.pnl_AC2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnl_Office2);
            this.Controls.Add(this.pnl_Office1);
            this.Controls.Add(this.pnl_Garage);
            this.Controls.Add(this.pnl_Warehouse);
            this.Controls.Add(this.pnl_FactoryFloor);
            this.Controls.Add(this.btn_Facade);
            this.Controls.Add(this.cmb_Mode);
            this.Name = "Form1";
            this.Text = "Factory Facade";
            this.pnl_FactoryFloor.ResumeLayout(false);
            this.pnl_FactoryFloor.PerformLayout();
            this.pnl_Warehouse.ResumeLayout(false);
            this.pnl_Warehouse.PerformLayout();
            this.pnl_Garage.ResumeLayout(false);
            this.pnl_Garage.PerformLayout();
            this.pnl_Office1.ResumeLayout(false);
            this.pnl_Office1.PerformLayout();
            this.pnl_Office2.ResumeLayout(false);
            this.pnl_Office2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_Mode;
        private System.Windows.Forms.Button btn_Facade;
        private System.Windows.Forms.Panel pnl_FactoryFloor;
        private System.Windows.Forms.Panel pnl_Warehouse;
        private System.Windows.Forms.Panel pnl_Garage;
        private System.Windows.Forms.Panel pnl_Office1;
        private System.Windows.Forms.Panel pnl_Office2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pnl_AC2;
        private System.Windows.Forms.Panel pnl_AC1;
        private System.Windows.Forms.Panel pnl_AC3;
        private System.Windows.Forms.Panel pnl_AC4;
        private System.Windows.Forms.Panel pnl_Fan2;
        private System.Windows.Forms.Panel pnl_Fan1;
        private System.Windows.Forms.Panel pnl_Fan3;
        private System.Windows.Forms.Panel pnl_Fan4;
        private System.Windows.Forms.Panel pnl_machine2;
        private System.Windows.Forms.Panel pnl_machine1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label15;
    }
}


namespace StatePattern
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
            this.lb_energyList = new System.Windows.Forms.ListBox();
            this.btn_charge = new System.Windows.Forms.Button();
            this.btn_discharge = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_energyList
            // 
            this.lb_energyList.FormattingEnabled = true;
            this.lb_energyList.Location = new System.Drawing.Point(13, 13);
            this.lb_energyList.Name = "lb_energyList";
            this.lb_energyList.Size = new System.Drawing.Size(120, 238);
            this.lb_energyList.TabIndex = 0;
            this.lb_energyList.SelectedIndexChanged += new System.EventHandler(this.lb_energyList_SelectedIndexChanged);
            // 
            // btn_charge
            // 
            this.btn_charge.Enabled = false;
            this.btn_charge.Location = new System.Drawing.Point(140, 13);
            this.btn_charge.Name = "btn_charge";
            this.btn_charge.Size = new System.Drawing.Size(75, 23);
            this.btn_charge.TabIndex = 1;
            this.btn_charge.Text = "Charge";
            this.btn_charge.UseVisualStyleBackColor = true;
            this.btn_charge.Click += new System.EventHandler(this.btn_charge_Click);
            // 
            // btn_discharge
            // 
            this.btn_discharge.Enabled = false;
            this.btn_discharge.Location = new System.Drawing.Point(140, 43);
            this.btn_discharge.Name = "btn_discharge";
            this.btn_discharge.Size = new System.Drawing.Size(75, 23);
            this.btn_discharge.TabIndex = 2;
            this.btn_discharge.Text = "Discharge";
            this.btn_discharge.UseVisualStyleBackColor = true;
            this.btn_discharge.Click += new System.EventHandler(this.btn_discharge_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btn_discharge);
            this.Controls.Add(this.btn_charge);
            this.Controls.Add(this.lb_energyList);
            this.Name = "Form1";
            this.Text = "Energy Manager";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lb_energyList;
        private System.Windows.Forms.Button btn_charge;
        private System.Windows.Forms.Button btn_discharge;
    }
}


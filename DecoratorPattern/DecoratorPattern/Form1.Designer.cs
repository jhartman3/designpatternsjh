namespace DecoratorPattern
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
            this.lb_knights = new System.Windows.Forms.ListBox();
            this.lb_feedback = new System.Windows.Forms.ListBox();
            this.btn_recruit = new System.Windows.Forms.Button();
            this.btn_spear = new System.Windows.Forms.Button();
            this.btn_shield = new System.Windows.Forms.Button();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.btn_attack = new System.Windows.Forms.Button();
            this.btn_charge = new System.Windows.Forms.Button();
            this.btn_defend = new System.Windows.Forms.Button();
            this.btn_dropdefense = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_knights
            // 
            this.lb_knights.FormattingEnabled = true;
            this.lb_knights.Location = new System.Drawing.Point(13, 13);
            this.lb_knights.Name = "lb_knights";
            this.lb_knights.Size = new System.Drawing.Size(120, 238);
            this.lb_knights.TabIndex = 0;
            this.lb_knights.SelectedIndexChanged += new System.EventHandler(this.lb_knights_SelectedIndexChanged);
            // 
            // lb_feedback
            // 
            this.lb_feedback.FormattingEnabled = true;
            this.lb_feedback.Location = new System.Drawing.Point(140, 154);
            this.lb_feedback.Name = "lb_feedback";
            this.lb_feedback.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lb_feedback.Size = new System.Drawing.Size(323, 95);
            this.lb_feedback.TabIndex = 1;
            // 
            // btn_recruit
            // 
            this.btn_recruit.Location = new System.Drawing.Point(388, 13);
            this.btn_recruit.Name = "btn_recruit";
            this.btn_recruit.Size = new System.Drawing.Size(75, 20);
            this.btn_recruit.TabIndex = 2;
            this.btn_recruit.Text = "Recruit";
            this.btn_recruit.UseVisualStyleBackColor = true;
            this.btn_recruit.Click += new System.EventHandler(this.btn_recruit_Click);
            // 
            // btn_spear
            // 
            this.btn_spear.Enabled = false;
            this.btn_spear.Location = new System.Drawing.Point(140, 43);
            this.btn_spear.Name = "btn_spear";
            this.btn_spear.Size = new System.Drawing.Size(75, 23);
            this.btn_spear.TabIndex = 3;
            this.btn_spear.Text = "Give Spear";
            this.btn_spear.UseVisualStyleBackColor = true;
            this.btn_spear.Click += new System.EventHandler(this.btn_spear_Click);
            // 
            // btn_shield
            // 
            this.btn_shield.Enabled = false;
            this.btn_shield.Location = new System.Drawing.Point(140, 73);
            this.btn_shield.Name = "btn_shield";
            this.btn_shield.Size = new System.Drawing.Size(75, 23);
            this.btn_shield.TabIndex = 4;
            this.btn_shield.Text = "Give Shield";
            this.btn_shield.UseVisualStyleBackColor = true;
            this.btn_shield.Click += new System.EventHandler(this.btn_shield_Click);
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(140, 13);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(242, 20);
            this.tb_name.TabIndex = 5;
            // 
            // btn_attack
            // 
            this.btn_attack.Enabled = false;
            this.btn_attack.Location = new System.Drawing.Point(140, 125);
            this.btn_attack.Name = "btn_attack";
            this.btn_attack.Size = new System.Drawing.Size(75, 23);
            this.btn_attack.TabIndex = 6;
            this.btn_attack.Text = "Attack";
            this.btn_attack.UseVisualStyleBackColor = true;
            this.btn_attack.Click += new System.EventHandler(this.btn_attack_Click);
            // 
            // btn_charge
            // 
            this.btn_charge.Enabled = false;
            this.btn_charge.Location = new System.Drawing.Point(222, 125);
            this.btn_charge.Name = "btn_charge";
            this.btn_charge.Size = new System.Drawing.Size(75, 23);
            this.btn_charge.TabIndex = 7;
            this.btn_charge.Text = "Charge";
            this.btn_charge.UseVisualStyleBackColor = true;
            this.btn_charge.Click += new System.EventHandler(this.btn_charge_Click);
            // 
            // btn_defend
            // 
            this.btn_defend.Enabled = false;
            this.btn_defend.Location = new System.Drawing.Point(304, 125);
            this.btn_defend.Name = "btn_defend";
            this.btn_defend.Size = new System.Drawing.Size(75, 23);
            this.btn_defend.TabIndex = 8;
            this.btn_defend.Text = "Defend";
            this.btn_defend.UseVisualStyleBackColor = true;
            this.btn_defend.Click += new System.EventHandler(this.btn_defend_Click);
            // 
            // btn_dropdefense
            // 
            this.btn_dropdefense.Enabled = false;
            this.btn_dropdefense.Location = new System.Drawing.Point(386, 125);
            this.btn_dropdefense.Name = "btn_dropdefense";
            this.btn_dropdefense.Size = new System.Drawing.Size(77, 23);
            this.btn_dropdefense.TabIndex = 9;
            this.btn_dropdefense.Text = "Lower Shield";
            this.btn_dropdefense.UseVisualStyleBackColor = true;
            this.btn_dropdefense.Click += new System.EventHandler(this.btn_dropdefense_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 261);
            this.Controls.Add(this.btn_dropdefense);
            this.Controls.Add(this.btn_defend);
            this.Controls.Add(this.btn_charge);
            this.Controls.Add(this.btn_attack);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.btn_shield);
            this.Controls.Add(this.btn_spear);
            this.Controls.Add(this.btn_recruit);
            this.Controls.Add(this.lb_feedback);
            this.Controls.Add(this.lb_knights);
            this.Name = "Form1";
            this.Text = "Armory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb_knights;
        private System.Windows.Forms.ListBox lb_feedback;
        private System.Windows.Forms.Button btn_recruit;
        private System.Windows.Forms.Button btn_spear;
        private System.Windows.Forms.Button btn_shield;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Button btn_attack;
        private System.Windows.Forms.Button btn_charge;
        private System.Windows.Forms.Button btn_defend;
        private System.Windows.Forms.Button btn_dropdefense;
    }
}


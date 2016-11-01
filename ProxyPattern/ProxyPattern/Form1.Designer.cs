namespace ProxyPattern
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
            this.rb_shields = new System.Windows.Forms.RadioButton();
            this.rb_hull = new System.Windows.Forms.RadioButton();
            this.rb_power = new System.Windows.Forms.RadioButton();
            this.rb_weapons = new System.Windows.Forms.RadioButton();
            this.rb_sensors = new System.Windows.Forms.RadioButton();
            this.rb_comms = new System.Windows.Forms.RadioButton();
            this.btn_ask = new System.Windows.Forms.Button();
            this.btn_fire = new System.Windows.Forms.Button();
            this.btn_jam = new System.Windows.Forms.Button();
            this.btn_explode = new System.Windows.Forms.Button();
            this.lb_status = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_comms);
            this.groupBox1.Controls.Add(this.rb_sensors);
            this.groupBox1.Controls.Add(this.rb_weapons);
            this.groupBox1.Controls.Add(this.rb_power);
            this.groupBox1.Controls.Add(this.rb_hull);
            this.groupBox1.Controls.Add(this.rb_shields);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(212, 169);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Questions";
            // 
            // rb_shields
            // 
            this.rb_shields.AutoSize = true;
            this.rb_shields.Checked = true;
            this.rb_shields.Location = new System.Drawing.Point(7, 20);
            this.rb_shields.Name = "rb_shields";
            this.rb_shields.Size = new System.Drawing.Size(143, 17);
            this.rb_shields.TabIndex = 0;
            this.rb_shields.TabStop = true;
            this.rb_shields.Text = "What\'s our shield status?";
            this.rb_shields.UseVisualStyleBackColor = true;
            // 
            // rb_hull
            // 
            this.rb_hull.AutoSize = true;
            this.rb_hull.Location = new System.Drawing.Point(7, 44);
            this.rb_hull.Name = "rb_hull";
            this.rb_hull.Size = new System.Drawing.Size(97, 17);
            this.rb_hull.TabIndex = 1;
            this.rb_hull.TabStop = true;
            this.rb_hull.Text = "How\'s the hull?";
            this.rb_hull.UseVisualStyleBackColor = true;
            // 
            // rb_power
            // 
            this.rb_power.AutoSize = true;
            this.rb_power.Location = new System.Drawing.Point(7, 68);
            this.rb_power.Name = "rb_power";
            this.rb_power.Size = new System.Drawing.Size(139, 17);
            this.rb_power.TabIndex = 2;
            this.rb_power.TabStop = true;
            this.rb_power.Text = "What\'s our power level?";
            this.rb_power.UseVisualStyleBackColor = true;
            // 
            // rb_weapons
            // 
            this.rb_weapons.AutoSize = true;
            this.rb_weapons.Location = new System.Drawing.Point(7, 92);
            this.rb_weapons.Name = "rb_weapons";
            this.rb_weapons.Size = new System.Drawing.Size(204, 17);
            this.rb_weapons.TabIndex = 3;
            this.rb_weapons.TabStop = true;
            this.rb_weapons.Text = "What weapons do we have on hand?";
            this.rb_weapons.UseVisualStyleBackColor = true;
            // 
            // rb_sensors
            // 
            this.rb_sensors.AutoSize = true;
            this.rb_sensors.Location = new System.Drawing.Point(7, 116);
            this.rb_sensors.Name = "rb_sensors";
            this.rb_sensors.Size = new System.Drawing.Size(159, 17);
            this.rb_sensors.TabIndex = 4;
            this.rb_sensors.TabStop = true;
            this.rb_sensors.Text = "Are the sensors functioning?";
            this.rb_sensors.UseVisualStyleBackColor = true;
            // 
            // rb_comms
            // 
            this.rb_comms.AutoSize = true;
            this.rb_comms.Location = new System.Drawing.Point(7, 140);
            this.rb_comms.Name = "rb_comms";
            this.rb_comms.Size = new System.Drawing.Size(166, 17);
            this.rb_comms.TabIndex = 5;
            this.rb_comms.TabStop = true;
            this.rb_comms.Text = "Are communications working?";
            this.rb_comms.UseVisualStyleBackColor = true;
            // 
            // btn_ask
            // 
            this.btn_ask.Location = new System.Drawing.Point(232, 13);
            this.btn_ask.Name = "btn_ask";
            this.btn_ask.Size = new System.Drawing.Size(75, 23);
            this.btn_ask.TabIndex = 1;
            this.btn_ask.Text = "Ask";
            this.btn_ask.UseVisualStyleBackColor = true;
            this.btn_ask.Click += new System.EventHandler(this.btn_ask_Click);
            // 
            // btn_fire
            // 
            this.btn_fire.Location = new System.Drawing.Point(232, 43);
            this.btn_fire.Name = "btn_fire";
            this.btn_fire.Size = new System.Drawing.Size(75, 23);
            this.btn_fire.TabIndex = 2;
            this.btn_fire.Text = "Fire";
            this.btn_fire.UseVisualStyleBackColor = true;
            this.btn_fire.Click += new System.EventHandler(this.btn_fire_Click);
            // 
            // btn_jam
            // 
            this.btn_jam.Location = new System.Drawing.Point(232, 73);
            this.btn_jam.Name = "btn_jam";
            this.btn_jam.Size = new System.Drawing.Size(75, 23);
            this.btn_jam.TabIndex = 3;
            this.btn_jam.Text = "Jam";
            this.btn_jam.UseVisualStyleBackColor = true;
            this.btn_jam.Click += new System.EventHandler(this.btn_jam_Click);
            // 
            // btn_explode
            // 
            this.btn_explode.Location = new System.Drawing.Point(232, 103);
            this.btn_explode.Name = "btn_explode";
            this.btn_explode.Size = new System.Drawing.Size(75, 23);
            this.btn_explode.TabIndex = 4;
            this.btn_explode.Text = "Detonate";
            this.btn_explode.UseVisualStyleBackColor = true;
            this.btn_explode.Click += new System.EventHandler(this.btn_explode_Click);
            // 
            // lb_status
            // 
            this.lb_status.FormattingEnabled = true;
            this.lb_status.Location = new System.Drawing.Point(13, 189);
            this.lb_status.Name = "lb_status";
            this.lb_status.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lb_status.Size = new System.Drawing.Size(294, 108);
            this.lb_status.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 313);
            this.Controls.Add(this.lb_status);
            this.Controls.Add(this.btn_explode);
            this.Controls.Add(this.btn_jam);
            this.Controls.Add(this.btn_fire);
            this.Controls.Add(this.btn_ask);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Captain\'s Console";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_shields;
        private System.Windows.Forms.RadioButton rb_hull;
        private System.Windows.Forms.RadioButton rb_power;
        private System.Windows.Forms.RadioButton rb_weapons;
        private System.Windows.Forms.RadioButton rb_sensors;
        private System.Windows.Forms.RadioButton rb_comms;
        private System.Windows.Forms.Button btn_ask;
        private System.Windows.Forms.Button btn_fire;
        private System.Windows.Forms.Button btn_jam;
        private System.Windows.Forms.Button btn_explode;
        private System.Windows.Forms.ListBox lb_status;
    }
}


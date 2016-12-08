namespace TemplateMethod
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
            this.label2 = new System.Windows.Forms.Label();
            this.spin_setcount = new System.Windows.Forms.NumericUpDown();
            this.spin_choosecount = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_permutation = new System.Windows.Forms.RadioButton();
            this.rb_combinations = new System.Windows.Forms.RadioButton();
            this.btn_calculate = new System.Windows.Forms.Button();
            this.lb_result = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.spin_setcount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spin_choosecount)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of elements in the set:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Number of elements to choose:";
            // 
            // spin_setcount
            // 
            this.spin_setcount.Location = new System.Drawing.Point(170, 12);
            this.spin_setcount.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.spin_setcount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spin_setcount.Name = "spin_setcount";
            this.spin_setcount.Size = new System.Drawing.Size(46, 20);
            this.spin_setcount.TabIndex = 3;
            this.spin_setcount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // spin_choosecount
            // 
            this.spin_choosecount.Location = new System.Drawing.Point(170, 38);
            this.spin_choosecount.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.spin_choosecount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spin_choosecount.Name = "spin_choosecount";
            this.spin_choosecount.Size = new System.Drawing.Size(46, 20);
            this.spin_choosecount.TabIndex = 4;
            this.spin_choosecount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_combinations);
            this.groupBox1.Controls.Add(this.rb_permutation);
            this.groupBox1.Location = new System.Drawing.Point(12, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 71);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Calculate";
            // 
            // rb_permutation
            // 
            this.rb_permutation.AutoSize = true;
            this.rb_permutation.Checked = true;
            this.rb_permutation.Location = new System.Drawing.Point(7, 20);
            this.rb_permutation.Name = "rb_permutation";
            this.rb_permutation.Size = new System.Drawing.Size(86, 17);
            this.rb_permutation.TabIndex = 0;
            this.rb_permutation.TabStop = true;
            this.rb_permutation.Text = "Permutations";
            this.rb_permutation.UseVisualStyleBackColor = true;
            this.rb_permutation.CheckedChanged += new System.EventHandler(this.rb_permutation_CheckedChanged);
            // 
            // rb_combinations
            // 
            this.rb_combinations.AutoSize = true;
            this.rb_combinations.Location = new System.Drawing.Point(7, 44);
            this.rb_combinations.Name = "rb_combinations";
            this.rb_combinations.Size = new System.Drawing.Size(88, 17);
            this.rb_combinations.TabIndex = 1;
            this.rb_combinations.TabStop = true;
            this.rb_combinations.Text = "Combinations";
            this.rb_combinations.UseVisualStyleBackColor = true;
            this.rb_combinations.CheckedChanged += new System.EventHandler(this.rb_combinations_CheckedChanged);
            // 
            // btn_calculate
            // 
            this.btn_calculate.Location = new System.Drawing.Point(12, 143);
            this.btn_calculate.Name = "btn_calculate";
            this.btn_calculate.Size = new System.Drawing.Size(75, 23);
            this.btn_calculate.TabIndex = 6;
            this.btn_calculate.Text = "Calculate";
            this.btn_calculate.UseVisualStyleBackColor = true;
            this.btn_calculate.Click += new System.EventHandler(this.btn_calculate_Click);
            // 
            // lb_result
            // 
            this.lb_result.FormattingEnabled = true;
            this.lb_result.Location = new System.Drawing.Point(12, 173);
            this.lb_result.Name = "lb_result";
            this.lb_result.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lb_result.Size = new System.Drawing.Size(260, 82);
            this.lb_result.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lb_result);
            this.Controls.Add(this.btn_calculate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.spin_choosecount);
            this.Controls.Add(this.spin_setcount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Set Counter";
            ((System.ComponentModel.ISupportInitialize)(this.spin_setcount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spin_choosecount)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown spin_setcount;
        private System.Windows.Forms.NumericUpDown spin_choosecount;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_combinations;
        private System.Windows.Forms.RadioButton rb_permutation;
        private System.Windows.Forms.Button btn_calculate;
        private System.Windows.Forms.ListBox lb_result;
    }
}


namespace StrategyPattern
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
            this.lb_numList = new System.Windows.Forms.ListBox();
            this.cb_sortType = new System.Windows.Forms.ComboBox();
            this.nud_newNum = new System.Windows.Forms.NumericUpDown();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_sort = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nud_newNum)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_numList
            // 
            this.lb_numList.FormattingEnabled = true;
            this.lb_numList.Location = new System.Drawing.Point(13, 13);
            this.lb_numList.Name = "lb_numList";
            this.lb_numList.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lb_numList.Size = new System.Drawing.Size(120, 238);
            this.lb_numList.TabIndex = 0;
            // 
            // cb_sortType
            // 
            this.cb_sortType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_sortType.FormattingEnabled = true;
            this.cb_sortType.Items.AddRange(new object[] {
            "Insertion Sort",
            "Selection Sort",
            "Bubble Sort"});
            this.cb_sortType.Location = new System.Drawing.Point(139, 39);
            this.cb_sortType.Name = "cb_sortType";
            this.cb_sortType.Size = new System.Drawing.Size(132, 21);
            this.cb_sortType.TabIndex = 1;
            this.cb_sortType.SelectedIndexChanged += new System.EventHandler(this.cb_sortType_SelectedIndexChanged);
            // 
            // nud_newNum
            // 
            this.nud_newNum.Location = new System.Drawing.Point(140, 13);
            this.nud_newNum.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.nud_newNum.Name = "nud_newNum";
            this.nud_newNum.ReadOnly = true;
            this.nud_newNum.Size = new System.Drawing.Size(43, 20);
            this.nud_newNum.TabIndex = 2;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(190, 13);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(82, 20);
            this.btn_add.TabIndex = 3;
            this.btn_add.Text = "Add Number";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_sort
            // 
            this.btn_sort.Location = new System.Drawing.Point(139, 67);
            this.btn_sort.Name = "btn_sort";
            this.btn_sort.Size = new System.Drawing.Size(132, 23);
            this.btn_sort.TabIndex = 4;
            this.btn_sort.Text = "Sort List";
            this.btn_sort.UseVisualStyleBackColor = true;
            this.btn_sort.Click += new System.EventHandler(this.btn_sort_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btn_sort);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.nud_newNum);
            this.Controls.Add(this.cb_sortType);
            this.Controls.Add(this.lb_numList);
            this.Name = "Form1";
            this.Text = "Sort Selector";
            ((System.ComponentModel.ISupportInitialize)(this.nud_newNum)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lb_numList;
        private System.Windows.Forms.ComboBox cb_sortType;
        private System.Windows.Forms.NumericUpDown nud_newNum;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_sort;
    }
}


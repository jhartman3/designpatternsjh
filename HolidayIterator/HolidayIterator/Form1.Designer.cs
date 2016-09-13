namespace HolidayIterator
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
            this.btn_View = new System.Windows.Forms.Button();
            this.cb_ByDate = new System.Windows.Forms.CheckBox();
            this.cb_MonthChoose = new System.Windows.Forms.ComboBox();
            this.lb_Collection = new System.Windows.Forms.ListBox();
            this.btn_Reverse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_View
            // 
            this.btn_View.Location = new System.Drawing.Point(13, 13);
            this.btn_View.Name = "btn_View";
            this.btn_View.Size = new System.Drawing.Size(75, 23);
            this.btn_View.TabIndex = 0;
            this.btn_View.Text = "View";
            this.btn_View.UseVisualStyleBackColor = true;
            this.btn_View.Click += new System.EventHandler(this.btn_View_Click);
            // 
            // cb_ByDate
            // 
            this.cb_ByDate.AutoSize = true;
            this.cb_ByDate.Location = new System.Drawing.Point(13, 43);
            this.cb_ByDate.Name = "cb_ByDate";
            this.cb_ByDate.Size = new System.Drawing.Size(107, 17);
            this.cb_ByDate.TabIndex = 1;
            this.cb_ByDate.Text = "Search by Month";
            this.cb_ByDate.UseVisualStyleBackColor = true;
            // 
            // cb_MonthChoose
            // 
            this.cb_MonthChoose.FormattingEnabled = true;
            this.cb_MonthChoose.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.cb_MonthChoose.Location = new System.Drawing.Point(127, 43);
            this.cb_MonthChoose.Name = "cb_MonthChoose";
            this.cb_MonthChoose.Size = new System.Drawing.Size(121, 21);
            this.cb_MonthChoose.TabIndex = 2;
            // 
            // lb_Collection
            // 
            this.lb_Collection.FormattingEnabled = true;
            this.lb_Collection.Location = new System.Drawing.Point(13, 80);
            this.lb_Collection.Name = "lb_Collection";
            this.lb_Collection.Size = new System.Drawing.Size(259, 238);
            this.lb_Collection.TabIndex = 3;
            // 
            // btn_Reverse
            // 
            this.btn_Reverse.Location = new System.Drawing.Point(95, 13);
            this.btn_Reverse.Name = "btn_Reverse";
            this.btn_Reverse.Size = new System.Drawing.Size(75, 23);
            this.btn_Reverse.TabIndex = 4;
            this.btn_Reverse.Text = "Reverse";
            this.btn_Reverse.UseVisualStyleBackColor = true;
            this.btn_Reverse.Click += new System.EventHandler(this.btn_Reverse_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 326);
            this.Controls.Add(this.btn_Reverse);
            this.Controls.Add(this.lb_Collection);
            this.Controls.Add(this.cb_MonthChoose);
            this.Controls.Add(this.cb_ByDate);
            this.Controls.Add(this.btn_View);
            this.Name = "Form1";
            this.Text = "Holiday Iterator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_View;
        private System.Windows.Forms.CheckBox cb_ByDate;
        private System.Windows.Forms.ComboBox cb_MonthChoose;
        private System.Windows.Forms.ListBox lb_Collection;
        private System.Windows.Forms.Button btn_Reverse;
    }
}


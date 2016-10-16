namespace CompositePattern
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
            this.lb_compoundList = new System.Windows.Forms.ListBox();
            this.lb_newCompound = new System.Windows.Forms.ListBox();
            this.cb_newItem = new System.Windows.Forms.ComboBox();
            this.btn_addItem = new System.Windows.Forms.Button();
            this.btn_create = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_compoundList
            // 
            this.lb_compoundList.FormattingEnabled = true;
            this.lb_compoundList.Location = new System.Drawing.Point(13, 13);
            this.lb_compoundList.Name = "lb_compoundList";
            this.lb_compoundList.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lb_compoundList.Size = new System.Drawing.Size(133, 238);
            this.lb_compoundList.TabIndex = 0;
            // 
            // lb_newCompound
            // 
            this.lb_newCompound.FormattingEnabled = true;
            this.lb_newCompound.Location = new System.Drawing.Point(153, 69);
            this.lb_newCompound.Name = "lb_newCompound";
            this.lb_newCompound.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lb_newCompound.Size = new System.Drawing.Size(120, 147);
            this.lb_newCompound.TabIndex = 1;
            // 
            // cb_newItem
            // 
            this.cb_newItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_newItem.FormattingEnabled = true;
            this.cb_newItem.Items.AddRange(new object[] {
            "Methane Group",
            "Benzene Ring",
            "Cyclic Bond"});
            this.cb_newItem.Location = new System.Drawing.Point(152, 13);
            this.cb_newItem.Name = "cb_newItem";
            this.cb_newItem.Size = new System.Drawing.Size(121, 21);
            this.cb_newItem.TabIndex = 2;
            // 
            // btn_addItem
            // 
            this.btn_addItem.Location = new System.Drawing.Point(153, 40);
            this.btn_addItem.Name = "btn_addItem";
            this.btn_addItem.Size = new System.Drawing.Size(120, 23);
            this.btn_addItem.TabIndex = 3;
            this.btn_addItem.Text = "Add Item";
            this.btn_addItem.UseVisualStyleBackColor = true;
            this.btn_addItem.Click += new System.EventHandler(this.btn_addItem_Click);
            // 
            // btn_create
            // 
            this.btn_create.Location = new System.Drawing.Point(153, 227);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(119, 23);
            this.btn_create.TabIndex = 4;
            this.btn_create.Text = "Create Compound";
            this.btn_create.UseVisualStyleBackColor = true;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btn_create);
            this.Controls.Add(this.btn_addItem);
            this.Controls.Add(this.cb_newItem);
            this.Controls.Add(this.lb_newCompound);
            this.Controls.Add(this.lb_compoundList);
            this.Name = "Form1";
            this.Text = "Compound Creator";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lb_compoundList;
        private System.Windows.Forms.ListBox lb_newCompound;
        private System.Windows.Forms.ComboBox cb_newItem;
        private System.Windows.Forms.Button btn_addItem;
        private System.Windows.Forms.Button btn_create;
    }
}


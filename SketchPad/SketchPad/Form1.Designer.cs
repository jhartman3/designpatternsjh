namespace SketchPad
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
            this.pnl_canvas = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_rect = new System.Windows.Forms.RadioButton();
            this.rb_circle = new System.Windows.Forms.RadioButton();
            this.btn_undo = new System.Windows.Forms.Button();
            this.btn_redo = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_canvas
            // 
            this.pnl_canvas.BackColor = System.Drawing.Color.White;
            this.pnl_canvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_canvas.Location = new System.Drawing.Point(13, 13);
            this.pnl_canvas.Name = "pnl_canvas";
            this.pnl_canvas.Size = new System.Drawing.Size(259, 236);
            this.pnl_canvas.TabIndex = 0;
            this.pnl_canvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_canvas_MouseDown);
            this.pnl_canvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnl_canvas_MouseMove);
            this.pnl_canvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnl_canvas_MouseUp);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_circle);
            this.groupBox1.Controls.Add(this.rb_rect);
            this.groupBox1.Location = new System.Drawing.Point(279, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(86, 178);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Shapes";
            // 
            // rb_rect
            // 
            this.rb_rect.AutoSize = true;
            this.rb_rect.Location = new System.Drawing.Point(7, 20);
            this.rb_rect.Name = "rb_rect";
            this.rb_rect.Size = new System.Drawing.Size(74, 17);
            this.rb_rect.TabIndex = 0;
            this.rb_rect.TabStop = true;
            this.rb_rect.Text = "Rectangle";
            this.rb_rect.UseVisualStyleBackColor = true;
            this.rb_rect.CheckedChanged += new System.EventHandler(this.rb_rect_CheckedChanged);
            // 
            // rb_circle
            // 
            this.rb_circle.AutoSize = true;
            this.rb_circle.Location = new System.Drawing.Point(7, 44);
            this.rb_circle.Name = "rb_circle";
            this.rb_circle.Size = new System.Drawing.Size(51, 17);
            this.rb_circle.TabIndex = 1;
            this.rb_circle.TabStop = true;
            this.rb_circle.Text = "Circle";
            this.rb_circle.UseVisualStyleBackColor = true;
            this.rb_circle.CheckedChanged += new System.EventHandler(this.rb_circle_CheckedChanged);
            // 
            // btn_undo
            // 
            this.btn_undo.Location = new System.Drawing.Point(279, 197);
            this.btn_undo.Name = "btn_undo";
            this.btn_undo.Size = new System.Drawing.Size(75, 23);
            this.btn_undo.TabIndex = 2;
            this.btn_undo.Text = "Undo";
            this.btn_undo.UseVisualStyleBackColor = true;
            this.btn_undo.Click += new System.EventHandler(this.btn_undo_Click);
            // 
            // btn_redo
            // 
            this.btn_redo.Location = new System.Drawing.Point(279, 226);
            this.btn_redo.Name = "btn_redo";
            this.btn_redo.Size = new System.Drawing.Size(75, 23);
            this.btn_redo.TabIndex = 3;
            this.btn_redo.Text = "Redo";
            this.btn_redo.UseVisualStyleBackColor = true;
            this.btn_redo.Click += new System.EventHandler(this.btn_redo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 261);
            this.Controls.Add(this.btn_redo);
            this.Controls.Add(this.btn_undo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pnl_canvas);
            this.Name = "Form1";
            this.Text = "Sketch Pad";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_canvas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_circle;
        private System.Windows.Forms.RadioButton rb_rect;
        private System.Windows.Forms.Button btn_undo;
        private System.Windows.Forms.Button btn_redo;
    }
}


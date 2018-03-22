namespace ClickCounter.forms
{
    partial class PropertiesForm
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
            this.tb_rect_width = new System.Windows.Forms.TextBox();
            this.tb_pen_width = new System.Windows.Forms.TextBox();
            this.tb_rect_height = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_max_revert_steps = new System.Windows.Forms.TextBox();
            this.bt_save = new System.Windows.Forms.Button();
            this.bt_abort = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_rect_width);
            this.groupBox1.Controls.Add(this.tb_pen_width);
            this.groupBox1.Controls.Add(this.tb_rect_height);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(290, 145);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Drawing";
            // 
            // tb_rect_width
            // 
            this.tb_rect_width.Location = new System.Drawing.Point(171, 80);
            this.tb_rect_width.Name = "tb_rect_width";
            this.tb_rect_width.Size = new System.Drawing.Size(69, 26);
            this.tb_rect_width.TabIndex = 5;
            this.tb_rect_width.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tb_pen_width
            // 
            this.tb_pen_width.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tb_pen_width.Location = new System.Drawing.Point(171, 30);
            this.tb_pen_width.Name = "tb_pen_width";
            this.tb_pen_width.Size = new System.Drawing.Size(69, 26);
            this.tb_pen_width.TabIndex = 4;
            this.tb_pen_width.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tb_rect_height
            // 
            this.tb_rect_height.Location = new System.Drawing.Point(171, 112);
            this.tb_rect_height.Name = "tb_rect_height";
            this.tb_rect_height.Size = new System.Drawing.Size(69, 26);
            this.tb_rect_height.TabIndex = 3;
            this.tb_rect_height.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Rectangle height:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Rectangle width:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pen witdth: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tb_max_revert_steps);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 226);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(290, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Other";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Max revert steps:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 24);
            this.label5.TabIndex = 2;
            this.label5.Text = "Properties";
            // 
            // tb_max_revert_steps
            // 
            this.tb_max_revert_steps.Location = new System.Drawing.Point(171, 40);
            this.tb_max_revert_steps.Name = "tb_max_revert_steps";
            this.tb_max_revert_steps.Size = new System.Drawing.Size(69, 26);
            this.tb_max_revert_steps.TabIndex = 6;
            this.tb_max_revert_steps.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // bt_save
            // 
            this.bt_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_save.Location = new System.Drawing.Point(48, 345);
            this.bt_save.Name = "bt_save";
            this.bt_save.Size = new System.Drawing.Size(97, 33);
            this.bt_save.TabIndex = 3;
            this.bt_save.Text = "Save";
            this.bt_save.UseVisualStyleBackColor = true;
            this.bt_save.Click += new System.EventHandler(this.bt_save_Click);
            // 
            // bt_abort
            // 
            this.bt_abort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_abort.Location = new System.Drawing.Point(174, 345);
            this.bt_abort.Name = "bt_abort";
            this.bt_abort.Size = new System.Drawing.Size(97, 33);
            this.bt_abort.TabIndex = 4;
            this.bt_abort.Text = "Abort";
            this.bt_abort.UseVisualStyleBackColor = true;
            this.bt_abort.Click += new System.EventHandler(this.bt_abort_Click);
            // 
            // PropertiesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 406);
            this.Controls.Add(this.bt_abort);
            this.Controls.Add(this.bt_save);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "PropertiesForm";
            this.Text = "Properties";
            this.Load += new System.EventHandler(this.PropertiesForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_rect_width;
        private System.Windows.Forms.TextBox tb_pen_width;
        private System.Windows.Forms.TextBox tb_rect_height;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_max_revert_steps;
        private System.Windows.Forms.Button bt_save;
        private System.Windows.Forms.Button bt_abort;
    }
}
using System.Drawing;
namespace ClickCounter
{
    partial class MainView
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
            this.lb_counter1 = new System.Windows.Forms.Label();
            this.bt_start = new System.Windows.Forms.Button();
            this.bt_stop = new System.Windows.Forms.Button();
            this.pb_picture = new System.Windows.Forms.PictureBox();
            this.bt_load = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStrip_loadedImage = new System.Windows.Forms.ToolStripStatusLabel();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.gb_clickCounters = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_counter3 = new System.Windows.Forms.Label();
            this.lb_counter2 = new System.Windows.Forms.Label();
            this.rb_counter2 = new ClickCounter.SelectionButton();
            this.rb_counter3 = new ClickCounter.SelectionButton();
            this.rb_counter1 = new ClickCounter.SelectionButton();
            this.b_revert = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.propertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pb_picture)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.gb_clickCounters.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_counter1
            // 
            this.lb_counter1.AutoSize = true;
            this.lb_counter1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_counter1.Location = new System.Drawing.Point(124, 24);
            this.lb_counter1.Name = "lb_counter1";
            this.lb_counter1.Size = new System.Drawing.Size(16, 17);
            this.lb_counter1.TabIndex = 0;
            this.lb_counter1.Text = "0";
            // 
            // bt_start
            // 
            this.bt_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_start.Location = new System.Drawing.Point(12, 209);
            this.bt_start.Name = "bt_start";
            this.bt_start.Size = new System.Drawing.Size(124, 35);
            this.bt_start.TabIndex = 2;
            this.bt_start.Text = "Start counting";
            this.bt_start.UseVisualStyleBackColor = true;
            this.bt_start.Click += new System.EventHandler(this.bt_start_Click);
            // 
            // bt_stop
            // 
            this.bt_stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_stop.Location = new System.Drawing.Point(12, 250);
            this.bt_stop.Name = "bt_stop";
            this.bt_stop.Size = new System.Drawing.Size(124, 35);
            this.bt_stop.TabIndex = 3;
            this.bt_stop.Text = "Stop";
            this.bt_stop.UseVisualStyleBackColor = true;
            this.bt_stop.Click += new System.EventHandler(this.bt_stop_Click);
            // 
            // pb_picture
            // 
            this.pb_picture.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_picture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pb_picture.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pb_picture.Location = new System.Drawing.Point(185, 27);
            this.pb_picture.Name = "pb_picture";
            this.pb_picture.Size = new System.Drawing.Size(637, 385);
            this.pb_picture.TabIndex = 5;
            this.pb_picture.TabStop = false;
            this.pb_picture.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pb_picture_MouseUp);
            // 
            // bt_load
            // 
            this.bt_load.Location = new System.Drawing.Point(12, 27);
            this.bt_load.Name = "bt_load";
            this.bt_load.Size = new System.Drawing.Size(124, 35);
            this.bt_load.TabIndex = 6;
            this.bt_load.Text = "Load image";
            this.bt_load.UseVisualStyleBackColor = true;
            this.bt_load.Click += new System.EventHandler(this.bt_load_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStrip_loadedImage});
            this.statusStrip1.Location = new System.Drawing.Point(0, 415);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(834, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStrip_loadedImage
            // 
            this.toolStrip_loadedImage.Name = "toolStrip_loadedImage";
            this.toolStrip_loadedImage.Size = new System.Drawing.Size(98, 17);
            this.toolStrip_loadedImage.Text = "No image loaded";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "new-image";
            // 
            // gb_clickCounters
            // 
            this.gb_clickCounters.Controls.Add(this.panel3);
            this.gb_clickCounters.Controls.Add(this.panel2);
            this.gb_clickCounters.Controls.Add(this.panel1);
            this.gb_clickCounters.Controls.Add(this.lb_counter3);
            this.gb_clickCounters.Controls.Add(this.lb_counter2);
            this.gb_clickCounters.Controls.Add(this.rb_counter2);
            this.gb_clickCounters.Controls.Add(this.rb_counter3);
            this.gb_clickCounters.Controls.Add(this.rb_counter1);
            this.gb_clickCounters.Controls.Add(this.lb_counter1);
            this.gb_clickCounters.Location = new System.Drawing.Point(12, 68);
            this.gb_clickCounters.Name = "gb_clickCounters";
            this.gb_clickCounters.Size = new System.Drawing.Size(167, 135);
            this.gb_clickCounters.TabIndex = 8;
            this.gb_clickCounters.TabStop = false;
            this.gb_clickCounters.Text = "Counters";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Blue;
            this.panel3.Location = new System.Drawing.Point(100, 107);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(13, 10);
            this.panel3.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Lime;
            this.panel2.Location = new System.Drawing.Point(100, 69);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(13, 10);
            this.panel2.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Location = new System.Drawing.Point(100, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(13, 10);
            this.panel1.TabIndex = 7;
            // 
            // lb_counter3
            // 
            this.lb_counter3.AutoSize = true;
            this.lb_counter3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_counter3.Location = new System.Drawing.Point(124, 98);
            this.lb_counter3.Name = "lb_counter3";
            this.lb_counter3.Size = new System.Drawing.Size(16, 17);
            this.lb_counter3.TabIndex = 6;
            this.lb_counter3.Text = "0";
            // 
            // lb_counter2
            // 
            this.lb_counter2.AutoSize = true;
            this.lb_counter2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_counter2.Location = new System.Drawing.Point(124, 60);
            this.lb_counter2.Name = "lb_counter2";
            this.lb_counter2.Size = new System.Drawing.Size(16, 17);
            this.lb_counter2.TabIndex = 5;
            this.lb_counter2.Text = "0";
            // 
            // rb_counter2
            // 
            this.rb_counter2.AutoSize = true;
            this.rb_counter2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_counter2.Location = new System.Drawing.Point(6, 58);
            this.rb_counter2.Name = "rb_counter2";
            this.rb_counter2.Size = new System.Drawing.Size(88, 21);
            this.rb_counter2.TabIndex = 4;
            this.rb_counter2.Text = "Counter 2";
            this.rb_counter2.UseVisualStyleBackColor = true;
            // 
            // rb_counter3
            // 
            this.rb_counter3.AutoSize = true;
            this.rb_counter3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_counter3.Location = new System.Drawing.Point(6, 96);
            this.rb_counter3.Name = "rb_counter3";
            this.rb_counter3.Size = new System.Drawing.Size(88, 21);
            this.rb_counter3.TabIndex = 3;
            this.rb_counter3.Text = "Counter 3";
            this.rb_counter3.UseVisualStyleBackColor = true;
            // 
            // rb_counter1
            // 
            this.rb_counter1.AutoSize = true;
            this.rb_counter1.Checked = true;
            this.rb_counter1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_counter1.Location = new System.Drawing.Point(6, 24);
            this.rb_counter1.Name = "rb_counter1";
            this.rb_counter1.Size = new System.Drawing.Size(88, 21);
            this.rb_counter1.TabIndex = 2;
            this.rb_counter1.TabStop = true;
            this.rb_counter1.Text = "Counter 1";
            this.rb_counter1.UseVisualStyleBackColor = true;
            // 
            // b_revert
            // 
            this.b_revert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_revert.Location = new System.Drawing.Point(12, 291);
            this.b_revert.Name = "b_revert";
            this.b_revert.Size = new System.Drawing.Size(124, 35);
            this.b_revert.TabIndex = 9;
            this.b_revert.Text = "Revert";
            this.b_revert.UseVisualStyleBackColor = true;
            this.b_revert.MouseClick += new System.Windows.Forms.MouseEventHandler(this.b_revert_MouseClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(834, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadImageToolStripMenuItem,
            this.propertiesToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadImageToolStripMenuItem
            // 
            this.loadImageToolStripMenuItem.Name = "loadImageToolStripMenuItem";
            this.loadImageToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.loadImageToolStripMenuItem.Text = "Load Image";
            this.loadImageToolStripMenuItem.Click += new System.EventHandler(this.loadImageToolStripMenuItem_Click);
            // 
            // propertiesToolStripMenuItem
            // 
            this.propertiesToolStripMenuItem.Name = "propertiesToolStripMenuItem";
            this.propertiesToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.propertiesToolStripMenuItem.Text = "Properties";
            this.propertiesToolStripMenuItem.Click += new System.EventHandler(this.propertiesToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(133, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(24, 20);
            this.toolStripMenuItem1.Text = "?";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 437);
            this.Controls.Add(this.b_revert);
            this.Controls.Add(this.gb_clickCounters);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.bt_load);
            this.Controls.Add(this.pb_picture);
            this.Controls.Add(this.bt_stop);
            this.Controls.Add(this.bt_start);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainView";
            this.Text = "Click Counter";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pb_picture)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.gb_clickCounters.ResumeLayout(false);
            this.gb_clickCounters.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_counter1;
        private System.Windows.Forms.Button bt_start;
        private System.Windows.Forms.Button bt_stop;
        private System.Windows.Forms.PictureBox pb_picture;
        private System.Windows.Forms.Button bt_load;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ToolStripStatusLabel toolStrip_loadedImage;
        private System.Windows.Forms.GroupBox gb_clickCounters;
        private SelectionButton rb_counter2;
        private SelectionButton rb_counter3;
        private SelectionButton rb_counter1;
        private System.Windows.Forms.Label lb_counter3;
        private System.Windows.Forms.Label lb_counter2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button b_revert;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem propertiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}


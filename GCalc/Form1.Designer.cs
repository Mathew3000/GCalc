namespace GCalc
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
            this.fbd_start = new System.Windows.Forms.FolderBrowserDialog();
            this.bt_path = new System.Windows.Forms.Button();
            this.tb_path = new System.Windows.Forms.TextBox();
            this.cb_subdir = new System.Windows.Forms.CheckBox();
            this.bt_calc = new System.Windows.Forms.Button();
            this.lb_files = new System.Windows.Forms.ListBox();
            this.bt_scan = new System.Windows.Forms.Button();
            this.tb_length = new System.Windows.Forms.TextBox();
            this.tb_weight = new System.Windows.Forms.TextBox();
            this.tb_cost = new System.Windows.Forms.TextBox();
            this.tb_h = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lb_g = new System.Windows.Forms.Label();
            this.lb_mm = new System.Windows.Forms.Label();
            this.tb_s = new System.Windows.Forms.TextBox();
            this.tb_m = new System.Windows.Forms.TextBox();
            this.bt_clear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fbd_start
            // 
            this.fbd_start.Description = "Select the folder containing gcodes";
            this.fbd_start.ShowNewFolderButton = false;
            // 
            // bt_path
            // 
            this.bt_path.Location = new System.Drawing.Point(271, 117);
            this.bt_path.Name = "bt_path";
            this.bt_path.Size = new System.Drawing.Size(44, 23);
            this.bt_path.TabIndex = 0;
            this.bt_path.Text = "...";
            this.bt_path.UseVisualStyleBackColor = true;
            this.bt_path.Click += new System.EventHandler(this.bt_path_Click);
            // 
            // tb_path
            // 
            this.tb_path.Location = new System.Drawing.Point(13, 118);
            this.tb_path.Name = "tb_path";
            this.tb_path.Size = new System.Drawing.Size(252, 22);
            this.tb_path.TabIndex = 1;
            this.tb_path.TextChanged += new System.EventHandler(this.tb_path_TextChanged);
            // 
            // cb_subdir
            // 
            this.cb_subdir.AutoSize = true;
            this.cb_subdir.Location = new System.Drawing.Point(13, 146);
            this.cb_subdir.Name = "cb_subdir";
            this.cb_subdir.Size = new System.Drawing.Size(168, 21);
            this.cb_subdir.TabIndex = 2;
            this.cb_subdir.Text = "Search subdirectories";
            this.cb_subdir.UseVisualStyleBackColor = true;
            this.cb_subdir.CheckedChanged += new System.EventHandler(this.cb_subdir_CheckedChanged);
            // 
            // bt_calc
            // 
            this.bt_calc.Location = new System.Drawing.Point(522, 117);
            this.bt_calc.Name = "bt_calc";
            this.bt_calc.Size = new System.Drawing.Size(88, 37);
            this.bt_calc.TabIndex = 3;
            this.bt_calc.Text = "Calculate";
            this.bt_calc.UseVisualStyleBackColor = true;
            this.bt_calc.Click += new System.EventHandler(this.bt_calc_Click);
            // 
            // lb_files
            // 
            this.lb_files.FormattingEnabled = true;
            this.lb_files.ItemHeight = 16;
            this.lb_files.Location = new System.Drawing.Point(12, 12);
            this.lb_files.Name = "lb_files";
            this.lb_files.Size = new System.Drawing.Size(598, 100);
            this.lb_files.TabIndex = 4;
            // 
            // bt_scan
            // 
            this.bt_scan.Location = new System.Drawing.Point(338, 117);
            this.bt_scan.Name = "bt_scan";
            this.bt_scan.Size = new System.Drawing.Size(111, 37);
            this.bt_scan.TabIndex = 3;
            this.bt_scan.Text = "Scan for files";
            this.bt_scan.UseVisualStyleBackColor = true;
            this.bt_scan.Click += new System.EventHandler(this.bt_scan_Click);
            // 
            // tb_length
            // 
            this.tb_length.Location = new System.Drawing.Point(84, 15);
            this.tb_length.Name = "tb_length";
            this.tb_length.ReadOnly = true;
            this.tb_length.Size = new System.Drawing.Size(153, 22);
            this.tb_length.TabIndex = 5;
            // 
            // tb_weight
            // 
            this.tb_weight.Location = new System.Drawing.Point(84, 43);
            this.tb_weight.Name = "tb_weight";
            this.tb_weight.ReadOnly = true;
            this.tb_weight.Size = new System.Drawing.Size(153, 22);
            this.tb_weight.TabIndex = 5;
            // 
            // tb_cost
            // 
            this.tb_cost.Location = new System.Drawing.Point(84, 71);
            this.tb_cost.Name = "tb_cost";
            this.tb_cost.ReadOnly = true;
            this.tb_cost.Size = new System.Drawing.Size(153, 22);
            this.tb_cost.TabIndex = 5;
            // 
            // tb_h
            // 
            this.tb_h.Location = new System.Drawing.Point(84, 99);
            this.tb_h.Name = "tb_h";
            this.tb_h.ReadOnly = true;
            this.tb_h.Size = new System.Drawing.Size(47, 22);
            this.tb_h.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "weight";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "cost";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "duration";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lb_g);
            this.groupBox1.Controls.Add(this.lb_mm);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tb_length);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tb_weight);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tb_cost);
            this.groupBox1.Controls.Add(this.tb_s);
            this.groupBox1.Controls.Add(this.tb_m);
            this.groupBox1.Controls.Add(this.tb_h);
            this.groupBox1.Location = new System.Drawing.Point(13, 182);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(302, 140);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Totals";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(243, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 17);
            this.label8.TabIndex = 6;
            this.label8.Text = "h m s";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(243, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "money";
            // 
            // lb_g
            // 
            this.lb_g.AutoSize = true;
            this.lb_g.Location = new System.Drawing.Point(243, 46);
            this.lb_g.Name = "lb_g";
            this.lb_g.Size = new System.Drawing.Size(16, 17);
            this.lb_g.TabIndex = 6;
            this.lb_g.Text = "g";
            this.lb_g.Click += new System.EventHandler(this.lb_g_Click);
            // 
            // lb_mm
            // 
            this.lb_mm.AutoSize = true;
            this.lb_mm.Location = new System.Drawing.Point(243, 18);
            this.lb_mm.Name = "lb_mm";
            this.lb_mm.Size = new System.Drawing.Size(30, 17);
            this.lb_mm.TabIndex = 6;
            this.lb_mm.Text = "mm";
            this.lb_mm.Click += new System.EventHandler(this.lb_mm_Click);
            // 
            // tb_s
            // 
            this.tb_s.Location = new System.Drawing.Point(190, 99);
            this.tb_s.Name = "tb_s";
            this.tb_s.ReadOnly = true;
            this.tb_s.Size = new System.Drawing.Size(47, 22);
            this.tb_s.TabIndex = 5;
            // 
            // tb_m
            // 
            this.tb_m.Location = new System.Drawing.Point(137, 99);
            this.tb_m.Name = "tb_m";
            this.tb_m.ReadOnly = true;
            this.tb_m.Size = new System.Drawing.Size(47, 22);
            this.tb_m.TabIndex = 5;
            // 
            // bt_clear
            // 
            this.bt_clear.Location = new System.Drawing.Point(455, 117);
            this.bt_clear.Name = "bt_clear";
            this.bt_clear.Size = new System.Drawing.Size(61, 37);
            this.bt_clear.TabIndex = 3;
            this.bt_clear.Text = "Clear";
            this.bt_clear.UseVisualStyleBackColor = true;
            this.bt_clear.Click += new System.EventHandler(this.bt_clear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "length";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 333);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lb_files);
            this.Controls.Add(this.bt_clear);
            this.Controls.Add(this.bt_scan);
            this.Controls.Add(this.bt_calc);
            this.Controls.Add(this.cb_subdir);
            this.Controls.Add(this.tb_path);
            this.Controls.Add(this.bt_path);
            this.Name = "Form1";
            this.Text = "GCalc";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog fbd_start;
        private System.Windows.Forms.Button bt_path;
        private System.Windows.Forms.TextBox tb_path;
        private System.Windows.Forms.CheckBox cb_subdir;
        private System.Windows.Forms.Button bt_calc;
        private System.Windows.Forms.ListBox lb_files;
        private System.Windows.Forms.Button bt_scan;
        private System.Windows.Forms.TextBox tb_length;
        private System.Windows.Forms.TextBox tb_weight;
        private System.Windows.Forms.TextBox tb_cost;
        private System.Windows.Forms.TextBox tb_h;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_s;
        private System.Windows.Forms.TextBox tb_m;
        private System.Windows.Forms.Button bt_clear;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lb_g;
        private System.Windows.Forms.Label lb_mm;
        private System.Windows.Forms.Label label1;
    }
}


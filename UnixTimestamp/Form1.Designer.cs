namespace UnixTimestamp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.numericUpDown_year = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_mon = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_day = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_hour = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_min = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_sec = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_year)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_mon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_day)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_hour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_sec)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Year";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(88, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Mon";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(144, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "Day";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(209, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "Hour";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(265, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 23);
            this.label5.TabIndex = 10;
            this.label5.Text = "Min";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(321, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 23);
            this.label6.TabIndex = 11;
            this.label6.Text = "Sec";
            this.label6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(388, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 28);
            this.button1.TabIndex = 10;
            this.button1.Text = "Setting";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 115);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(446, 27);
            this.button2.TabIndex = 8;
            this.button2.Text = "Copy";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 148);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(446, 27);
            this.button3.TabIndex = 9;
            this.button3.Text = "Exit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(12, 81);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(446, 28);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.Click += new System.EventHandler(this.textBox1_Click);
            // 
            // numericUpDown_year
            // 
            this.numericUpDown_year.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDown_year.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.numericUpDown_year.Location = new System.Drawing.Point(12, 38);
            this.numericUpDown_year.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericUpDown_year.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_year.Name = "numericUpDown_year";
            this.numericUpDown_year.Size = new System.Drawing.Size(70, 28);
            this.numericUpDown_year.TabIndex = 0;
            this.numericUpDown_year.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown_year.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_year.ValueChanged += new System.EventHandler(this.DT_Change);
            this.numericUpDown_year.Click += new System.EventHandler(this.SelectAll);
            this.numericUpDown_year.Enter += new System.EventHandler(this.SelectAll);
            // 
            // numericUpDown_mon
            // 
            this.numericUpDown_mon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDown_mon.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.numericUpDown_mon.Location = new System.Drawing.Point(88, 38);
            this.numericUpDown_mon.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericUpDown_mon.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_mon.Name = "numericUpDown_mon";
            this.numericUpDown_mon.Size = new System.Drawing.Size(50, 28);
            this.numericUpDown_mon.TabIndex = 1;
            this.numericUpDown_mon.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown_mon.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_mon.ValueChanged += new System.EventHandler(this.DT_Change);
            this.numericUpDown_mon.Click += new System.EventHandler(this.SelectAll);
            this.numericUpDown_mon.Enter += new System.EventHandler(this.SelectAll);
            // 
            // numericUpDown_day
            // 
            this.numericUpDown_day.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDown_day.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.numericUpDown_day.Location = new System.Drawing.Point(144, 38);
            this.numericUpDown_day.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.numericUpDown_day.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_day.Name = "numericUpDown_day";
            this.numericUpDown_day.Size = new System.Drawing.Size(50, 28);
            this.numericUpDown_day.TabIndex = 2;
            this.numericUpDown_day.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown_day.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_day.ValueChanged += new System.EventHandler(this.DT_Change);
            this.numericUpDown_day.Click += new System.EventHandler(this.SelectAll);
            this.numericUpDown_day.Enter += new System.EventHandler(this.SelectAll);
            // 
            // numericUpDown_hour
            // 
            this.numericUpDown_hour.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDown_hour.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.numericUpDown_hour.Location = new System.Drawing.Point(209, 38);
            this.numericUpDown_hour.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numericUpDown_hour.Name = "numericUpDown_hour";
            this.numericUpDown_hour.Size = new System.Drawing.Size(50, 28);
            this.numericUpDown_hour.TabIndex = 3;
            this.numericUpDown_hour.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown_hour.ValueChanged += new System.EventHandler(this.DT_Change);
            this.numericUpDown_hour.Click += new System.EventHandler(this.SelectAll);
            this.numericUpDown_hour.Enter += new System.EventHandler(this.SelectAll);
            // 
            // numericUpDown_min
            // 
            this.numericUpDown_min.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDown_min.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.numericUpDown_min.Location = new System.Drawing.Point(265, 38);
            this.numericUpDown_min.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numericUpDown_min.Name = "numericUpDown_min";
            this.numericUpDown_min.Size = new System.Drawing.Size(50, 28);
            this.numericUpDown_min.TabIndex = 4;
            this.numericUpDown_min.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown_min.ValueChanged += new System.EventHandler(this.DT_Change);
            this.numericUpDown_min.Click += new System.EventHandler(this.SelectAll);
            this.numericUpDown_min.Enter += new System.EventHandler(this.SelectAll);
            // 
            // numericUpDown_sec
            // 
            this.numericUpDown_sec.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDown_sec.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.numericUpDown_sec.Location = new System.Drawing.Point(321, 38);
            this.numericUpDown_sec.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numericUpDown_sec.Name = "numericUpDown_sec";
            this.numericUpDown_sec.Size = new System.Drawing.Size(50, 28);
            this.numericUpDown_sec.TabIndex = 5;
            this.numericUpDown_sec.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown_sec.ValueChanged += new System.EventHandler(this.DT_Change);
            this.numericUpDown_sec.Click += new System.EventHandler(this.SelectAll);
            this.numericUpDown_sec.Enter += new System.EventHandler(this.SelectAll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 187);
            this.Controls.Add(this.numericUpDown_sec);
            this.Controls.Add(this.numericUpDown_min);
            this.Controls.Add(this.numericUpDown_hour);
            this.Controls.Add(this.numericUpDown_day);
            this.Controls.Add(this.numericUpDown_mon);
            this.Controls.Add(this.numericUpDown_year);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "UnixTimestamp";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_year)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_mon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_day)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_hour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_sec)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox textBox1;
        private NumericUpDown numericUpDown_year;
        private NumericUpDown numericUpDown_mon;
        private NumericUpDown numericUpDown_day;
        private NumericUpDown numericUpDown_hour;
        private NumericUpDown numericUpDown_min;
        private NumericUpDown numericUpDown_sec;
    }
}
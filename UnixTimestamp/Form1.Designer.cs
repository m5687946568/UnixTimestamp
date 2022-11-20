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
            this.dateTimePicker_year = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_mon = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_day = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_sec = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_min = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_hour = new System.Windows.Forms.DateTimePicker();
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
            this.SuspendLayout();
            // 
            // dateTimePicker_year
            // 
            this.dateTimePicker_year.CustomFormat = "yyyy";
            this.dateTimePicker_year.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker_year.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_year.Location = new System.Drawing.Point(12, 38);
            this.dateTimePicker_year.Name = "dateTimePicker_year";
            this.dateTimePicker_year.ShowUpDown = true;
            this.dateTimePicker_year.Size = new System.Drawing.Size(70, 28);
            this.dateTimePicker_year.TabIndex = 0;
            this.dateTimePicker_year.ValueChanged += new System.EventHandler(this.DT_Change);
            // 
            // dateTimePicker_mon
            // 
            this.dateTimePicker_mon.CustomFormat = "MM";
            this.dateTimePicker_mon.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker_mon.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_mon.Location = new System.Drawing.Point(88, 38);
            this.dateTimePicker_mon.Name = "dateTimePicker_mon";
            this.dateTimePicker_mon.ShowUpDown = true;
            this.dateTimePicker_mon.Size = new System.Drawing.Size(50, 28);
            this.dateTimePicker_mon.TabIndex = 1;
            this.dateTimePicker_mon.ValueChanged += new System.EventHandler(this.DT_Change);
            // 
            // dateTimePicker_day
            // 
            this.dateTimePicker_day.CustomFormat = "dd";
            this.dateTimePicker_day.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker_day.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_day.Location = new System.Drawing.Point(144, 38);
            this.dateTimePicker_day.Name = "dateTimePicker_day";
            this.dateTimePicker_day.ShowUpDown = true;
            this.dateTimePicker_day.Size = new System.Drawing.Size(50, 28);
            this.dateTimePicker_day.TabIndex = 2;
            this.dateTimePicker_day.ValueChanged += new System.EventHandler(this.DT_Change);
            // 
            // dateTimePicker_sec
            // 
            this.dateTimePicker_sec.CustomFormat = "ss";
            this.dateTimePicker_sec.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker_sec.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_sec.Location = new System.Drawing.Point(321, 38);
            this.dateTimePicker_sec.Name = "dateTimePicker_sec";
            this.dateTimePicker_sec.ShowUpDown = true;
            this.dateTimePicker_sec.Size = new System.Drawing.Size(50, 28);
            this.dateTimePicker_sec.TabIndex = 5;
            this.dateTimePicker_sec.Value = new System.DateTime(2022, 11, 17, 4, 37, 8, 0);
            this.dateTimePicker_sec.ValueChanged += new System.EventHandler(this.DT_Change);
            // 
            // dateTimePicker_min
            // 
            this.dateTimePicker_min.CustomFormat = "mm";
            this.dateTimePicker_min.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker_min.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_min.Location = new System.Drawing.Point(265, 38);
            this.dateTimePicker_min.Name = "dateTimePicker_min";
            this.dateTimePicker_min.ShowUpDown = true;
            this.dateTimePicker_min.Size = new System.Drawing.Size(50, 28);
            this.dateTimePicker_min.TabIndex = 4;
            this.dateTimePicker_min.ValueChanged += new System.EventHandler(this.DT_Change);
            // 
            // dateTimePicker_hour
            // 
            this.dateTimePicker_hour.CustomFormat = "HH";
            this.dateTimePicker_hour.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker_hour.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_hour.Location = new System.Drawing.Point(209, 38);
            this.dateTimePicker_hour.Name = "dateTimePicker_hour";
            this.dateTimePicker_hour.ShowUpDown = true;
            this.dateTimePicker_hour.Size = new System.Drawing.Size(50, 28);
            this.dateTimePicker_hour.TabIndex = 3;
            this.dateTimePicker_hour.ValueChanged += new System.EventHandler(this.DT_Change);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 187);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dateTimePicker_year);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePicker_mon);
            this.Controls.Add(this.dateTimePicker_sec);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker_min);
            this.Controls.Add(this.dateTimePicker_day);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker_hour);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "UnixTimestamp";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DateTimePicker dateTimePicker_year;
        private DateTimePicker dateTimePicker_mon;
        private DateTimePicker dateTimePicker_day;
        private DateTimePicker dateTimePicker_sec;
        private DateTimePicker dateTimePicker_min;
        private DateTimePicker dateTimePicker_hour;
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
    }
}
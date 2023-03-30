using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UnixTimestamp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        #region ini setting
        [DllImport("kernel32")]
        static extern long WritePrivateProfileString(string name, string key, string val, string filePath);

        [DllImport("kernel32")]
        static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);

        string ProfilePath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Hermit_Project\";

        string GPS(string ClassName, string KeyName)
        {
            StringBuilder sb = new StringBuilder(255);
            GetPrivateProfileString(ClassName, KeyName, "", sb, 255, ProfilePath + @"UnixTimestamp.ini");
            return sb.ToString();
        }

        void WPS(string ClassName, string KeyName, string KeyValue)
        {
            WritePrivateProfileString(ClassName, KeyName, KeyValue, ProfilePath + @"UnixTimestamp.ini");
        }
        #endregion

        private void Form2_Load(object sender, EventArgs e)
        {
            numericUpDown1.Value = int.Parse(GPS("General", "UTC"));
            textBox1.Text = GPS("General", "CustomString");
        }

        public void GetUT(string UT)
        {
            textBox1.Tag = int.Parse(UT) + (int.Parse(GPS("General", "UTC")) * 60 * 60);
        }

        private void Text_Change(object sender, EventArgs e)
        {
            label3.Text = textBox1.Text.Replace("%UT%", ((int)textBox1.Tag - numericUpDown1.Value * 60 * 60).ToString());
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            WPS("General", "UTC", numericUpDown1.Value.ToString());
            WPS("General", "CustomString", textBox1.Text);
            this.DialogResult= DialogResult.OK;
            GC.Collect();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            GC.Collect();
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            numericUpDown1.Value = int.Parse(TimeZoneInfo.Local.GetUtcOffset(DateTime.Now).TotalHours.ToString());
            textBox1.Text = "%UT%";
        }
    }
}

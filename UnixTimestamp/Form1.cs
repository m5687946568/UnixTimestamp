using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Collections.Specialized.BitVector32;

namespace UnixTimestamp
{
    public partial class Form1 : Form
    {
        public Form1()
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

        public void Form1_Load(object sender, EventArgs e)
        {
            if (!File.Exists(ProfilePath))
            {
                Directory.CreateDirectory(ProfilePath);
                if (!File.Exists(ProfilePath + @"UnixTimestamp.ini"))
                {
                    WPS("General", "UTC", TimeZoneInfo.Local.GetUtcOffset(DateTime.Now).TotalHours.ToString());
                    WPS("General", "CustomString", "%UT%");
                }
            }

            numericUpDown_year.Value = DateTime.Now.Year;
            numericUpDown_mon.Value = DateTime.Now.Month;
            numericUpDown_day.Value = DateTime.Now.Day;
            numericUpDown_hour.Value = DateTime.Now.Hour;
            numericUpDown_min.Value = DateTime.Now.Minute;
            numericUpDown_sec.Value = DateTime.Now.Second;
            UTUpdata();
        }

        private void UTUpdata()
        {
            int iUTC = int.Parse(GPS("General", "UTC"));
            string sCustomString = GPS("General", "CustomString");
            int iyear = (int)numericUpDown_year.Value;
            int imon = (int)numericUpDown_mon.Value;
            int iday = (int)numericUpDown_day.Value;
            int ihour = (int)numericUpDown_hour.Value;
            int imin = (int)numericUpDown_min.Value;
            int isec = (int)numericUpDown_sec.Value;
            if (DateTime.DaysInMonth(iyear, imon) < iday)
            {
                numericUpDown_day.Value = DateTime.DaysInMonth(iyear, imon);
                iday = (int)numericUpDown_day.Value;
            }
            numericUpDown_day.Maximum = DateTime.DaysInMonth(iyear, imon);

            DateTime dt1 = new DateTime(1970, 1, 1, 0, 0, 0);
            DateTime dt2 = new DateTime(iyear, imon, iday, ihour, imin, isec);
            long dtSeconds = (long)(dt2 - dt1).TotalSeconds;

            textBox1.Tag = dtSeconds - (iUTC * 60 * 60);
            textBox1.Text = sCustomString.Replace("%UT%", textBox1.Tag.ToString());
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            ((TextBox)sender).SelectAll();
        }

        private void DT_Change(object sender, EventArgs e)
        {
            UTUpdata();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.StartPosition = FormStartPosition.CenterParent;
            form2.GetUT(textBox1.Tag.ToString());
            form2.ShowDialog();
            switch (form2.DialogResult)
            {
                case DialogResult.OK:
                    UTUpdata();
                    this.Show();
                    break;
                default:
                    this.Show();
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clipboard.SetData(DataFormats.Text, textBox1.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GC.Collect();
            Close();
        }

        private void SelectAll(object sender, EventArgs e)
        {
            ((NumericUpDown)sender).Select(0, sender.ToString().Length);
        }
    }
}
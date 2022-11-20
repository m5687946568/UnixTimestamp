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

            dateTimePicker_year.Value = DateTime.Now;
            dateTimePicker_mon.Value = DateTime.Now;
            dateTimePicker_day.Value = DateTime.Now;
            dateTimePicker_hour.Value = DateTime.Now;
            dateTimePicker_min.Value = DateTime.Now;
            dateTimePicker_sec.Value = DateTime.Now;
            UTUpdata();
        }

        private void UTUpdata()
        {
            int iUTC = int.Parse(GPS("General", "UTC"));
            string sCustomString = GPS("General", "CustomString");
            int iyear = dateTimePicker_year.Value.Year;
            int imon = dateTimePicker_mon.Value.Month;
            int iday = dateTimePicker_day.Value.Day;
            int ihour = dateTimePicker_hour.Value.Hour;
            int imin = dateTimePicker_min.Value.Minute;
            int isec = dateTimePicker_sec.Value.Second;

            DateTime dt1 = new DateTime(1970, 1, 1, 0, 0, 0);
            DateTime dt2 = new DateTime(iyear, imon, iday, 0, 0, 0);
            int dtdays = (int)(dt2 - dt1).TotalDays;
            textBox1.Tag = ((dtdays * 24 * 60 * 60) + (ihour * 60 * 60) + (imin * 60) + isec) - (iUTC * 60 * 60);

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
    }
}
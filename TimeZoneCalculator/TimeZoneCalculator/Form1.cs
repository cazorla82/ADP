using GeoTimeZone;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeZoneConverter;

namespace TimeZoneCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var result = GetTimeZoneByCoordinates(TextBox_Latitude.Text, TextBox_Logitude.Text);
                TimeZone_TextBox.Text = result;
        }

        public string GetTimeZoneByCoordinates(string latitude, string longitude) 
        {

            if (!String.IsNullOrEmpty(latitude) && !String.IsNullOrEmpty(longitude)) {

                string tzIana = TimeZoneLookup.GetTimeZone(Convert.ToDouble(latitude), Convert.ToDouble(longitude)).Result;
                TimeZoneInfo tzInfo = TZConvert.GetTimeZoneInfo(tzIana);
                DateTimeOffset convertedTime = TimeZoneInfo.ConvertTime(DateTimeOffset.UtcNow, tzInfo);
                //return convertedTime.Date.ToShortDateString();
                return convertedTime.ToString();
            }

            return "No data found for the inputs";
        }

        private void CurrentTimeZone_Click(object sender, EventArgs e)
        {

        }
    }
}

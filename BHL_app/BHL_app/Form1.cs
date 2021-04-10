using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace BHL_app
{
    public partial class Form1 : Form
    {

        //URL to the channel to write values depending on being at home 
        String urlHome = "https://api.thingspeak.com/update?api_key=SF93QOL0YTQXZVB3&field5=";
        //Beginning and ending of URL to the graphs
        String chartBegin = "https://thingspeak.com/channels/1353802/charts/";
        String chartEnd = "?bgcolor=%23ffffff&color=%23d62020&dynamic=true&results=60&type=line&update=15";

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnOut_Click(object sender, EventArgs e)
        {
            ProcessStartInfo psi = new ProcessStartInfo
            {
                //URL adress to sent information about being at home
                FileName =(urlHome + "0"),//send 0 -> outside
                UseShellExecute = true
            };
            Process.Start(psi);


        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            ProcessStartInfo psi = new ProcessStartInfo
            {
                //URL adress to sent information about being at home
                FileName = (urlHome+"1"),//send 1 -> at home
                UseShellExecute = true
            };
            Process.Start(psi);
        }

        private void BtnDevice_Click(object sender, EventArgs e)
        {
            ProcessStartInfo psi = new ProcessStartInfo
            {
                //URL to the website with the chart nr. 1
                FileName = (chartBegin+"1"+chartEnd),
                UseShellExecute = true
            };
            Process.Start(psi);
        }

        private void BtnGas_Click(object sender, EventArgs e)
        {
            ProcessStartInfo psi = new ProcessStartInfo
            {
                //URL to the website with the chart nr. 2
                FileName = (chartBegin+"2"+chartEnd),
                UseShellExecute = true
            };
            Process.Start(psi);
        }

        private void BtnTemp_Click(object sender, EventArgs e)
        {
            ProcessStartInfo psi = new ProcessStartInfo
            {
                //URL to the website with the chart nr. 3
                FileName = (chartBegin + "3" + chartEnd),
                UseShellExecute = true
            };
            Process.Start(psi);
        }

        private void BtnHum_Click(object sender, EventArgs e)
        {
            ProcessStartInfo psi = new ProcessStartInfo
            {
                //URL to the website with the chart nr. 4
                FileName = (chartBegin + "4" + chartEnd),
                UseShellExecute = true
            };
            Process.Start(psi);
        }
    }
}

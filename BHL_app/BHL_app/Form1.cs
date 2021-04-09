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
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnOut_Click(object sender, EventArgs e)
        {
            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = "https://api.thingspeak.com/channels/1353802/feeds.json?api_key=PK5RIGHIFH7EFFFF&results=1",
                UseShellExecute = true
            };
            Process.Start(psi);
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = "https://api.thingspeak.com/channels/1353802/feeds.json?api_key=PK5RIGHIFH7EFFFF&results=1",
                UseShellExecute = true
            };
            Process.Start(psi);
        }

        private void BtnDevice_Click(object sender, EventArgs e)
        {
            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = "https://thingspeak.com/channels/1353802/charts/1?bgcolor=%23ffffff&color=%23d62020&dynamic=true&results=60&type=line&update=15",
                UseShellExecute = true
            };
            Process.Start(psi);
        }

        private void BtnGas_Click(object sender, EventArgs e)
        {
            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = "https://thingspeak.com/channels/1353802/charts/2?bgcolor=%23ffffff&color=%23d62020&dynamic=true&results=60&type=line&update=15",
                UseShellExecute = true
            };
            Process.Start(psi);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace DNSTest {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void buttonFind_Click(object sender, EventArgs e) 
        {
            textBoxLog.AppendText("Результат для " + textBoxHost.Text + ":\n");
            IPAddress[] addresses = Dns.GetHostAddresses(textBoxHost.Text);
            foreach (IPAddress addr in addresses) {
                textBoxLog.AppendText(addr + "\n");
            }
        }
    }
}

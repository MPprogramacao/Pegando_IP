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

namespace Pegando_IP
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }
        
        private IPAddress[] ip = Dns.GetHostAddresses(Dns.GetHostName());

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void btnIP_Click(object sender, EventArgs e)
        {        
            MessageBox.Show(ip[3].ToString());
        }

        private void btnIPv6_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ip[1].ToString());
        }
    }
}

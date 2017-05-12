using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                var sHttp = tbHTTP.Text;

                /* Process data */
                bool result = CDataProcess.ProcessData(sHttp);
                if (result == true)
                    lbStatus.Text = "Status: loading success!";
                else
                    lbStatus.Text = "Status: loading error!";
            }
            catch(Exception ex)
            {
                lbStatus.Text = "Status: loading error!";
            }
        }

        private void tbHTTP_KeyDown(object sender, KeyEventArgs e)
        {
            lbStatus.Text = "Status:";
            if (e.KeyCode == Keys.Enter)
            {
                btnLoad.PerformClick();
            }
        }
    }
}

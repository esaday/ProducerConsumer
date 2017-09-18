using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TK_Cons_F_v0.UI
{
    public partial class frmDashBoard : Form
    {
        public frmDashBoard()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
            FormBorderStyle = FormBorderStyle.None;
            timerClock.Start();
        }

        Form init;

        public Form Init
        {
            get
            {
                if (init == null) { init = new frmDataFlow(); }

                return init;
            }
        }

        private void frmDashBoard_VisibleChanged(object sender, EventArgs e)
        {
            //if (Visible == true)
            //{
            //    var timer = new System.Threading.Timer(ShowTime, null, 0, 1000);
            //}

        }

        private void btnDF_Click(object sender, EventArgs e)
        {
            frmDataFlow df = Init as frmDataFlow;
            df.MdiParent = MdiParent;
            df.Dock = DockStyle.Fill;
            Hide();
            df.Show();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            frmSettings sf = new frmSettings();
            sf.MdiParent = MdiParent;
            sf.Dock = DockStyle.Fill;
            Hide();
            sf.Show();
        }

        //Hata yuzunden iptal edildi.
        private void ShowTime(object x)
        {
            if (!IsHandleCreated && !IsDisposed) return;

            Invoke((MethodInvoker)delegate
            {
                btnClock.Text = DateTime.Now.ToLongTimeString();
            });
        }

        private void Clock_Tick(object sender, EventArgs e)
        {   //Hata Iptal
           // System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("tr-TR");
           // string FormatDate = DateTime.Now.ToString("dd MMM yyyy\ndddd\nhh:MM:ss", culture);
            btnClock.Text = DateTime.Now.ToShortTimeString();
        }
    }
}


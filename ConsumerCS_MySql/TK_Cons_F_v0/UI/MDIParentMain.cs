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
    public partial class MDIParentMain : Form
    {
        public MDIParentMain()
        {
            InitializeComponent();

        }
        Form content;

        public Form Content
        {
            get
            {
                if (content == null) { content = new frmDashBoard(); }

                return content;
            }

        }

        private void MDIParentMain_Load(object sender, EventArgs e)
        {
            Content.MdiParent = this;
            Content.Dock = DockStyle.Fill;
            content.Show();
        }

        private void MDIParentMain_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Content.MdiParent = this;

            if (!(ActiveMdiChild.Text == "DataFlow" || ActiveMdiChild.Text == "DashBoard"))
            {
                ActiveMdiChild.Close();
            }
            else
            {
                ActiveMdiChild.Hide();
            }

            //Content.BringToFront();
            Content.Show();
            
        }
    }
}

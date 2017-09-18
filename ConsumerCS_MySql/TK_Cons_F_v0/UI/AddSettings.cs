using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TK_Cons_F_v0.DAO;

namespace TK_Cons_F_v0.UI
{
    public partial class frmAddSettings : Form
    {
        public frmAddSettings()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        { dbConnection db = new dbConnection();
            if (textBoxAdi.Text == "") textBoxAdi.Text = "YeniAyar" + (new Random()).Next(100);
            db.AddClassificationtoDB((int)numericUDAltLim.Value, (int)numericUDUstLim.Value, (int)numericUDBirLim.Value, textBoxAdi.Text);
            //CRUD.AddClassificationtoDB((int)numericUDAltLim.Value, (int)numericUDUstLim.Value,
                                                   // (int)numericUDBirLim.Value, textBoxAdi.Text);

            RepeatCont();
        }

        void RepeatCont()
        {
            DialogResult dr = MessageBox.Show("Yeni ayar eklendi.Bütün exception"
            + "kontrolleri yapılmadı.", "Tamam mı Devam mı ?", MessageBoxButtons.YesNo);

            if (dr == DialogResult.Yes)
            {
                foreach (Control item in Controls)
                {
                    if (item is TextBox) { (item as TextBox).Text = string.Empty; }
                    else if (item is NumericUpDown) { (item as NumericUpDown).Value = 0; }
                }
            }
            if (dr == DialogResult.No)
            {
                Hide();
                frmSettings sf = new frmSettings();
                sf.MdiParent = MdiParent;
                sf.Dock = DockStyle.Fill;
                sf.Show();
                Close();
            }
        }



    }
}

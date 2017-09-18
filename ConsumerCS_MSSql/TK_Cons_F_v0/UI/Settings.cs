using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TK_Cons_F_v0.BUS;
using System.Configuration;

namespace TK_Cons_F_v0.UI
{
    public partial class frmSettings : Form
    {
        string[] connstr = new string[2];
        int visibleDataC;
        bool _loaded = false;

        public string[] Connstr
        {
            get
            {
                return connstr;
            }

            private set
            {
                connstr = value;
            }
        }

        public int VisibleDataC
        {
            get
            {
                return visibleDataC;
            }

            private set
            {
                visibleDataC = value;
            }
        }

        static public int SelectedCls
        {
            get;

            set;
        }

        public frmSettings()
        {
            InitializeComponent();
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            InitSettings();
            _loaded = true;
            FillSelected();
        }

        private void comboBoxCls_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_loaded)
                FillSelected();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            Connstr[0] = txtBxBrokerURI.Text;
            Connstr[1] = txtBxQueName.Text;
            if (Connstr != null)
            {
                foreach (Control item in groupBox3.Controls)
                { if (item.GetType() == typeof(Label)) { item.Visible = true; } }

                labelConnStr.Text = "Broker: " + txtBxBrokerURI.Text;
                labelQue.Text = "Que: " + txtBxQueName.Text;
                AddValue("activeBrokerURI", connstr[0]);
                AddValue("activeQueName", connstr[1]);
            }
        }

        private void btnDataCount_Click(object sender, EventArgs e)
        {
            VisibleDataC = (int)numericUpDataC.Value;
            AddValue("activeVisibleDataC", visibleDataC);
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            frmAddSettings asf = new frmAddSettings();
            asf.MdiParent = MdiParent;
            asf.Dock = DockStyle.Fill;
            Hide();
            asf.Show();
            Close();
        }

        private void btnSettingSave_Click(object sender, EventArgs e)
        {
            comboBox1.Enabled = false;
            btnSettingSave.Enabled = false;

            AddValue("activeClsSetting", SelectedCls);

            MessageBox.Show("Başarıyla KAYDEDİLDİ!", "KAYIR DURUMU", MessageBoxButtons.OK);

        }

        void FillSelected()
        {
            var abc = comboBox1.SelectedValue;

            var cur = CRUD.ReadClsByID(Convert.ToInt32(abc));
            textBox1.Text = cur.altLim.ToString();
            textBox2.Text = cur.ustLim.ToString();
            textBox3.Text = cur.birLim.ToString();
            textBox4.Text = cur.someText;
            SelectedCls = cur.ClsID;
        }

        void InitSettings()
        {
            comboBox1.DataSource = CRUD.ReadAllClassificationfromDB();
            comboBox1.DisplayMember = "SomeText";
            comboBox1.ValueMember = "ClsID";
            comboBox1.SelectionStart = 1;
        }

        public static void AddValue(string key, int value)
        {
            Properties.Settings.Default[key] = value;
            Properties.Settings.Default.Save();
        }

        public static void AddValue(string key, string value)
        {
            Properties.Settings.Default[key] = value;
            Properties.Settings.Default.Save();
        }
    }
}

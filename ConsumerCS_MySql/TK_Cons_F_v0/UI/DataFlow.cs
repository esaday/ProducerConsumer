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

namespace TK_Cons_F_v0
{
    public partial class frmDataFlow : Form
    {

        public frmDataFlow()
        {
            InitializeComponent();
        }

        private void btnFlowData_Click(object sender, EventArgs e)
        {
            AmqHandler queInstance;
           //kurucu metoda uri ve que yazılırsa ayarlarda belirtilen yolla baglanmaya calisir.
           string uri = Properties.Settings.Default.activeBrokerURI;
            string que = Properties.Settings.Default.activeQueName;
            if (uri.Length + que.Length > 2)
            {
                queInstance = new AmqHandler(que, uri);
            }
            else
            { queInstance = new AmqHandler("ProtoExample_1", "tcp://localhost:61616"); }

            queInstance.OnMessageReceived += OnRecieve;

        }

        private void OnRecieve(object sender, MessageReceivedArgs e)
        {
            SingleData ds = (SingleData)sender;
            UIUpdater.UpdateUI(chartData, dataGridView1, ds, 500);
        }

        private void frmDataFlow_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible==true)
            {
                UIUpdater.AddClsProp(chartData, true);
            }

        }
    }
}

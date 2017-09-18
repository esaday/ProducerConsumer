using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using TK_Cons_F_v0.DAO;

namespace TK_Cons_F_v0.BUS
{
    class UIUpdater
    {

        public static void UpdateUI(Chart chart1, DataGridView dGrid, SingleData ds, int delay)
        {
            VisualData vd = Classifier.ClsData(ds);

            UpdateChart(chart1, vd);
            UpdateGrid(dGrid, vd);

            Thread.Sleep(delay);
        }

        public static void AddClsProp(Chart chart1, bool isSet)
        {
            dbConnection db = new dbConnection();
            if (isSet)
            {
                var clsprop = db.ReadClsByIDfromDB(Properties.Settings.Default.activeClsSetting);//CRUD.ReadClsByID(Properties.Settings.Default.activeClsSetting);

                chart1.Legends[0].CustomItems[0].Name = "UstLim = " + clsprop.UstLim;
                chart1.Legends[0].CustomItems[2].Name = "Gecersiz = " + clsprop.BirLim;
                chart1.Legends[0].CustomItems[3].Name = "AltLim= " + clsprop.AltLim;
                chart1.Legends[0].CustomItems[4].Name = "Secili Ayar= " + clsprop.SomeText;
            }

        }

        static void UpdateChart(Chart chart1, VisualData vd)
        {
            long maxDatac = Properties.Settings.Default.activeVisibleDataC;
            string t = DateTime.Now.ToString("hh:mm:ss");

            if (chart1.InvokeRequired)
            {
                chart1.Invoke(new MethodInvoker(
                    delegate
                    {
                        int i = chart1.Series[0].Points.Count;
                        chart1.Series[0].Points.AddXY(t, vd.Val);
                        chart1.Series[0].Points[i--].Color = Color.FromName(vd.Color);
                        if (chart1.Series[0].Points.Count > maxDatac)
                        {
                            chart1.Series[0].Points.RemoveAt(0);
                            chart1.Invalidate();
                        }
                    }));
            }
        }

        static void UpdateGrid(DataGridView dGrid, VisualData vd)
        {
            if (dGrid.InvokeRequired)
            {
                dGrid.Invoke(new MethodInvoker(
                    delegate
                    {
                        dGrid.Rows.Add(vd.DateCreated, vd.Val, vd.SomeText, vd.ErrMode);
                        dGrid.FirstDisplayedScrollingRowIndex = dGrid.RowCount - 1;
                    }
                    ));
            }
        }



    }

}

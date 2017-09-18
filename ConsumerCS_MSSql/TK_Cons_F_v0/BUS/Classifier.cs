using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace TK_Cons_F_v0.BUS
{
    /// <summary>
    /// Chart icin ozellestirilmis veri tipi
    /// </summary>
    public struct VisualData
    {
        public int Val { get; set; }
        public string Color { get; set; }
        public string ErrMode { get; set; }
        public string SomeText { get; set; }
        public DateTime DateCreated { get; set; }
    }

    class Classifier
    {
        /// <summary>
        /// Gelen ham veriyi sınıflandırarak grafige hazir hale getirir
        /// </summary>
        /// <param name="inc">proto kalibina uygun gelen veri</param>
        /// <returns>Visual Data tipinde chart icin ozellestirilmis struct</returns>
        public static VisualData ClsData(SingleData inc)
        {
            int id = Properties.Settings.Default.activeClsSetting;
            var clsRules = CRUD.ReadClsByID(id);
            var data_id = CRUD.AddDatatoDB(inc);
            VisualData vd = new VisualData()
            {
                Val = inc.SomeValue,
                DateCreated = ConvertTime(inc.TimeSeconds),
                SomeText = inc.SomeText,
            };

            vd.Color = "black";
            vd.ErrMode = "OK";

            if (clsRules.altLim < vd.Val)
            {
                vd.Color = "red";
                vd.ErrMode = "Dusuk deg.";

            }
            if (clsRules.ustLim > vd.Val)
            {
                vd.Color = "green";
                vd.ErrMode = "Yuksek deg.";
            }
            if (clsRules.birLim == vd.Val)
            {
                vd.Color = "gray";
                vd.ErrMode = "Gecersiz deg.";
            }

            CRUD.AddErrorToDB(id, data_id, vd.ErrMode);
            return vd;
        }

        /// <summary>
        /// Java lang olarak gelen veriyi, .net local time'a ceviriyor
        /// </summary>
        /// <param name="millis"> Java tarafından gelen millisecond cinsinden long deger</param>
        /// <returns></returns>
        static DateTime ConvertTime(long millis)
        {
            DateTime UTCBaseTime = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            DateTime dt = UTCBaseTime.Add(new TimeSpan(millis * TimeSpan.TicksPerMillisecond)).ToLocalTime();

            return dt;
        }
    }


}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TK_Cons_F_v0.DAO
{
   public class TableClasses
    {


    }
   public class T_MyData
    {
        public int ID { get; set; }
        public int? Val { get; set; }
        public string SomeText { get; set; }
        public DateTime dateRecieved { get; set; }
    }


   public class T_Classification
    {
        public long ClsID { get; set; }
        public int? AltLim { get; set; }
        public int? UstLim { get; set; }
        public int? BirLim { get; set; }
        public string SomeText { get; set; }

    }



   public class T_ErrorLog
    {
        public int ErrorID { get; set; }
        public DateTime ErrorDate { get; set; }
        public string  ErrorNote { get; set; }
        public int DataID { get; set; }
        public int ClsID { get; set; }
        public T_Classification ClsData { get; set; }
        public T_MyData Data { get; set; }

    }



}

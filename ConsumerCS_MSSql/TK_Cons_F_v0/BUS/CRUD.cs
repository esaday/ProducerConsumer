using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TK_Cons_F_v0.DAO;

namespace TK_Cons_F_v0.BUS
{   /// <summary>
    /// CRUD class for Create-Read-Update-Delete from database, methods self-explanatory
    /// </summary>
    public class CRUD
    {
        public CRUD()
        {

        }

        #region Create

        static public void AddClassificationtoDB(int altLim, int ustLim, int birLim, string someText)
        {
            using (var context = new AmqDatasEntities())
            {
                tableClassify c2a = new tableClassify() { altLim = altLim, ustLim = ustLim, birLim = birLim, someText = someText };
                context.tableClassifies.Add(c2a);
                context.SaveChanges();
            }

        }

        static public int AddDatatoDB(SingleData single)
        {
            using (var context = new AmqDatasEntities())
            {
                tableMyData d2a = new tableMyData()
                {
                    val = single.SomeValue,
                    sometext = single.SomeText,
                    recieve_date = DateTime.Now
                };

                context.tableMyDatas.Add(d2a);

                context.SaveChanges();
                return d2a.ID;
            }

        }

        static public void AddErrorToDB(int clsID, int dataID, string errorMode)
        {
            using (var context = new AmqDatasEntities())
            {
                tableErrorLog e2a = new tableErrorLog()
                {
                    ClsID = clsID,
                    DataID = dataID,
                    ErrNote = errorMode,
                    ErrDateTime = DateTime.Now
                };
                context.tableErrorLogs.Add(e2a);
                context.SaveChanges();
            }
        }


        #endregion

        #region Read
        /// <summary>
        /// Veri erisiminin saglanip saglanmadigini kontrol etmek icin read islemi (gerek kalmadi.)
        /// </summary>
        /// <returns></returns>
        static public tableClassify ReadClassificationfromDB()
        {
            int selectionID = 1; //will change
            using (var context = new AmqDatasEntities())
            {
                tableClassify current = context.tableClassifies.Where(s => s.ClsID == selectionID).FirstOrDefault();

                return current;
            }

        }

        static public tableClassify ReadClsByNamefromDB(string name)
        {
            using (var context = new AmqDatasEntities())
            {
                tableClassify current = context.tableClassifies.Where(s => s.someText == name).FirstOrDefault();

                return current;
            }
        }

        static public int ReadClsByIDfromName(string name)
        {
            using (var context = new AmqDatasEntities())
            {
                tableClassify current = context.tableClassifies.Where(s => s.someText == name).SingleOrDefault();

                return current.ClsID;
            }
        }

        static public tableClassify ReadClsByID(int val)
        {
            using (var context = new AmqDatasEntities())
            {
                tableClassify current = context.tableClassifies.Where(s => s.ClsID == val).SingleOrDefault();

                return current;
            }
        }

        static public List<tableClassify> ReadAllClassificationfromDB()
        {
            using (var context = new AmqDatasEntities())
            {
                return context.tableClassifies.ToList();
            }
        }
        /// <summary>
        /// NOT IMPLEMENTED YET!
        /// </summary>
        public void ReadErrorfromDB()
        {
            using (var context = new AmqDatasEntities())
            {
                throw new NotImplementedException();
            }
        }

        /// <summary>
        /// NOT IMPLEMENTED YET!
        /// </summary>
        public void ReadDatafromDB()
        {
            using (var context = new AmqDatasEntities())
            {
                throw new NotImplementedException();
            }
        }

        #endregion

        #region Update
        public void UpdateDatafromDB()
        {
            using (var context = new AmqDatasEntities())
            {
                throw new NotImplementedException();
            }
        }
        public void UpdateClassificationfromDB()
        {
            using (var context = new AmqDatasEntities())
            {
                throw new NotImplementedException();
            }
        }
        public void UpdateErrorfromDB()
        {
            using (var context = new AmqDatasEntities())
            {
                throw new NotImplementedException();
            }
        }
        #endregion

        #region Delete
        /// <summary>
        /// Ihtiyac duyulmadigi icin implemente edilmedi.
        /// </summary>


        public void DeleteDatafromDB()
        {
            using (var context = new AmqDatasEntities())
            {
                throw new NotImplementedException();
            }
        }
        public void DeleteClassificationfromDB()
        {
            using (var context = new AmqDatasEntities())
            {
                throw new NotImplementedException();
            }
        }
        public void DeleteErorfromDB()
        {
            using (var context = new AmqDatasEntities())
            {
                throw new NotImplementedException();
            }
        }
        #endregion
    }
}

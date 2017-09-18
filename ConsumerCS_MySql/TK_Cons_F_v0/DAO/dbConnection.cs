using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;

namespace TK_Cons_F_v0.DAO
{
    public class dbConnection
    {
        private MySqlDataAdapter myAdapter;
        private MySqlConnection conn;

        /// <constructor>
        /// Baglanti acan kurucu
        /// </constructor>
        public dbConnection()
        {
            myAdapter = new MySqlDataAdapter();
            conn = new MySqlConnection(Properties.Settings.Default.connString);
            conn = openConnection();
        }

        /// <method>
        /// Kapalı veya bozuksa db baglantisini ac
        /// </method>
        private MySqlConnection openConnection()
        {
            if (conn.State == ConnectionState.Closed || conn.State ==
                        ConnectionState.Broken)
            {
                conn.Open();
            }
            return conn;
        }

        public void AddClassificationtoDB(int altLim, int ustLim, int birLim, string someText)
        {
            try
            {
                MySqlCommand comm = conn.CreateCommand();
                comm.CommandText = "INSERT INTO tableclassify(altLim,ustLim,birLim,someText) VALUES(@altLim, @ustLim,@birLim,@someText)";
                comm.Parameters.AddWithValue("@altLim", altLim);
                comm.Parameters.AddWithValue("@ustLim", ustLim);
                comm.Parameters.AddWithValue("@birLim", birLim);
                comm.Parameters.AddWithValue("@someText", someText);
                comm.ExecuteNonQuery();
                conn.Close();
            }
            catch (MySqlException e)
            {
                Console.Write("Error!!" +
                    " \nException: \n" + e.StackTrace.ToString());
            }

        }

        public long AddDatatoDB(SingleData sd)
        {
            MySqlCommand comm = conn.CreateCommand();
            try
            {
                conn = openConnection();

                comm.CommandText = "INSERT INTO tablemydata(val,sometext,recievedate)" +
                                            " VALUES(@val, @sometext,@recievedate)";
                comm.Parameters.AddWithValue("@val", sd.SomeValue);
                comm.Parameters.AddWithValue("@sometext", sd.SomeText);
                comm.Parameters.AddWithValue("@recievedate", DateTime.Now);
                comm.ExecuteNonQuery();

                conn.Close();

            }
            catch (MySqlException e)
            {
                System.Windows.Forms.MessageBox.Show("Error!!" +
                    " \nException: \n" + e.StackTrace.ToString());
                return -1;
            }
            return comm.LastInsertedId;
        }

        public void AddErrorToDB(long clsID, long dataID, string errorMode)
        {
            MySqlCommand comm = conn.CreateCommand();
            try
            {
                conn = openConnection();

                comm.CommandText = "INSERT INTO tableerrorlog(ErrDateTime,ErrNote,DataID,ClsID)" +
                                            " VALUES( @ErrDateTime,@ErrNote, @DataID, @ClsID)";
                comm.Parameters.AddWithValue("@ErrDateTime", DateTime.Now);
                comm.Parameters.AddWithValue("@ErrNote", errorMode);
                comm.Parameters.AddWithValue("@DataID", dataID);
                comm.Parameters.AddWithValue("@ClsID", clsID);
                comm.ExecuteNonQuery();
                conn.Close();
            }
            catch (MySqlException e)
            {
                Console.Write("Error!!" +
                    " \nException: \n" + e.StackTrace.ToString());
            }
        }


        public T_Classification ReadClsByNamefromDB(string name)
        {
            T_Classification c;
            try
            {
                MySqlCommand comm = conn.CreateCommand();
                comm.CommandText = "SELECT * FROM tableclassify WHERE someText ='@name'";
                comm.Parameters.AddWithValue("@name", name);
                MySqlDataReader d = comm.ExecuteReader();
                c = new T_Classification()
                {
                    AltLim = Convert.ToInt32(d["altLim"]),
                    BirLim = Convert.ToInt32(d["birLim"]),
                    UstLim = Convert.ToInt32(d["ustLim"]),
                    SomeText = d["someText"].ToString()
                };
                conn.Close();
            }

            catch (MySqlException e)
            {
                Console.Write("Error!!" +
                    " \nException: \n" + e.StackTrace.ToString());
                c = null;
            }

            return c;
        }

        public List<T_Classification> ReadAllClassificationfromDB()
        {
            List<T_Classification> c = new List<T_Classification>();
            try
            {

                MySqlCommand comm = conn.CreateCommand();
                comm.CommandText = "SELECT * FROM tableclassify";
                MySqlDataReader d = comm.ExecuteReader();
                while (d.Read())
                {
                    T_Classification t = new T_Classification()
                    {
                        ClsID = Convert.ToInt64(d["ClsID"]),
                        AltLim = Convert.ToInt32(d["altLim"]),
                        BirLim = Convert.ToInt32(d["birLim"]),
                        UstLim = Convert.ToInt32(d["ustLim"]),
                        SomeText = d["someText"].ToString()
                    };
                    c.Add(t);
                }

                conn.Close();
            }

            catch (MySqlException e)
            {
                Console.Write("Error!!" +
                    " \nException: \n" + e.StackTrace.ToString());
                c = null;
            }

            return c;
        }

        public T_Classification ReadClsByIDfromDB(long name)
        {
            T_Classification c = new T_Classification();
            try
            {
                conn = openConnection();
                MySqlCommand comm = conn.CreateCommand();
                comm.CommandText = "SELECT * FROM tableclassify WHERE ClsID =@name";
                comm.Parameters.AddWithValue("@name", name);
                MySqlDataReader d = comm.ExecuteReader();
                while (d.Read())
                {
                    c = new T_Classification()
                    {
                        ClsID = Convert.ToInt64(d["ClsID"]),
                        AltLim = Convert.ToInt32(d["altLim"]),
                        BirLim = Convert.ToInt32(d["birLim"]),
                        UstLim = Convert.ToInt32(d["ustLim"]),
                        SomeText = d["someText"].ToString()
                    };
                }

                conn.Close();
            }

            catch (MySqlException e)
            {
                Console.Write("Error!!" +
                    " \nException: \n" + e.StackTrace.ToString());
                c = null;
            }

            return c;
        }
    }
}




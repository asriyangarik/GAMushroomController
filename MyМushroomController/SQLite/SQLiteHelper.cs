using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Windows.Forms;

namespace MyМushroomController.DAL
{
    internal class SQLiteHelper
    {
        static SQLiteConnection _SQLconnector;
        static string SqlConnectionstring = "Data Source=SQLite/MushroomDB.sqlite;Version=3;";

        internal static bool SqlConnectionTest()
        {
            try
            {
                _SQLconnector = new SQLiteConnection(SqlConnectionstring);
                _SQLconnector.Open();
                _SQLconnector.Close();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
            
        }

        internal static bool SQLiteSettingInstert()
        {
            return false;
        }

        internal static List<SQLTabelRow> Gettabel()
        {
            try
            {
                _SQLconnector.Open();
                var cmd = new SQLiteCommand(@"SELECT id,
                                                     user_name,
                                                     name,
                                                     date_created
                                                     FROM Test;", _SQLconnector);
                var rdr = cmd.ExecuteReader();
                List<SQLTabelRow> myList = new List<SQLTabelRow>();
                while (rdr.Read())
                {
                    SQLTabelRow row = new SQLTabelRow();
                    row.id = rdr.GetInt32(0);
                    row.user_name = rdr.GetString(1);
                    row.name = rdr.GetString(2);
                    row.date_created = rdr.GetDateTime(3);
                    myList.Add(row);
                }
                return myList;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }
    }
}

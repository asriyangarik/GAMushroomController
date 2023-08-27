using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyМushroomController.DAL
{
    internal class SQLiteHelper
    {
        static SQLiteConnection _SQLconnector;
        static string SqlConnectionstring = "Data Source=GAController.sqlite;Version=3;";

        private static SQLiteConnection MySQLConnector()
        {
            if (_SQLconnector == null) { _SQLconnector = new SQLiteConnection(SqlConnectionstring); }
            return _SQLconnector;
        }

        internal static List<SQLTabelRow> Gettabel()
        {
            try
            {
                MySQLConnector().Open();
                var cmd = new SQLiteCommand(@"SELECT id,
                                                     user_name,
                                                     name,
                                                     date_created
                                                     FROM Test;", MySQLConnector());
                var rdr = cmd.ExecuteReader();
                List<SQLTabelRow> myList = new List<SQLTabelRow>();
                SQLTabelRow row = new SQLTabelRow();
                while (rdr.Read())
                {
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

        internal static SQLSettingsRow SettingGet()
        {
            try
            {
                MySQLConnector().Open();

                var command = new SQLiteCommand(@"SELECT Create_Date,
                                                         COM_Port1,
                                                         COM_BaudRate1,
                                                         COM_Port2,
                                                         COM_BaudRate2,
                                                         COM_Port3,
                                                         COM_BaudRate3,
                                                         COM_Port4,
                                                         COM_BaudRate4,
                                                         Relay_1,
                                                         Relay_2,
                                                         Relay_3,
                                                         Relay_4
                                                         FROM ControllerSetings;", MySQLConnector());
                SQLiteDataReader rdr = command.ExecuteReader();

                if (!rdr.HasRows)
                {
                    MySQLConnector().Close();
                    return null;
                }

                SQLSettingsRow Srow = new SQLSettingsRow();

                while (rdr.Read())
                {
                    Srow.Create_Date = rdr.GetString(0);
                    Srow.COM_Port1 = rdr.GetString(1);
                    Srow.COM_BaudRate1 = rdr.GetInt16(2);
                    Srow.COM_Port2 = rdr.GetString(3);
                    Srow.COM_BaudRate2 = rdr.GetInt16(4);
                    Srow.COM_Port3 = rdr.GetString(5);
                    Srow.COM_BaudRate3 = rdr.GetInt16(6);
                    Srow.COM_Port4 = rdr.GetString(7);
                    Srow.COM_BaudRate4 = rdr.GetInt16(8);
                    Srow.Relay_1 = rdr.GetString(9);
                    Srow.Relay_2 = rdr.GetString(10);
                    Srow.Relay_3 = rdr.GetString(11);
                    Srow.Relay_4 = rdr.GetString(12);
                }
                MySQLConnector().Close();
                return Srow;


            }
            catch (Exception bb)
            {

                MessageBox.Show(bb.Message);
            }

            MySQLConnector().Close();
            return null;
        }

        internal static bool SQLSettingsWriter(MyController controllerItems)
        {
            MySQLConnector().Close();

            if (SettingGet() == null)         ///////insert new Row
            {
                try
                {
                    MySQLConnector().Open();
                    string relay1 = "";
                    string relay2 = "";
                    string relay3 = "";
                    string relay4 = "";
                    string SerialPort_name1 = "";
                    int serialPort_BaudRate1 = 0;
                    string SerialPort_name2 = "";
                    int serialPort_BaudRate2 = 0;
                    string SerialPort_name3 = "";
                    int serialPort_BaudRate3 = 0;
                    string SerialPort_name4 = "";
                    int serialPort_BaudRate4 = 0;

                    var dateTime = DateTime.Now;

                    if (controllerItems._myserialPort1!=null)
                    {
                        SerialPort_name1 = controllerItems._myserialPort1.PortName;
                        serialPort_BaudRate1 = controllerItems._myserialPort1.BaudRate;
                    }
                    else
                    {
                        return false;
                    }
                    if (controllerItems._myserialPort2 != null)
                    {
                        SerialPort_name2 = controllerItems._myserialPort2.PortName;
                        serialPort_BaudRate2 = controllerItems._myserialPort2.BaudRate;
                    }
                    if (controllerItems._myserialPort3 != null)
                    {
                        SerialPort_name3 = controllerItems._myserialPort3.PortName;
                        serialPort_BaudRate3 = controllerItems._myserialPort3.BaudRate;
                    }
                    if (controllerItems._myserialPort4 != null)
                    {
                        SerialPort_name4 = controllerItems._myserialPort4.PortName;
                        serialPort_BaudRate4 = controllerItems._myserialPort4.BaudRate;
                    }



                    if (controllerItems._myRelay1 != null && controllerItems._reley_1_isConnected)
                    {
                        relay1 = controllerItems._myRelay1.MyDeviceInfo();
                       
                    }
                    else
                    {
                        return false;
                    }
                    if (controllerItems._myRelay2 != null && controllerItems._reley_2_isConnected)
                    {
                        relay2 = controllerItems._myRelay2.MyDeviceInfo();
                    }
                    if (controllerItems._myRelay3 != null && controllerItems._reley_3_isConnected)
                    {
                        relay3 = controllerItems._myRelay3.MyDeviceInfo();
                    }
                    if (controllerItems._myRelay4 != null && controllerItems._reley_4_isConnected)
                    {
                        relay4 = controllerItems._myRelay4.MyDeviceInfo();
                    }

                    string insertCommandString = $@"INSERT INTO ControllerSetings (
                         Create_Date,
                         COM_Port1,
                         COM_BaudRate1,
                         COM_Port2,
                         COM_BaudRate2,
                         COM_Port3,
                         COM_BaudRate3,
                         COM_Port4,
                         COM_BaudRate4,
                         Relay_1,
                         Relay_2,
                         Relay_3,
                         Relay_4
                     )
                     VALUES (
                         '{dateTime}',
                         '{SerialPort_name1}',
                         '{serialPort_BaudRate1}',
                         '{SerialPort_name2}',
                         '{serialPort_BaudRate2}',
                         '{SerialPort_name3}',
                         '{serialPort_BaudRate3}',
                         '{SerialPort_name4}',
                         '{serialPort_BaudRate4}',
                         '{relay1}',
                         '{relay2}',
                         '{relay3}',
                         '{relay4}');";

                    var Insetrcommand = new SQLiteCommand(insertCommandString, MySQLConnector());
                    Insetrcommand.ExecuteNonQuery();
                    MySQLConnector().Close();
                    return true;
                }
                catch (Exception ex)
                {
                    
                    MessageBox.Show(ex.Message);
                    return false;
                    
                }



            }
            else        //////Update Row
            {

            }
            MySQLConnector().Close();
            return false;

        }

        internal static bool CreateDB()
        {
            FileInfo dbfile = new FileInfo("GAController.sqlite");    ///stugum enq DB fayli arkayutyun@
            if (!dbfile.Exists) 
            {
                SQLiteConnection.CreateFile("GAController.sqlite");   ///ete fayl@ chka
            }

            try
            {

                MySQLConnector().Open();

                ///////////////1rst table
                
                SQLiteCommand createTables = new SQLiteCommand(@"CREATE TABLE ControllerSetings(Create_Date DATETIME,
                                                                                              COM_Port1 VARCHAR(10),
                                                                                              COM_BaudRate1 INTEGER,
                                                                                              COM_Port2 VARCHAR(10),
                                                                                              COM_BaudRate2 INTEGER,
                                                                                              COM_Port3 VARCHAR(10),
                                                                                              COM_BaudRate3 INTEGER,
                                                                                              COM_Port4 VARCHAR(10),
                                                                                              COM_BaudRate4 INTEGER,
                                                                                              Relay_1 VARCHAR(50),
                                                                                              Relay_2 VARCHAR(50),
                                                                                              Relay_3 VARCHAR(50),
                                                                                              Relay_4 VARCHAR(50))", MySQLConnector());
                createTables.ExecuteNonQuery ();

                //////////////////end 1rst table

                MySQLConnector().Close();

                return true;
            }
            catch (Exception ex)
            {
                MySQLConnector().Close();
                MessageBox.Show(ex.Message);
                return false;
            }       
        }

        internal static  void DeleteDB()
        {
            FileInfo dbfile = new FileInfo("GAController.sqlite");    ///stugum enq DB fayli arkayutyun@
            if (dbfile.Exists)
            {
                try
                {
                    var closeConnection = Task.Factory.StartNew(() => { MySQLConnector().Close(); });
                    closeConnection.Wait();
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    dbfile.Delete();    ////jnjum enq fayl@
                    MessageBox.Show("DB deleted");
                }
                catch (Exception ex)
                {

                    throw ex;
                }
                
            }
            else
            {
                MessageBox.Show("There are no DB to delet");
            }
        }

        internal static bool SqlConnectionTest()
        {
            try
            {
                MySQLConnector().Open();
                MySQLConnector().Close();
                return true;
            }
            catch (Exception)
            {

                return false;
            }

        }

        internal static bool SettingsClear()
        {
            try
            {
                MySQLConnector().Open();
                var command = new SQLiteCommand(@"DELETE FROM ControllerSetings;", MySQLConnector());
                SQLiteDataReader rdr = command.ExecuteReader();
                MessageBox.Show("Settings are Cleare");
                return true;
            }
            catch(Exception ex) 
            {
                MySQLConnector().Close();
                MessageBox.Show(ex.Message);
            }
            return false;
        }


    }

    #region SQL tables Rows

    internal class SQLTabelRow
    {
        public int id
        {
            get;
            set;
        }
        public string user_name
        {
            get;
            set;
        }
        public string name
        {
            get;
            set;
        }
        public DateTime date_created
        {
            get;
            set;
        }
    }

    internal class SQLSettingsRow
    {
        public string Create_Date
        {
            get;
            set;
        }
        public string COM_Port1
        {
            get;
            set;
        }
        public int COM_BaudRate1
        {
            get;
            set;
        }
        public string COM_Port2
        {
            get;
            set;
        }
        public int COM_BaudRate2
        {
            get;
            set;
        }
        public string COM_Port3
        {
            get;
            set;
        }
        public int COM_BaudRate3
        {
            get;
            set;
        }
        public string COM_Port4
        {
            get;
            set;
        }
        public int COM_BaudRate4
        {
            get;
            set;
        }
        public string Relay_1
        {
            get;
            set;
        }
        public string Relay_2
        {
            get;
            set;
        }
        public string Relay_3
        {
            get;
            set;
        }
        public string Relay_4
        {
            get;
            internal set;
        }

        public bool SQLSettingsRowIsEmpty()
        {
            if (this.Create_Date.Equals(null))
            {
                return true;
            }
            return false;

        }
    }


    #endregion


}

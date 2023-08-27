using MyМushroomController.DAL;
using RelayControll;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.IO.Ports;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyМushroomController
{
    public partial class MyController : Form
    {
        SQLSettingsRow Mysetting;
        internal SerialPort _myserialPort1;
        internal SerialPort _myserialPort2;
        internal SerialPort _myserialPort3;
        internal SerialPort _myserialPort4;

        internal Int16 SectionsCount;

        internal RelayControllCL _myRelay1;
        internal RelayControllCL _myRelay2;
        internal RelayControllCL _myRelay3;
        internal RelayControllCL _myRelay4;
        internal bool _reley_1_isConnected;
        internal bool _reley_2_isConnected;
        internal bool _reley_3_isConnected;
        internal bool _reley_4_isConnected;

        public MyController()
        {
            InitializeComponent();

            RefreshMyComList();

            FileInfo dbfile = new FileInfo("GAController.sqlite");    ///stugum enq DB fayli arkayutyun@
            if (dbfile.Exists)
            {
                CrateDBTB.Enabled = false;
                SaveSetTB.Enabled = true;
                GetSetting();
            }
            else
            {
                CrateDBTB.Enabled = true;
                SaveSetTB.Enabled = false;
            }

        }

        private void GetSetting()
        {
            Mysetting =  SQLiteHelper.SettingGet();

            if (Mysetting != null) 
            {
                MyComPorts1CB.Text = Mysetting.COM_Port1;
                COMBaudRate1CB.Text = Mysetting.COM_BaudRate1.ToString();
                MyComPorts2CB.Text = Mysetting.COM_Port2;
                COMBaudRate2CB.Text = Mysetting.COM_BaudRate2.ToString();
                MyComPorts3CB.Text = Mysetting.COM_Port3;
                COMBaudRate3CB.Text = Mysetting.COM_BaudRate3.ToString();
                MyComPorts4CB.Text = Mysetting.COM_Port4;
                COMBaudRate4CB.Text = Mysetting.COM_BaudRate4.ToString();

                if (Mysetting.Relay_1 != "")
                {
                    RelayList1CB.SelectedIndex = 0; // Mysetting.Relay_1;
                }
                if (Mysetting.Relay_2!="")
                {
                    RelayList2CB.SelectedIndex = 1;
                }
                if (Mysetting.Relay_3!="")
                {
                    RelayList3CB.SelectedIndex = 2;
                }
                if (Mysetting.Relay_4 != "")
                {
                    RelayList4CB.SelectedIndex = 3;
                }

            }

        }

        private void RefreshMyComList()
        {         
            MyComPorts1CB.Items.Clear();

            var myPorts =  SerialPort.GetPortNames();
            
            foreach (var Port in myPorts)
            {
                MyComPorts1CB.Items.Add(Port);
                MyComPorts2CB.Items.Add(Port);
                MyComPorts3CB.Items.Add(Port);
                MyComPorts4CB.Items.Add(Port);

            }

            COMBaudRate1CB.Items.Add("9600");
            COMBaudRate1CB.Items.Add("14400");
            COMBaudRate1CB.Items.Add("19200");
            COMBaudRate1CB.Items.Add("38400");
            COMBaudRate1CB.Items.Add("57600");
            COMBaudRate1CB.Items.Add("115200");
            COMBaudRate1CB.Items.Add("128000");

            COMBaudRate2CB.Items.Add("9600");
            COMBaudRate2CB.Items.Add("14400");
            COMBaudRate2CB.Items.Add("19200");
            COMBaudRate2CB.Items.Add("38400");
            COMBaudRate2CB.Items.Add("57600");
            COMBaudRate2CB.Items.Add("115200");
            COMBaudRate2CB.Items.Add("128000");

            COMBaudRate3CB.Items.Add("9600");
            COMBaudRate3CB.Items.Add("14400");
            COMBaudRate3CB.Items.Add("19200");
            COMBaudRate3CB.Items.Add("38400");
            COMBaudRate3CB.Items.Add("57600");
            COMBaudRate3CB.Items.Add("115200");
            COMBaudRate3CB.Items.Add("128000");

            COMBaudRate4CB.Items.Add("9600");
            COMBaudRate4CB.Items.Add("14400");
            COMBaudRate4CB.Items.Add("19200");
            COMBaudRate4CB.Items.Add("38400");
            COMBaudRate4CB.Items.Add("57600");
            COMBaudRate4CB.Items.Add("115200");
            COMBaudRate4CB.Items.Add("128000");


            var myReleys = RelayControllCL.MyDeviceNames();
            foreach (var reley in myReleys)
            {
                RelayList1CB.Items.Add(reley);
                RelayList2CB.Items.Add(reley);
                RelayList3CB.Items.Add(reley);
                RelayList4CB.Items.Add(reley);
            }
            

        }

        #region ComPort Settings

        private void Conform1ComBT_Click(object sender, EventArgs e)
        {
            if (_myserialPort1 != null)
            {
                _myserialPort1.Close();
                _myserialPort1= null;   
            }

            if (MyComPorts1CB.Text == "")
            {
                MessageBox.Show("Select sensor1 COM Port");
                return;
            }
            if (COMBaudRate1CB.Text == "")
            {
                MessageBox.Show("Select sensor1 COM Port BaudRate");
                return;
            }
            else
            {
                Indicator1COMBT.Visible = true;

                _myserialPort1 = new SerialPort(MyComPorts1CB.Text);
                _myserialPort1.BaudRate = Convert.ToInt32(COMBaudRate1CB.Text);
                _myserialPort1.Parity = Parity.None;
                _myserialPort1.StopBits = StopBits.One;
                _myserialPort1.DataBits = 8;
                _myserialPort1.Handshake = Handshake.None;

                _myserialPort1.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
                try
                {
                    _myserialPort1.Open();
                    Indicator1COMBT.BackColor = Color.Green;

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                    Indicator1COMBT.BackColor = Color.Red;
                }




            }
        }

        private void Close1ComTB_Click(object sender, EventArgs e)
        {
            if (_myserialPort1 != null)
            {
                try
                {
                    _myserialPort1.Close();
                    Indicator1COMBT.Visible = false;
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "Error sensor 1");
                }

            }
        }

        private void Conform2ComBT_Click(object sender, EventArgs e)
        {
            if (_myserialPort2 != null)
            {
                _myserialPort2.Close();
                _myserialPort2 = null;
            }

            if (MyComPorts2CB.Text == "")
            {
                MessageBox.Show("Select sensor2 COM Port");
                return;
            }
            if (COMBaudRate2CB.Text == "")
            {
                MessageBox.Show("Select sensor2 COM Port BaudRate");
                return;
            }
            else
            {
                Indicator2COMBT.Visible = true;

                _myserialPort2 = new SerialPort(MyComPorts2CB.Text);
                _myserialPort2.BaudRate = Convert.ToInt32(COMBaudRate2CB.Text);
                _myserialPort2.Parity = Parity.None;
                _myserialPort2.StopBits = StopBits.One;
                _myserialPort2.DataBits = 8;
                _myserialPort2.Handshake = Handshake.None;

                _myserialPort2.DataReceived += _myserialPort2_DataReceived;
                try
                {
                    _myserialPort2.Open();
                    Indicator2COMBT.BackColor = Color.Green;

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                    Indicator2COMBT.BackColor = Color.Red;
                }




            }
        }
   
        private void Close2ComTB_Click(object sender, EventArgs e)
        {
            if (_myserialPort2 != null)
            {
                try
                {
                    _myserialPort2.Close();
                    Indicator2COMBT.Visible = false;
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "Error Sensor 2");
                }

            }
        }

        private void Conform3ComBT_Click(object sender, EventArgs e)
        {
            if (_myserialPort3 != null)
            {
                _myserialPort3.Close();
                _myserialPort3 = null;
            }

            if (MyComPorts3CB.Text == "")
            {
                MessageBox.Show("Select COM Port");
                return;
            }
            if (COMBaudRate3CB.Text == "")
            {
                MessageBox.Show("Select COM Port BaudRate");
                return;
            }
            else
            {
                Indicator3COMBT.Visible = true;

                _myserialPort3 = new SerialPort(MyComPorts3CB.Text);
                _myserialPort3.BaudRate = Convert.ToInt32(COMBaudRate3CB.Text);
                _myserialPort3.Parity = Parity.None;
                _myserialPort3.StopBits = StopBits.One;
                _myserialPort3.DataBits = 8;
                _myserialPort3.Handshake = Handshake.None;

                _myserialPort3.DataReceived += _myserialPort3_DataReceived; 
                try
                {
                    _myserialPort3.Open();
                    Indicator3COMBT.BackColor = Color.Green;

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                    Indicator3COMBT.BackColor = Color.Red;
                }




            }
        }

        private void Close3ComTB_Click(object sender, EventArgs e)
        {
            if (_myserialPort3 != null)
            {
                try
                {
                    _myserialPort3.Close();
                    Indicator3COMBT.Visible = false;
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "Error Sensor 3");
                }

            }
        }

        private void Conform4ComBT_Click(object sender, EventArgs e)
        {
            if (_myserialPort4 != null)
            {
                _myserialPort4.Close();
                _myserialPort4 = null;
            }

            if (MyComPorts4CB.Text == "")
            {
                MessageBox.Show("Select COM Port");
                return;
            }
            if (COMBaudRate4CB.Text == "")
            {
                MessageBox.Show("Select COM Port BaudRate");
                return;
            }
            else
            {
                Indicator4COMBT.Visible = true;

                _myserialPort4 = new SerialPort(MyComPorts4CB.Text);
                _myserialPort4.BaudRate = Convert.ToInt32(COMBaudRate4CB.Text);
                _myserialPort4.Parity = Parity.None;
                _myserialPort4.StopBits = StopBits.One;
                _myserialPort4.DataBits = 8;
                _myserialPort4.Handshake = Handshake.None;

                _myserialPort4.DataReceived += _myserialPort4_DataReceived;
                try
                {
                    _myserialPort4.Open();
                    Indicator4COMBT.BackColor = Color.Green;

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                    Indicator4COMBT.BackColor = Color.Red;
                }




            }
        }

        private void Close4ComTB_Click(object sender, EventArgs e)
        {
            if (_myserialPort4 != null)
            {
                try
                {
                    _myserialPort4.Close();
                    Indicator4COMBT.Visible = false;
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "Error Sensor 4");
                }

            }
        }

        #endregion

        #region Com Port Receive

        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)   ///////1 com port
        {
            var mySerialDatas1 = _myserialPort1.ReadLine();




        }

        private void _myserialPort2_DataReceived(object sender, SerialDataReceivedEventArgs e) ///////2 com port
        {
            var mySerialDatas2 = _myserialPort2.ReadLine();




        }

        private void _myserialPort3_DataReceived(object sender, SerialDataReceivedEventArgs e)  ///////3 com port
        {
            var mySerialDatas3 = _myserialPort3.ReadLine();



        }
        private void _myserialPort4_DataReceived(object sender, SerialDataReceivedEventArgs e)  ///////4 com port
        {
            var mySerialDatas4 = _myserialPort4.ReadLine();




        }


        #endregion

        #region 1st relay 

        private void RellatCoonect1TB_Click(object sender, EventArgs e)
        {
            if (RelayList1CB.Text == "")
            {
                MessageBox.Show("choose the device");
                return;
            }
            if (_reley_1_isConnected)
            {
                MessageBox.Show("Relay Already is connected");
                return;
            }

            if (!validateRelays())
            {
                MessageBox.Show("Relay Already is connected");
                return;
            }

            _myRelay1 = new RelayControllCL();
            IndicatorRELAY1BT.Visible = true;
            _reley_1_isConnected = _myRelay1.MyDeviceConnect(RelayList1CB.Text);
            if (!_reley_1_isConnected)
            {
                IndicatorRELAY1BT.BackColor = Color.Red;
                MessageBox.Show("Cannot Connect to Device");
            }
            else
            {
                IndicatorRELAY1BT.BackColor = Color.Green;
            }
        }

        private void RelayDisconnect1TB_Click(object sender, EventArgs e)
        {
            if (_reley_1_isConnected)
            {
                _myRelay1.MyDeviceDisConnect();
                IndicatorRELAY1BT.Visible = false;
                _reley_1_isConnected = false;
            }
        }

        private void TestRelay1BT_Click(object sender, EventArgs e)
        {
            if (!_reley_1_isConnected)
            {
                MessageBox.Show("There are no connected devices");
                return;
            }
            try
            {
                _myRelay1.ReleOn(1);
                Task.Delay(250);
                _myRelay1.ReleOff(1);
                MessageBox.Show("Relay Test OK");
            }
            catch (Exception)
            {

                MessageBox.Show("Relay Test False");
            }
        }

        #endregion

        #region 2nd relay

        private void RelayDisconnect2TB_Click(object sender, EventArgs e)
        {
            if (_reley_2_isConnected)
            {
                _myRelay2.MyDeviceDisConnect();
                IndicatorRELAY2BT.Visible = false;
                _reley_2_isConnected = false;
            }
        }

        private void RellatCoonect2TB_Click(object sender, EventArgs e)
        {
            if (RelayList2CB.Text == "")
            {
                MessageBox.Show("choose the device");
                return;
            }
            if (_reley_2_isConnected)
            {
                MessageBox.Show("Relay Already is connected");
                return;
            }

            if (!validateRelays())
            {
                MessageBox.Show("Relay Already is connected");
                return;
            }
            _myRelay2 = new RelayControllCL();
            IndicatorRELAY2BT.Visible = true;
            _reley_2_isConnected = _myRelay2.MyDeviceConnect(RelayList2CB.Text);
            if (!_reley_2_isConnected)
            {
                IndicatorRELAY2BT.BackColor = Color.Red;
                MessageBox.Show("Cannot Connect to Device");
            }
            else
            {
                IndicatorRELAY2BT.BackColor = Color.Green;
            }
        }

        private void TestRelay2BT_Click(object sender, EventArgs e)
        {
            if (!_reley_2_isConnected)
            {
                MessageBox.Show("There are no connected devices");
                return;
            }
            try
            {
                _myRelay2.ReleOn(1);
                Task.Delay(250);
                _myRelay2.ReleOff(1);
                MessageBox.Show("Relay Test OK");
            }
            catch (Exception)
            {

                MessageBox.Show("Relay Test False");
            }
        }

        #endregion

        #region 3rd relay

        private void RelayDisconnect3TB_Click(object sender, EventArgs e)
        {
            if (_reley_3_isConnected)
            {
                _myRelay3.MyDeviceDisConnect();
                IndicatorRELAY3BT.Visible = false;
                _reley_3_isConnected = false;
            }
        }

        private void RellatCoonect3TB_Click(object sender, EventArgs e)
        {
            if (RelayList3CB.Text == "")
            {
                MessageBox.Show("choose the device");
                return;
            }
            if (_reley_3_isConnected)
            {
                MessageBox.Show("Relay Already is connected");
                return;
            }

            if (!validateRelays())
            {
                MessageBox.Show("Relay Already is connected");
                return;
            }
            _myRelay3 = new RelayControllCL();
            IndicatorRELAY3BT.Visible = true;
            _reley_3_isConnected = _myRelay3.MyDeviceConnect(RelayList3CB.Text);
            if (!_reley_3_isConnected)
            {
                IndicatorRELAY3BT.BackColor = Color.Red;
                MessageBox.Show("Cannot Connect to Device");
            }
            else
            {
                IndicatorRELAY3BT.BackColor = Color.Green;
            }
        }

        private void TestRelay3BT_Click(object sender, EventArgs e)
        {
            if (!_reley_3_isConnected)
            {
                MessageBox.Show("There are no connected devices");
                return;
            }
            try
            {
                _myRelay3.ReleOn(1);
                Task.Delay(250);
                _myRelay3.ReleOff(1);
                MessageBox.Show("Relay Test OK");
            }
            catch (Exception)
            {

                MessageBox.Show("Relay Test False");
            }
        }

        #endregion

        #region 4th relay

        private void RelayDisconnect4TB_Click(object sender, EventArgs e)
        {
            if (_reley_4_isConnected)
            {
                _myRelay4.MyDeviceDisConnect();
                IndicatorRELAY4BT.Visible = false;
                _reley_4_isConnected = false;
            }
        }

        private void RellatCoonect4TB_Click(object sender, EventArgs e)
        {
            if (RelayList4CB.Text == "")
            {
                MessageBox.Show("choose the device");
                return;
            }
            if (_reley_4_isConnected)
            {
                MessageBox.Show("Relay Already is connected");
                return;
            }

            if (!validateRelays())
            {
                MessageBox.Show("Relay Already is connected");
                return;
            }
            _myRelay4 = new RelayControllCL();
            IndicatorRELAY4BT.Visible = true;
            _reley_4_isConnected = _myRelay4.MyDeviceConnect(RelayList4CB.Text);
            if (!_reley_4_isConnected)
            {
                IndicatorRELAY4BT.BackColor = Color.Red;
                MessageBox.Show("Cannot Connect to Device");
            }
            else
            {
                IndicatorRELAY4BT.BackColor = Color.Green;
            }
        }

        private void TestRelay4BT_Click(object sender, EventArgs e)
        {
            if (!_reley_4_isConnected)
            {
                MessageBox.Show("There are no connected devices");
                return;
            }
            try
            {
                _myRelay4.ReleOn(1);
                Task.Delay(250);
                _myRelay4.ReleOff(1);
                MessageBox.Show("Relay Test OK");
            }
            catch (Exception)
            {

                MessageBox.Show("Relay Test False");
            }
        }

        #endregion

        private bool validateRelays()
        {

            if (RelayList1CB.Text == RelayList2CB.Text && _reley_1_isConnected)
            {
                return false;
            }
            else if (RelayList1CB.Text == RelayList2CB.Text && _reley_2_isConnected)
            {
                return false;
            }
            else if (RelayList1CB.Text == RelayList3CB.Text && _reley_1_isConnected)
            {
                return false;
            }
            else if (RelayList1CB.Text == RelayList3CB.Text && _reley_3_isConnected)
            {
                return false;
            }
            else if (RelayList1CB.Text == RelayList4CB.Text && _reley_1_isConnected)
            {
                return false;
            }
            else if (RelayList1CB.Text == RelayList4CB.Text && _reley_4_isConnected)
            {
                return false;
            }

            else if (RelayList2CB.Text == RelayList3CB.Text && _reley_2_isConnected)
            {
                return false;
            }         
            else if (RelayList2CB.Text == RelayList3CB.Text && _reley_3_isConnected)
            {
                return false;
            }
            else if (RelayList2CB.Text == RelayList4CB.Text && _reley_2_isConnected)
            {
                return false;
            }
            else if (RelayList2CB.Text == RelayList4CB.Text && _reley_4_isConnected)
            {
                return false;
            }
            else if (RelayList3CB.Text == RelayList4CB.Text && _reley_3_isConnected)
            {
                return false;
            }
            else if (RelayList3CB.Text == RelayList4CB.Text && _reley_4_isConnected)
            {
                return false;
            }


            return true;

        }

        private bool validateSave(out string parametrName)
        {
            if (_myserialPort1 == null) 
            { 
                parametrName = "SerialPort";
                return false;
            }

            else if (_myRelay1 == null)
            {
                if (_myRelay2 == null)
                {
                    if (_myRelay3 == null)
                    {
                        if (_myRelay4 == null)
                        {
                            parametrName = "Relays";
                            return false;
                        }
                    }
                }

            }
            parametrName = "";
            return true;
        }

        #region DB Worke

        private void CrateDB_Click(object sender, EventArgs e)
        {
            bool crated = SQLiteHelper.CreateDB();
            if (crated)
            {
                MessageBox.Show("DB created");
                CrateDBTB.Enabled = false;
                SaveSetTB.Enabled = true;
            }
            else
            {
                MessageBox.Show("DB created error");
            }

        }

        private void DBConnectionTestBT_Click(object sender, EventArgs e)
        {
            bool connected;
            try
            {
                connected = SQLiteHelper.SqlConnectionTest();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                connected = false;
            }
            
            if (connected)
            {
                MessageBox.Show("DB Connection OK"); 
            }
            else
            {
                MessageBox.Show("DB Connection Failed","!!!!!!!!!!!!!!!!!");
            }
        }

        private async void SaveSetTB_Click(object sender, EventArgs e)
        {
            string parametr = "";
            if (!validateSave(out parametr))
            {

                MessageBox.Show($"There are nothing to Save check the {parametr} parameters", "Error");
                return;
            }

            DialogResult result = MessageBox.Show("Save The Settings??", "Question", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                return;
            }

            var inserted = SQLiteHelper.SQLSettingsWriter(this);

            if (inserted)
            {
                MessageBox.Show("Save Complete", "Notification");
            }
            else
            {
                MessageBox.Show("Save not Complete", "Error");
            }




        }

        private void DeleteDBTB_Click(object sender, EventArgs e)
        {
            try
            {
                SQLiteHelper.DeleteDB();
                CrateDBTB.Enabled = true;
                SaveSetTB.Enabled = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
           
        }



        #endregion

        private void IndicatorCOMBT_Paint(object sender, PaintEventArgs e)
        {
            Button button = (Button)sender;
            GraphicsPath buttonPath = new GraphicsPath();
            buttonPath.AddEllipse(0, 0, button.Width - 0, button.Height - 0);
            button.Region = new Region(buttonPath);
        }

        private void MyController_FormClosing(object sender, FormClosingEventArgs e)
        {

            _myserialPort1=null;
            _myserialPort2=null;
            _myserialPort3 = null;
            _myserialPort4=null;
            _myRelay1 = null;
            _myRelay2=null;
            _myRelay3=null;
            _myRelay4=null;
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            var sectionForm = new Sections(this);
            sectionForm.Show();
        }

        private void DeleteSetingsTB_Click(object sender, EventArgs e)
        {
            var answer = MessageBox.Show("Are you shure to delet settings??", "Question", MessageBoxButtons.YesNo);
            if (answer==DialogResult.Yes)
            {
                bool isDeleted = SQLiteHelper.SettingsClear();
            }
           

        }
    }
}

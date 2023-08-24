using RelayControll;
using System;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyМushroomController
{
    public partial class MyController : Form
    {


        string path = @"C:\Program Files (x86)\GAController\Settings.txt";
        StreamWriter _inFileWriter;
        FileInfo MySettingsFile;
        SerialPort _myserialPort;
        RelayControllCL _myRelay1;
        RelayControllCL _myRelay2;
        RelayControllCL _myRelay3;
        bool _reley_1_isConnected;
        bool _reley_2_isConnected;
        bool _reley_3_isConnected;

        public MyController()
        {
            InitializeComponent();

            RefreshMyComList();

            SettingFileCreater();


        }

        private async void SettingFileCreater()
        {
            MySettingsFile = new FileInfo(path);
            _inFileWriter = new StreamWriter(path, false);
            if (MySettingsFile.Exists)     ///////ete fayl@ ka kardal u katarel
            {




                _inFileWriter.Close();
            }
            else                          //////ete chka stexcum enq
            {
                MySettingsFile.Create();
            }

        }

        private void RefreshMyComList()
        {
            
           
            



            MyComPortsCB.Items.Clear();

            var myPorts =  SerialPort.GetPortNames();
            
            foreach (var Port in myPorts)
            {
                MyComPortsCB.Items.Add(Port);
            }

            COMBaudRateCB.Items.Add("9600");
            COMBaudRateCB.Items.Add("14400");
            COMBaudRateCB.Items.Add("19200");
            COMBaudRateCB.Items.Add("38400");
            COMBaudRateCB.Items.Add("57600");
            COMBaudRateCB.Items.Add("115200");
            COMBaudRateCB.Items.Add("128000");

           var myReleys = RelayControllCL.MyDeviceNames();
            foreach (var reley in myReleys)
            {
                RelayList1CB.Items.Add(reley);
                RelayList2CB.Items.Add(reley);
                RelayList3CB.Items.Add(reley);
            }
            

        }

        #region ComPort Settings

        private async void ConformComBT_Click(object sender, EventArgs e)
        {
           

            if (_myserialPort!=null)
            {
                _myserialPort.Close();
            }

            if (MyComPortsCB.Text == "")
            {
                MessageBox.Show("Select COM Port");
                return;
            }
            if (COMBaudRateCB.Text == "")
            {
                MessageBox.Show("Select COM Port BaudRate");
                return;
            }
            else
            {
                IndicatorCOMBT.Visible = true;

                _myserialPort = new SerialPort(MyComPortsCB.Text);
                _myserialPort.BaudRate = Convert.ToInt32(COMBaudRateCB.Text);
                _myserialPort.Parity = Parity.None;
                _myserialPort.StopBits = StopBits.One;
                _myserialPort.DataBits = 8;
                _myserialPort.Handshake = Handshake.None;

                _myserialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
                try
                {
                    _myserialPort.Open();
                    IndicatorCOMBT.BackColor = Color.Green;

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                    IndicatorCOMBT.BackColor = Color.Red;
                }
               


               
            }

        }

        #endregion

        #region Com Port Receive

        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            var mySerialDatas = _myserialPort.ReadLine();










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
            _reley_3_isConnected = _myRelay3.MyDeviceConnect(RelayList2CB.Text);
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
            else if (RelayList2CB.Text == RelayList3CB.Text && _reley_2_isConnected)
            {
                return false;
            }         
            else if (RelayList2CB.Text == RelayList3CB.Text && _reley_3_isConnected)
            {
                return false;
            }


            return true;

        }

        private async void SaveSetTB_Click(object sender, EventArgs e)
        {
            string parametr = "";
            if (!validateSave(out parametr))
            {

                MessageBox.Show($"There are nothing to Save check the {parametr} parameters","Error");
                return;
            }

            DialogResult result = MessageBox.Show("Save The Settings??", "Question", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                return;
            }

            _inFileWriter = new StreamWriter(path, false);
            await _inFileWriter.WriteLineAsync(DateTime.Now.ToString());
            await _inFileWriter.WriteLineAsync(_myserialPort.PortName);
            await _inFileWriter.WriteLineAsync(_myserialPort.BaudRate.ToString());
            await _inFileWriter.WriteLineAsync(_myserialPort.Parity.ToString());
            await _inFileWriter.WriteLineAsync(_myserialPort.StopBits.ToString());
            await _inFileWriter.WriteLineAsync(_myserialPort.DataBits.ToString());
            await _inFileWriter.WriteLineAsync(_myserialPort.Handshake.ToString());

            if (_reley_1_isConnected)
            {
                await _inFileWriter.WriteLineAsync(_myRelay1.MyDeviceInfo());
            }
            else if (_reley_2_isConnected)
            {
                await _inFileWriter.WriteLineAsync(_myRelay2.MyDeviceInfo());
            }
            else if (_reley_3_isConnected)
            {
                await _inFileWriter.WriteLineAsync(_myRelay3.MyDeviceInfo());
            }


            MessageBox.Show("Save Complete", "Notification");
            _inFileWriter.Close();

        }

        private bool validateSave(out string parametrName)
        {
            if (_myserialPort == null) 
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
                        parametrName = "Relays";
                        return false;
                    }
                }

            }
            parametrName = "";
            return true;
        }

        private void SettingBT_Click(object sender, EventArgs e)
        {
            SettingsForm MySetting = new SettingsForm(this);
            MySetting.Show();
        }
    }
}

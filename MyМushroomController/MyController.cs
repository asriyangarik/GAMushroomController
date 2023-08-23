using RelayControll;
using System;
using System.Drawing;
using System.IO.Ports;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyМushroomController
{
    public partial class MyController : Form
    {

        string _mySelectedCom;
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


        }
        private void RefreshMyComList()
        {
            _myRelay1 = new RelayControllCL();
            _myRelay2 = new RelayControllCL();
            _myRelay3 = new RelayControllCL();



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

        private void ConformComBT_Click(object sender, EventArgs e)
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

                _mySelectedCom = MyComPortsCB.Text;
                _myserialPort = new SerialPort(_mySelectedCom);
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




    }
}

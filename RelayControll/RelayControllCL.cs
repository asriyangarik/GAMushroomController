﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using USB_Relay_Control;

namespace RelayControll
{
    public class RelayControllCL
    {
        int _deviceHandle = 0;
        static List<usb_relay_device_info> devicesInfos;
        private usb_relay_device_info _mydevice;

        public string MyDeviceInfo()
        {
            try
            {
               
                return _mydevice.ToString();
            }
            catch (Exception)
            {

                return null;
            }


        }

        public static List<usb_relay_device_info> MyDeviceNames()
        {

            devicesInfos = new List<usb_relay_device_info>();
            usb_relay_device_info deviceInfo = RelayDeviceWrapper.usb_relay_device_enumerate();
            devicesInfos.Add(deviceInfo);

            while (deviceInfo.next.ToInt32() > 0)
            {
                deviceInfo = (usb_relay_device_info)Marshal.PtrToStructure(deviceInfo.next, typeof(usb_relay_device_info));
                devicesInfos.Add(deviceInfo);
            }
            return devicesInfos;

        }

        public bool MyDeviceConnect(string myModel)
        {
            try
            {

                foreach (var Mydevice in devicesInfos)
                {
                    var chouseDev = Mydevice.ToString();

                    if (chouseDev == myModel)
                    {
                        usb_relay_device_info device = Mydevice;
                        _mydevice = device;
                        _deviceHandle = RelayDeviceWrapper.usb_relay_device_open(ref device);
                        int numberOfRelays = (int)device.type;

                        uint status = 0;
                        RelayDeviceWrapper.usb_relay_device_get_status(_deviceHandle, ref status);

                        return true;
                    }

                }

                return false;

            }
            catch (Exception)
            {

                return false;
            }

        }

        public void MyDeviceDisConnect()
        {

            if (!_mydevice.Equals(null))
            {
                RelayDeviceWrapper.usb_relay_device_close(_deviceHandle);
            }

        }

        #region Rele On Off

        public void ReleOn(int ReleNum)
        {
            int openResult = RelayDeviceWrapper.usb_relay_device_open_one_relay_channel(_deviceHandle, ReleNum);
        }

        public void ReleOff(int ReleNum)
        {
            int Result = RelayDeviceWrapper.usb_relay_device_close_one_relay_channel(_deviceHandle, ReleNum);
        }

        public void AllReleOff()
        {
            for (int i = 0; i < Convert.ToInt16(_mydevice.type); i++)
            {
                int Result = RelayDeviceWrapper.usb_relay_device_close_one_relay_channel(_deviceHandle, i);
            }
        }

        #endregion
     
    }
}

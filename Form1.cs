using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;

using System.Threading;
using InTheHand.Net;
using InTheHand.Net.Sockets;
using InTheHand.Net.Bluetooth;

namespace EasyBluetoothFileTransfer {
    public partial class Form1 : Form {
        public Form1() { InitializeComponent(); }

        class _Bluetooth {
            /// <summary>
            /// Contains a list of 'Device Info' arrays (Avoids to scan every time for new devices)
            /// </summary>
            public static List<BluetoothDeviceInfo[]> DevicesInfo = new List<BluetoothDeviceInfo[]>();

            /// <summary>
            /// The thread where the 'SendFile' method will work
            /// </summary>
            public static Thread SendFile_Thread = null;

            /// <summary>
            /// Get if the operation is being aborted
            /// </summary>
            public static bool AbortOperation = false;

            /// <summary>
            /// Sends a file to the selected device
            /// </summary>
            /// <param name="filePath">The full local file path</param>
            /// <param name="receiverName">The name of the receiving device</param>
            /// <param name="_frm">Used only for the 'Send/Cancel' button</param>
            public static void SendFile(string filePath, string receiverName, Form1 _frm) {
                // We enumerate all the devices in the list
                foreach (var device in DevicesInfo[0]) {
                    // If the selected device from the list has the same name as the current device being scanned, we have found the right device
                    if (device.DeviceName == receiverName) {
                        // If the sender device and the receiver device aren't paired
                        if (!device.Authenticated) {
                            // We request the pairing process with a random PIN
                            if (!BluetoothSecurity.PairRequest(device.DeviceAddress, null)) {
                                // This will happen when the pairing process goes bad
                                MessageBox.Show("Unable to connect!", "Pair Request");

                                goto resetSendFileButton;
                            }
                        }

                        try {
                            // We create our request using a Uri string which contains the receiving device address and the local file path
                            ObexWebRequest obexWebRequest = new ObexWebRequest((new Uri(String.Format("obex://{0}/{1}", device.DeviceAddress, filePath))));
                            // Reads the entire file into memory (if you have a file bigger than 1.5 GB you will get an Out Of Memory exception)
                            obexWebRequest.ReadFile(filePath);


                            // When the file was read, we make the request and the receiving device will send back a response
                            ObexWebResponse obexWebResponse = (ObexWebResponse)obexWebRequest.GetResponse();
                                            obexWebResponse.Close();

                            // If the response is 'OK' and is the final response, the file was successfully sent
                            if (obexWebResponse.StatusCode == (ObexStatusCode.OK | ObexStatusCode.Final))
                                MessageBox.Show("File successfully sent!");
                            // Otherwise, if the receiving device reject our sending request, we show it to the user
                            else if (obexWebResponse.StatusCode == (ObexStatusCode.Forbidden | ObexStatusCode.Final))
                                MessageBox.Show("The other device rejected the request!");
                        } catch (Exception _e) {
                            // If something bad happens during the process and the user has not aborted the operation
                            // We show the exception error
                            if (!AbortOperation)
                                MessageBox.Show(String.Format("Message Error: {0}", _e.Message), "Something bad has happened");
                            else
                                // If the operation was aborted by the user, we need to set back to 'false' the 'AbortOperation' value for further operations
                                AbortOperation = false;
                        }

                        break;
                    }
                }

                // Used only to reset the text for the 'Send File' button
                resetSendFileButton:
                    _frm.sendCancelFile_btn.Invoke((MethodInvoker)delegate { _frm.sendCancelFile_btn.Text = "Send File"; });
            }
        }

        private void Form1_Load(object sender, EventArgs e) { }

        private void scanForDevices_btn_Click(object sender, EventArgs e) {
            // We first need to verify if the current device has the Bluetooth active (We can use this also to get if the device has a Bluetooth hardware component)
            if (BluetoothRadio.IsSupported) {
                scanForDevices_btn.Enabled = false;

                // Resets the 'DevicesInfo' list and the 'devicesAvailable' list view to avoid duplicate items
                _Bluetooth.DevicesInfo.Clear();
                devicesAvailable_listview.Items.Clear();

                using (BluetoothClient client = new BluetoothClient()) {
                    // This will add the 'Bluetooth Device Info' array returned by the client into our 'DevicesInfo' List
                    BluetoothDeviceInfo[] _devices = client.DiscoverDevices();

                    if (_devices.Length > 0)
                        _Bluetooth.DevicesInfo.Add(_devices);
                    else {
                        MessageBox.Show("No one device found!");

                        goto resetScanForDevicesButton;
                    }

                    foreach (var device in _Bluetooth.DevicesInfo[0])
                        // Adds the retrieved devices to the list
                        devicesAvailable_listview.Items.Add(device.DeviceName);
                }
            } else
                MessageBox.Show("Make sure that Bluetooth is on and the driver up to date", "Something bad has happened");

            resetScanForDevicesButton:
                scanForDevices_btn.Enabled = true;
        }

        private void devicesAvailable_listview_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e) {
            if (devicesAvailable_listview.SelectedItems.Count > 0) {
                foreach (var device in _Bluetooth.DevicesInfo[0]) {
                    if (device.DeviceName == devicesAvailable_listview.SelectedItems[0].Text) {
                        isAuthenticated_txtbox.Text    = device.Authenticated.ToString();
                        isConnected_txtbox.Text        = device.Connected.ToString();
                        lastSeen_txtbox.Text           = String.Format("{0:dd.MM.yyyy HH:mm}", device.LastSeen);
                        lastUsed_txtbox.Text           = String.Format("{0:dd.MM.yyyy HH:mm}", device.LastUsed);
                        remembered_txtbox.Text         = device.Remembered.ToString();
                        selectedDeviceName_txtbox.Text = device.DeviceName;

                        break;
                    }
                }

                if (selectedFileName_txtbox.TextLength > 0)
                    sendCancelFile_btn.Enabled = true;
            } else if (sendCancelFile_btn.Text != "Cancel") {
                sendCancelFile_btn.Enabled = false;
            }
        }

        private void devicesAvailable_listview_Leave(object sender, EventArgs e) {
            // If no one device is selected from the list, we disable the 'Send File' button
            if (devicesAvailable_listview.SelectedItems.Count == 0 && sendCancelFile_btn.Text != "Cancel")
                sendCancelFile_btn.Enabled = false;
        }

        private void selectFile_btn_Click(object sender, EventArgs e) {
            OpenFileDialog selectedFile = new OpenFileDialog {
                CheckFileExists = true,
                CheckPathExists = true,
                Title           = "Select which file to be sent"
            };

            if (selectedFile.ShowDialog() == DialogResult.OK) {
                FileInfo fileInfo = new FileInfo(selectedFile.FileName);

                selectedFileName_txtbox.Text   = fileInfo.Name;
                selectedFilePath_txtbox.Text   = fileInfo.DirectoryName;
                selectedFileLength_txtbox.Text = String.Format("{0:0.00}", (fileInfo.Length / 1024F));
            }
        }

        private void sendFile_btn_Click(object sender, EventArgs e) {
            switch (sendCancelFile_btn.Text) {
                case "Send File":
                    string fullFilePath     = String.Format("{0}\\{1}", selectedFilePath_txtbox.Text, selectedFileName_txtbox.Text);
                    string receiverName     = devicesAvailable_listview.SelectedItems[0].Text;
                    sendCancelFile_btn.Text = "Cancel";

                    _Bluetooth.SendFile_Thread = new Thread(() => _Bluetooth.SendFile(fullFilePath, receiverName, this));
                    _Bluetooth.SendFile_Thread.Start();

                break;

                case "Cancel":
                    if (MessageBox.Show("Are you sure?", "Abort the operation", MessageBoxButtons.YesNo, MessageBoxIcon.None, MessageBoxDefaultButton.Button2) == DialogResult.Yes) {
                        _Bluetooth.AbortOperation = true;
                        _Bluetooth.SendFile_Thread.Abort("testing");

                        sendCancelFile_btn.Text = "Send File";
                    }
                break;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e) {
            // This will occur when the user close the form but an operation is still alive
            // We force the thread to abort the work in order to close the tool
            try {
                _Bluetooth.SendFile_Thread.Abort();
            } catch { }
        }
    }
}

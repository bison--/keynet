using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace keynet
{
    public partial class frmMain : Form
    {
        public static int messageCounter = -1;
        public bool isServer = false;
        public frmMain()
        {
            InitializeComponent();
        }
                
        private void frmMain_Load(object sender, EventArgs e)
        {
            InterceptKeys.sendUdpPackets = (int)nutUdpPackets.Value;
            InterceptKeys.main = this;
            InterceptKeys.start();
            //switchMode(false);
        }

        private void switchMode(bool _isServer)
        {
            isServer = _isServer;
            if (!isServer && !bgwReciever.IsBusy)
            {
                bgwReciever.RunWorkerAsync(getReceiverSettings());
            }
            else
            {
                bgwReciever.CancelAsync();
            }
        }

        public clsRecieverSettings getReceiverSettings()
        {
            clsRecieverSettings rc = new clsRecieverSettings();
            rc.allowedIp = txtRecieverIp.Text;
            rc.port = (UInt16)nutRecieverPort.Value;

            return rc;
        }

        private void rdbClient_CheckedChanged(object sender, EventArgs e)
        {
            switchMode(false);
        }

        private void rdbServer_CheckedChanged(object sender, EventArgs e)
        {
            switchMode(true);
        }

        private void nutUdpPackets_ValueChanged(object sender, EventArgs e)
        {
            InterceptKeys.sendUdpPackets = (int)nutUdpPackets.Value;
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            InterceptKeys.stop();
        }

        private void bgwReciever_DoWork(object sender, DoWorkEventArgs e)
        {
            clsRecieverSettings rSettings = (clsRecieverSettings)e.Argument;
            try
            {
                UdpClient Server = new UdpClient(rSettings.port);
                IPEndPoint ClientEp = new IPEndPoint(IPAddress.Any, 0);

                while (!bgwReciever.CancellationPending)
                {
                    byte[] ClientRequestData = Server.Receive(ref ClientEp);
                    string ClientRequest = Encoding.ASCII.GetString(ClientRequestData);
                    string senderIp = ClientEp.Address.ToString();
                    Console.WriteLine("Recived {0} from {1}, sending response", ClientRequest, senderIp);
                    //Server.Send(ResponseData, ResponseData.Length, ClientEp);
                    if (rSettings.allowedIp == "" || rSettings.allowedIp == senderIp)
                    {
                        string keystring = ClientRequest;
                        if (keystring.Contains("|"))
                        {
                            Char delimiter = '|';
                            string[] parts = keystring.Split(delimiter);
                            bgwReciever.ReportProgress(int.Parse(parts[1]), parts[0]);
                        }
                    }
                    else
                    {
                        Console.WriteLine("BAD IP: " + senderIp);
                    }

                }
                
                //e.Result = keystring;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void bgwReciever_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (e.ProgressPercentage > messageCounter)
            {
                try
                {
                    string thePressedKey = e.UserState.ToString();
                    Console.WriteLine("GOT: " + thePressedKey);
                    if (thePressedKey == "Escape")
                    {
                        SendKeys.Send("{ESCAPE}");
                    }
                    else if (thePressedKey == "Space")
                    {
                        SendKeys.Send(" ");
                    }
                    else
                    {
                        SendKeys.Send(thePressedKey);
                    }
                    lblRecieved.Text = e.UserState.ToString();
                }
                catch (Exception ex)
                {
                    lblRecieved.Text = ex.ToString();
                }

                messageCounter = e.ProgressPercentage;
                
            }
        }

        private void bgwReciever_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!isServer)
            {
                if (e.Result != null)
                {
                    lblRecieved.Text = e.Result.ToString();
                }
                
                //Keys recievedKey = (Keys)e.Result;
                bgwReciever.RunWorkerAsync(getReceiverSettings());
            }
        }


    }
}

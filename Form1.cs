using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace ChatUI
{
    public partial class Form1 : Form
    {
        Socket sck;
        EndPoint epLocal, epRemote;
        byte[] buffer;
        public Form1()
        {
            InitializeComponent();
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            string message = messageTextBox.Text;
            var timeStamp = DateTime.Now.ToString();
            UTF8Encoding aEncoding = new UTF8Encoding();
            byte[] sendingMessage = new byte[1500];
            sendingMessage = aEncoding.GetBytes(messageTextBox.Text);
            sck.Send(sendingMessage);
            if (string.IsNullOrWhiteSpace(nameTextBox.Text) || string.IsNullOrWhiteSpace(message))
            {
                MessageBox.Show("¬веди ник или сообщение", "ќшибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                messagesBox.Items.Add($"Me: {message} [{timeStamp}]\r\n");
                messageTextBox.Clear();
            }
        }

        private void messageTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                sendButton_Click(this, new EventArgs());

                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            messagesBox.Items.Clear();
        }

        private void connectionButton_Click(object sender, EventArgs e)
        {
            epLocal = new IPEndPoint(IPAddress.Parse(ipLocalBox.Text), Convert.ToInt32(localPortBox.Text));
            sck.Bind(epLocal);

            epRemote = new IPEndPoint(IPAddress.Parse(ipTextBox.Text), Convert.ToInt32(targetPortBox.Text));
            sck.Connect(epRemote);

            buffer = new byte[1500];
            sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);
        }

        private string GetLocalIP()
        {   
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }    
            return "127.0.0.1";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           sck = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
           sck.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);

           ipLocalBox.Text = GetLocalIP();
           ipTextBox.Text = GetLocalIP();
        }

        private void MessageCallBack(IAsyncResult aResult)
        {
            try
            {
                var timeStamp = DateTime.Now.ToString();
                byte[] receivedData = new byte[1500];
                receivedData = (byte[])aResult.AsyncState;
                UTF8Encoding aEncoding = new UTF8Encoding();
                string receivedMessage = aEncoding.GetString(receivedData);

                messagesBox.Items.Add($"Friend: {receivedMessage} [{timeStamp}]\r\n");

                buffer = new byte[1500];
                sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }



        }
    }
}
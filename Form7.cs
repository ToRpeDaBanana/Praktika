using System;
using System.Net;
using System.Net.Sockets;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UDP_Chat
{
    public partial class Form7 : Form
    {
        bool alive = false;
        UdpClient client;
        const int LOCALPORT = 8001;
        const int REMOTEPORT = 8001;
        const int TTL = 20;
        const string HOST = "235.5.5.1";
        IPAddress groupAddress;

        string userName;

        public Form7()
        {
            InitializeComponent();

            loginButton.Enabled = true;
            logoutButton.Enabled = false;
            sendButton.Enabled = false;
            chatTextBox.ReadOnly = true;

            groupAddress = IPAddress.Parse(HOST);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            chatTextBox.ScrollBars = ScrollBars.Vertical;
            chatTextBox.AcceptsReturn = true;
            chatTextBox.WordWrap = true;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            userName = Praktika.StaticData.Login;
            userNameTextBox.ReadOnly = true;

            try
            {
                client = new UdpClient(LOCALPORT);
                client.JoinMulticastGroup(groupAddress, TTL);

                Task receiveTask = new Task(ReceiveMessages);
                receiveTask.Start();

                string message = userName + " присоединяется к нам!";
                byte[] data = Encoding.Unicode.GetBytes(message);
                client.Send(data, data.Length, HOST, REMOTEPORT);

                loginButton.Enabled = false;
                logoutButton.Enabled = true;
                sendButton.Enabled = true;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void ReceiveMessages()
        {
            alive = true;
            try
            {
                while (alive)
                {
                    IPEndPoint remoteIp = null;
                    byte[] data = client.Receive(ref remoteIp);
                    string message = Encoding.Unicode.GetString(data);

                    this.Invoke((MethodInvoker) delegate
                        {
                        string time = DateTime.Now.ToShortTimeString();
                        chatTextBox.Text = time + " " + message + "\r\n" + chatTextBox.Text;
                        });
                }
            }
            catch (ObjectDisposedException)
            {
                if (!alive)
                    return;
                throw;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            try
            {
                string message = String.Format("{0}: {1}", userName, messageTextBox.Text);
                byte[] data = Encoding.Unicode.GetBytes(message);
                client.Send(data, data.Length, HOST, REMOTEPORT);
                messageTextBox.Clear();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            ExitChat();
        }

        private void ExitChat()
        {
            string message = userName + " покидает нас!";
            byte[] data = Encoding.Unicode.GetBytes(message);
            client.Send(data, data.Length, HOST, REMOTEPORT);
            client.DropMulticastGroup(groupAddress);

            alive = false;
            client.Close();

            loginButton.Enabled = true;
            logoutButton.Enabled = false;
            sendButton.Enabled = false;
            userNameTextBox.ReadOnly = false;
        }

        private void Form1_FormClosing(object sender, FormClosedEventArgs e)
        {
            if (alive)
                ExitChat();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Внутренний чат";
        }

        private void userNameTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                loginButton_Click(loginButton, null);
                messageTextBox.Focus();
            }
        }

        private void messageTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                sendButton_Click(sendButton, null);
            }
        }

        private void userNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
